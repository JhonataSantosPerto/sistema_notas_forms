
namespace sistema_notas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNome1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnMediaTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AllowUserToResizeColumns = false;
            this.dgvAlunos.AllowUserToResizeRows = false;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOME,
            this.NOTA1,
            this.NOTA2,
            this.NOTA3,
            this.MEDIA});
            this.dgvAlunos.Location = new System.Drawing.Point(13, 56);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.RowHeadersVisible = false;
            this.dgvAlunos.Size = new System.Drawing.Size(742, 488);
            this.dgvAlunos.TabIndex = 7;
            // 
            // NOME
            // 
            this.NOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME.FillWeight = 253.8071F;
            this.NOME.HeaderText = "Nome";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // NOTA1
            // 
            this.NOTA1.FillWeight = 61.54816F;
            this.NOTA1.HeaderText = "Nota 1";
            this.NOTA1.Name = "NOTA1";
            this.NOTA1.ReadOnly = true;
            // 
            // NOTA2
            // 
            this.NOTA2.FillWeight = 61.54816F;
            this.NOTA2.HeaderText = "Nota 2";
            this.NOTA2.Name = "NOTA2";
            this.NOTA2.ReadOnly = true;
            // 
            // NOTA3
            // 
            this.NOTA3.FillWeight = 61.54816F;
            this.NOTA3.HeaderText = "Nota 3";
            this.NOTA3.Name = "NOTA3";
            this.NOTA3.ReadOnly = true;
            // 
            // MEDIA
            // 
            this.MEDIA.FillWeight = 61.54816F;
            this.MEDIA.HeaderText = "Média";
            this.MEDIA.Name = "MEDIA";
            this.MEDIA.ReadOnly = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(408, 18);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 2;
            this.txtNota2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota3_KeyPress);
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(525, 20);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 3;
            this.txtNota3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtNota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota3_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 2);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(293, 18);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 1;
            this.txtNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota3_KeyPress);
            // 
            // txtNome1
            // 
            this.txtNome1.Location = new System.Drawing.Point(12, 18);
            this.txtNome1.Name = "txtNome1";
            this.txtNome1.Size = new System.Drawing.Size(263, 20);
            this.txtNome1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(654, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(290, 2);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(42, 13);
            this.lblNota1.TabIndex = 7;
            this.lblNota1.Text = "Nota 1:";
            this.lblNota1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(405, 2);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(42, 13);
            this.lblNota2.TabIndex = 8;
            this.lblNota2.Text = "Nota 2:";
            this.lblNota2.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(522, 2);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(42, 13);
            this.lblNota3.TabIndex = 9;
            this.lblNota3.Text = "Nota 3:";
            // 
            // btnResultado
            // 
            this.btnResultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResultado.Location = new System.Drawing.Point(12, 552);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(101, 23);
            this.btnResultado.TabIndex = 5;
            this.btnResultado.Text = "Resultado Geral";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnMediaTotal
            // 
            this.btnMediaTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMediaTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMediaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaTotal.Location = new System.Drawing.Point(635, 552);
            this.btnMediaTotal.Name = "btnMediaTotal";
            this.btnMediaTotal.Size = new System.Drawing.Size(120, 23);
            this.btnMediaTotal.TabIndex = 6;
            this.btnMediaTotal.Text = "Média dos Alunos";
            this.btnMediaTotal.UseVisualStyleBackColor = false;
            this.btnMediaTotal.Click += new System.EventHandler(this.btnMediaTotal_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 587);
            this.Controls.Add(this.btnMediaTotal);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNome1);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvAlunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Sistema de Notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNome1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnMediaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDIA;
    }
}

