namespace Padarosa2023.Views
{
    partial class GerenciamentoUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.txbEmailCad = new System.Windows.Forms.TextBox();
            this.txbSenhaCad = new System.Windows.Forms.TextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblApagar = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbNovaSenha = new System.Windows.Forms.TextBox();
            this.txbEmailEdi = new System.Windows.Forms.TextBox();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txbNomeEdi = new System.Windows.Forms.TextBox();
            this.lblGenUsuario = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(22, 65);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(540, 252);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.btnCad);
            this.grbCadastro.Controls.Add(this.txbSenhaCad);
            this.grbCadastro.Controls.Add(this.txbEmailCad);
            this.grbCadastro.Controls.Add(this.lblSenhaCad);
            this.grbCadastro.Controls.Add(this.lblEmailCad);
            this.grbCadastro.Controls.Add(this.lblNomeCad);
            this.grbCadastro.Controls.Add(this.txbNomeCad);
            this.grbCadastro.Location = new System.Drawing.Point(22, 340);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(264, 135);
            this.grbCadastro.TabIndex = 2;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(94, 19);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(123, 20);
            this.txbNomeCad.TabIndex = 0;
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(6, 22);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(84, 13);
            this.lblNomeCad.TabIndex = 1;
            this.lblNomeCad.Text = "Nome completo:";
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Location = new System.Drawing.Point(53, 49);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCad.TabIndex = 2;
            this.lblEmailCad.Text = "Email:";
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.Location = new System.Drawing.Point(47, 78);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaCad.TabIndex = 3;
            this.lblSenhaCad.Text = "Senha:";
            // 
            // txbEmailCad
            // 
            this.txbEmailCad.Location = new System.Drawing.Point(94, 49);
            this.txbEmailCad.Name = "txbEmailCad";
            this.txbEmailCad.Size = new System.Drawing.Size(123, 20);
            this.txbEmailCad.TabIndex = 4;
            // 
            // txbSenhaCad
            // 
            this.txbSenhaCad.Location = new System.Drawing.Point(94, 78);
            this.txbSenhaCad.Name = "txbSenhaCad";
            this.txbSenhaCad.Size = new System.Drawing.Size(123, 20);
            this.txbSenhaCad.TabIndex = 5;
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCad.Location = new System.Drawing.Point(16, 104);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(178, 23);
            this.btnCad.TabIndex = 6;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(38, 473);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(475, 53);
            this.grbApagar.TabIndex = 3;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.Location = new System.Drawing.Point(22, 25);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(201, 16);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione o usuário para apagar:";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbNovaSenha);
            this.grbEditar.Controls.Add(this.txbEmailEdi);
            this.grbEditar.Controls.Add(this.lblNovaSenha);
            this.grbEditar.Controls.Add(this.lblEmail);
            this.grbEditar.Controls.Add(this.lblNomeCompleto);
            this.grbEditar.Controls.Add(this.txbNomeEdi);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(311, 340);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(251, 135);
            this.grbEditar.TabIndex = 4;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Edição";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditar.Location = new System.Drawing.Point(25, 104);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(169, 25);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // txbNovaSenha
            // 
            this.txbNovaSenha.Location = new System.Drawing.Point(94, 78);
            this.txbNovaSenha.Name = "txbNovaSenha";
            this.txbNovaSenha.Size = new System.Drawing.Size(123, 20);
            this.txbNovaSenha.TabIndex = 5;
            // 
            // txbEmailEdi
            // 
            this.txbEmailEdi.Location = new System.Drawing.Point(94, 49);
            this.txbEmailEdi.Name = "txbEmailEdi";
            this.txbEmailEdi.Size = new System.Drawing.Size(123, 20);
            this.txbEmailEdi.TabIndex = 4;
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Location = new System.Drawing.Point(22, 81);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(68, 13);
            this.lblNovaSenha.TabIndex = 3;
            this.lblNovaSenha.Text = "Nova senha:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(53, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(6, 22);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(84, 13);
            this.lblNomeCompleto.TabIndex = 1;
            this.lblNomeCompleto.Text = "Nome completo:";
            // 
            // txbNomeEdi
            // 
            this.txbNomeEdi.Location = new System.Drawing.Point(94, 19);
            this.txbNomeEdi.Name = "txbNomeEdi";
            this.txbNomeEdi.Size = new System.Drawing.Size(123, 20);
            this.txbNomeEdi.TabIndex = 0;
            // 
            // lblGenUsuario
            // 
            this.lblGenUsuario.AutoSize = true;
            this.lblGenUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenUsuario.Location = new System.Drawing.Point(84, 22);
            this.lblGenUsuario.Name = "lblGenUsuario";
            this.lblGenUsuario.Size = new System.Drawing.Size(191, 19);
            this.lblGenUsuario.TabIndex = 5;
            this.lblGenUsuario.Text = "Gerenciamento de Usuários";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Red;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.Black;
            this.btnApagar.Location = new System.Drawing.Point(389, 18);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // GerenciamentoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 528);
            this.Controls.Add(this.lblGenUsuario);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "GerenciamentoUsuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuarios";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txbSenhaCad;
        private System.Windows.Forms.TextBox txbEmailCad;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbNovaSenha;
        private System.Windows.Forms.TextBox txbEmailEdi;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txbNomeEdi;
        private System.Windows.Forms.Label lblGenUsuario;
    }
}