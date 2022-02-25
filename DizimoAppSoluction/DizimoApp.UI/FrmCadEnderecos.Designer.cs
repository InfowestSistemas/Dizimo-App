
namespace DizimoApp.UI
{
    partial class FrmCadEnderecos
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(518, 264);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dizimo APP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DizimoApp.UI.Properties.Resources.Dizimo;
            this.pictureBox1.Location = new System.Drawing.Point(457, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(375, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dizimo APP";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DizimoApp.UI.Properties.Resources.Dizimo;
            this.pictureBox2.Location = new System.Drawing.Point(457, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(319, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cadastro de Endereços";
            // 
            // txtEndereço
            // 
            this.txtEndereço.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEndereço.Location = new System.Drawing.Point(26, 123);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(310, 20);
            this.txtEndereço.TabIndex = 3;
            this.txtEndereço.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumero.Location = new System.Drawing.Point(344, 123);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(53, 20);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCep.Location = new System.Drawing.Point(26, 161);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(89, 20);
            this.txtCep.TabIndex = 3;
            this.txtCep.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBairro.Location = new System.Drawing.Point(26, 199);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(89, 20);
            this.txtBairro.TabIndex = 3;
            this.txtBairro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.BackColor = System.Drawing.Color.White;
            this.lblEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereço.ForeColor = System.Drawing.Color.Black;
            this.lblEndereço.Location = new System.Drawing.Point(24, 108);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(52, 12);
            this.lblEndereço.TabIndex = 1;
            this.lblEndereço.Text = "Endereço";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.White;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.Black;
            this.lblNumero.Location = new System.Drawing.Point(342, 108);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 12);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.BackColor = System.Drawing.Color.White;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.ForeColor = System.Drawing.Color.Black;
            this.lblCep.Location = new System.Drawing.Point(24, 146);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(25, 12);
            this.lblCep.TabIndex = 1;
            this.lblCep.Text = "Cep";
            this.lblCep.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.White;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.Black;
            this.lblTelefone.Location = new System.Drawing.Point(24, 226);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(48, 12);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.UseWaitCursor = true;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.White;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 88);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(518, 264);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(26, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCidade.Location = new System.Drawing.Point(155, 199);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(89, 20);
            this.txtCidade.TabIndex = 3;
            this.txtCidade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.White;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.Black;
            this.lblCidade.Location = new System.Drawing.Point(153, 184);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 12);
            this.lblCidade.TabIndex = 1;
            this.lblCidade.Text = "Cidade";
            // 
            // txtUF
            // 
            this.txtUF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUF.Location = new System.Drawing.Point(284, 199);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(33, 20);
            this.txtUF.TabIndex = 3;
            this.txtUF.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.White;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(12, 88);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(518, 264);
            this.listBox3.TabIndex = 0;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.BackColor = System.Drawing.Color.White;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.ForeColor = System.Drawing.Color.Black;
            this.lblUF.Location = new System.Drawing.Point(282, 184);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(20, 12);
            this.lblUF.TabIndex = 1;
            this.lblUF.Text = "UF";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefone.Location = new System.Drawing.Point(26, 241);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(89, 20);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bairro";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCadastrar.Location = new System.Drawing.Point(210, 283);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(116, 26);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // FrmCadEnderecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(542, 364);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "FrmCadEnderecos";
            this.Text = "Cadastro de Endereços";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrar;
    }
}