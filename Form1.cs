using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_notas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// método que limpa os dados
        /// </summary>
        void limpaDados()
        {
            txtNome1.Text = string.Empty;
            txtNota1.Text = string.Empty;
            txtNota2.Text = string.Empty;
            txtNota3.Text = string.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Botão que insere as notas de um aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                //cáculo da média
                decimal nota1 = Convert.ToDecimal(txtNota1.Text);
                decimal nota2 = Convert.ToDecimal(txtNota2.Text);
                decimal nota3 = Convert.ToDecimal(txtNota3.Text);
                decimal media = (nota1 + nota2 + nota3) / 3;
                media = decimal.Round(media, 2);

                // Adicionando no DataGridView
                dgvAlunos.Rows.Add();
                dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["NOME"].Value = txtNome1.Text;
                dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["NOTA1"].Value = nota1;
                dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["NOTA2"].Value = nota2;
                dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["NOTA3"].Value = nota3;
                dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["MEDIA"].Value = media;

                // Colorindo colunas

                if (media < 60)
                {
                    dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["MEDIA"].Style.BackColor = Color.Red;
                    dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["MEDIA"].Style.SelectionBackColor = Color.Red;
                }
                else
                {
                    dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["MEDIA"].Style.BackColor = Color.Green;
                    dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["MEDIA"].Style.SelectionBackColor = Color.Green;
                }

                // chamar método que limpa dados
                limpaDados();
            }

        }
        /// <summary>
        /// Método que valida uma nota preenchida
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private bool validaNumero(string numero)
        {
            //tenta converter a nota para decimal
            try
            {
                Convert.ToDecimal(numero);
                return false;
            }

            // caso não consiga, exibe uma mensagem ao usuario
            catch (Exception)
            {
                MessageBox.Show("Digite uma nota válida!");
                return true;
            }
        }
        /// <summary>
        /// Método que valida dados
        /// </summary>
        /// <returns></returns>
        private bool validaDados()
        {
            // verifica se o nome digitado é valido
            if (txtNome1.Text.Replace(" ", "") == string.Empty)
            {
                MessageBox.Show("Digite um nome valido!");
                txtNome1.Focus();
                return false;
            }
            // verifica se a nota digitado é valido
            else if (validaNumero(txtNota1.Text.Replace(",", ".")))
            {
                MessageBox.Show("Digite uma nota válida!");
                txtNota1.Focus();
                return false;
            }
            else if (validaNumero(txtNota2.Text.Replace(",", ".")))
            {
                MessageBox.Show("Digite uma nota válida!");
                txtNota1.Focus();
                return false;
            }
            else if (validaNumero(txtNota3.Text.Replace(",", ".")))
            {
                MessageBox.Show("Digite uma nota válida!");
                txtNota1.Focus();
                return false;
            }
            // Verifica se a nota esta entre 0 e 100
            else if(Convert.ToDecimal(txtNota1.Text.Replace(",",".")) > 100 || Convert.ToDecimal(txtNota1.Text.Replace(",", ".")) < 0)
            {
                MessageBox.Show("Digite uma nota válida!");
                txtNota1.Focus();
                return false;
            }
            else if (Convert.ToDecimal(txtNota2.Text.Replace(",", ".")) > 100 || Convert.ToDecimal(txtNota1.Text.Replace(",", ".")) < 0)
            {
                MessageBox.Show("Digite uma nota válida!");
                txtNota2.Focus();
                return false;
            }
            else if (Convert.ToDecimal(txtNota3.Text.Replace(",", ".")) > 100 || Convert.ToDecimal(txtNota1.Text.Replace(",", ".")) < 0)
            {
                MessageBox.Show("Digite uma nota válida!");
                txtNota3.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Botão que mostra o resultado geral
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResultado_Click(object sender, EventArgs e)
        {
            int qtdAprovados = 0;
            int qtdReprovados = 0;

            //Percorre o o grid(tabela) contabilizando os alunos aprovados e reprovados
            for (int i = 0; i < dgvAlunos.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dgvAlunos.Rows[i].Cells["MEDIA"].Value) < 60)
                {
                    qtdReprovados++;
                }
                else
                {
                    qtdAprovados++;
                }
            }
            MessageBox.Show(qtdAprovados + " Alunos Aprovados \n" + qtdReprovados + " Alunos Reprovados");
        }

        /// <summary>
        /// Evento que mostra a media geral dos alunos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMediaTotal_Click(object sender, EventArgs e)
        {
            decimal mediaGeral = 0;

            // Verifica se existe algum aluno no Grid (tabela)
            if (dgvAlunos.Rows.Count > 0)
            {

                //Passa por cada linha do grid (tabela)

                for (int i = 0; i < dgvAlunos.Rows.Count; i++)
                {
                    mediaGeral += Convert.ToDecimal(dgvAlunos.Rows[i].Cells["MEDIA"].Value);
                }

                mediaGeral = mediaGeral / dgvAlunos.Rows.Count;
                MessageBox.Show(("A média geral dos alunos é: " + decimal.Round(mediaGeral, 2)));
            }
            // se não tiver alunos 
            else
            {
                MessageBox.Show("Não há alunos inseridos");
            }
        }

        private void txtNota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifica se o digitado é diferente de numero e pontuação
            if (!char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                //cancela ação
                e.Handled = true;
            }
        }
    }
}

