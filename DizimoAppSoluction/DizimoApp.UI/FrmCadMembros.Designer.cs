
namespace DizimoApp.UI
{
    partial class FrmCadMembros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGridView_Cadastros = new System.Windows.Forms.DataGridView();
			this.btn_Voltar = new System.Windows.Forms.Button();
			this.btnCadastrar_Enderecos = new System.Windows.Forms.Button();
			this.btnListarUsuarios = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblTelefone = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.checkBoxStatus = new System.Windows.Forms.CheckBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cadastros)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.ForeColor = System.Drawing.SystemColors.Window;
			this.btnExcluir.Location = new System.Drawing.Point(367, 132);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(86, 32);
			this.btnExcluir.TabIndex = 2;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Window;
			this.btnCadastrar.Location = new System.Drawing.Point(181, 132);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(88, 32);
			this.btnCadastrar.TabIndex = 2;
			this.btnCadastrar.Text = "Salvar";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.SystemColors.Window;
			this.btnEditar.Location = new System.Drawing.Point(275, 132);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(86, 32);
			this.btnEditar.TabIndex = 2;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Window;
			this.label1.Location = new System.Drawing.Point(269, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Dizimo App";
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Window;
			this.label2.Location = new System.Drawing.Point(6, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Listagem de Membros";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(0, -12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(769, 86);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DizimoApp.UI.Properties.Resources.Dizimo;
			this.pictureBox1.Location = new System.Drawing.Point(680, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(83, 65);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// dataGridView_Cadastros
			// 
			this.dataGridView_Cadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Cadastros.Location = new System.Drawing.Point(6, 170);
			this.dataGridView_Cadastros.Name = "dataGridView_Cadastros";
			this.dataGridView_Cadastros.Size = new System.Drawing.Size(763, 242);
			this.dataGridView_Cadastros.TabIndex = 3;
			// 
			// btn_Voltar
			// 
			this.btn_Voltar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Voltar.ForeColor = System.Drawing.Color.White;
			this.btn_Voltar.Location = new System.Drawing.Point(3, 428);
			this.btn_Voltar.Name = "btn_Voltar";
			this.btn_Voltar.Size = new System.Drawing.Size(83, 32);
			this.btn_Voltar.TabIndex = 4;
			this.btn_Voltar.Text = "Voltar";
			this.btn_Voltar.UseVisualStyleBackColor = false;
			this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
			// 
			// btnCadastrar_Enderecos
			// 
			this.btnCadastrar_Enderecos.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnCadastrar_Enderecos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar_Enderecos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCadastrar_Enderecos.Location = new System.Drawing.Point(596, 428);
			this.btnCadastrar_Enderecos.Name = "btnCadastrar_Enderecos";
			this.btnCadastrar_Enderecos.Size = new System.Drawing.Size(167, 31);
			this.btnCadastrar_Enderecos.TabIndex = 5;
			this.btnCadastrar_Enderecos.Text = "Cadastrar Enderecos";
			this.btnCadastrar_Enderecos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCadastrar_Enderecos.UseVisualStyleBackColor = false;
			this.btnCadastrar_Enderecos.Click += new System.EventHandler(this.btnCadastrar_Enderecos_Click);
			// 
			// btnListarUsuarios
			// 
			this.btnListarUsuarios.Location = new System.Drawing.Point(111, 433);
			this.btnListarUsuarios.Name = "btnListarUsuarios";
			this.btnListarUsuarios.Size = new System.Drawing.Size(75, 23);
			this.btnListarUsuarios.TabIndex = 6;
			this.btnListarUsuarios.Text = "Listar Usuarios";
			this.btnListarUsuarios.UseVisualStyleBackColor = true;
			this.btnListarUsuarios.Click += new System.EventHandler(this.btnListarUsuarios_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(9, 106);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(202, 20);
			this.textBox1.TabIndex = 7;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(217, 106);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(131, 20);
			this.textBox2.TabIndex = 8;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(354, 106);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 9;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(9, 84);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(41, 13);
			this.lblNome.TabIndex = 10;
			this.lblNome.Text = "Nome :";
			// 
			// lblTelefone
			// 
			this.lblTelefone.AutoSize = true;
			this.lblTelefone.Location = new System.Drawing.Point(214, 84);
			this.lblTelefone.Name = "lblTelefone";
			this.lblTelefone.Size = new System.Drawing.Size(55, 13);
			this.lblTelefone.TabIndex = 11;
			this.lblTelefone.Text = "Telefone :";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(351, 84);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(38, 13);
			this.lblEmail.TabIndex = 12;
			this.lblEmail.Text = "Email :";
			// 
			// checkBoxStatus
			// 
			this.checkBoxStatus.AutoSize = true;
			this.checkBoxStatus.Location = new System.Drawing.Point(460, 108);
			this.checkBoxStatus.Name = "checkBoxStatus";
			this.checkBoxStatus.Size = new System.Drawing.Size(56, 17);
			this.checkBoxStatus.TabIndex = 13;
			this.checkBoxStatus.Text = "Státus";
			this.checkBoxStatus.UseVisualStyleBackColor = true;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(89, 132);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(86, 32);
			this.btnPesquisar.TabIndex = 14;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			// 
			// FrmCadMembros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(768, 462);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.checkBoxStatus);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblTelefone);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnListarUsuarios);
			this.Controls.Add(this.btnCadastrar_Enderecos);
			this.Controls.Add(this.btn_Voltar);
			this.Controls.Add(this.dataGridView_Cadastros);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmCadMembros";
			this.Text = "Cadastro de Membros";
			this.Load += new System.EventHandler(this.FrmCadMembros_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cadastros)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_Cadastros;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btnCadastrar_Enderecos;
		private System.Windows.Forms.Button btnListarUsuarios;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblTelefone;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.CheckBox checkBoxStatus;
		private System.Windows.Forms.Button btnPesquisar;
	}
}