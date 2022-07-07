﻿
namespace DizimoApp.UI
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadMembros = new System.Windows.Forms.ToolStripMenuItem();
            this.cadMovimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.Relatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_ListaCadastros = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblContatoSelecionado = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaCadastros)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 502);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(996, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadMembros,
            this.cadMovimentos,
            this.Relatorios});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cadMembros
            // 
            this.cadMembros.Name = "cadMembros";
            this.cadMembros.Size = new System.Drawing.Size(191, 22);
            this.cadMembros.Text = "Cadastro de Membros";
            this.cadMembros.Click += new System.EventHandler(this.cadMembros_Click);
            // 
            // cadMovimentos
            // 
            this.cadMovimentos.Name = "cadMovimentos";
            this.cadMovimentos.Size = new System.Drawing.Size(191, 22);
            this.cadMovimentos.Text = "Lançamentos";
            this.cadMovimentos.Click += new System.EventHandler(this.cadMovimentos_Click);
            // 
            // Relatorios
            // 
            this.Relatorios.Name = "Relatorios";
            this.Relatorios.Size = new System.Drawing.Size(191, 22);
            this.Relatorios.Text = "Relatórios";
            this.Relatorios.Click += new System.EventHandler(this.Relatorios_Click);
            // 
            // dataGridView_ListaCadastros
            // 
            this.dataGridView_ListaCadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListaCadastros.Location = new System.Drawing.Point(12, 97);
            this.dataGridView_ListaCadastros.Name = "dataGridView_ListaCadastros";
            this.dataGridView_ListaCadastros.Size = new System.Drawing.Size(984, 402);
            this.dataGridView_ListaCadastros.TabIndex = 15;
            this.dataGridView_ListaCadastros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ListaCadastros_CellClick);
            this.dataGridView_ListaCadastros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ListaCadastros_CellContentClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPesquisar.Location = new System.Drawing.Point(384, 36);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(86, 33);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.Location = new System.Drawing.Point(12, 37);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(366, 33);
            this.txbPesquisa.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(367, -6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(309, 30);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Lista de Membros cadastrados";
            this.lblTitulo.Click += new System.EventHandler(this.lblPesquisar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditar.Location = new System.Drawing.Point(476, 37);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 32);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.Location = new System.Drawing.Point(568, 37);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(86, 32);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(938, 56);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // lblContatoSelecionado
            // 
            this.lblContatoSelecionado.AutoSize = true;
            this.lblContatoSelecionado.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContatoSelecionado.Location = new System.Drawing.Point(12, 73);
            this.lblContatoSelecionado.Name = "lblContatoSelecionado";
            this.lblContatoSelecionado.Size = new System.Drawing.Size(174, 19);
            this.lblContatoSelecionado.TabIndex = 22;
            this.lblContatoSelecionado.Text = "Contato Selecionado :";
            this.lblContatoSelecionado.Visible = false;
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(192, 73);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(69, 21);
            this.lblContato.TabIndex = 21;
            this.lblContato.Text = "Contato";
            this.lblContato.Visible = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(996, 524);
            this.Controls.Add(this.lblContatoSelecionado);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dataGridView_ListaCadastros);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaCadastros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadMembros;
        private System.Windows.Forms.ToolStripMenuItem cadMovimentos;
        private System.Windows.Forms.ToolStripMenuItem Relatorios;
        private System.Windows.Forms.DataGridView dataGridView_ListaCadastros;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblContatoSelecionado;
        private System.Windows.Forms.Label lblContato;
    }
}