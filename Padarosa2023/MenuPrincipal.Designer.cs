namespace Padarosa2023
{
    partial class MenuPrincipal
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
            this.lblMenuPricipal = new System.Windows.Forms.Label();
            this.btnComandas = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnUsuários = new System.Windows.Forms.Button();
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuPricipal
            // 
            this.lblMenuPricipal.AutoSize = true;
            this.lblMenuPricipal.Font = new System.Drawing.Font("Bodoni MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPricipal.Location = new System.Drawing.Point(83, 21);
            this.lblMenuPricipal.Name = "lblMenuPricipal";
            this.lblMenuPricipal.Size = new System.Drawing.Size(261, 38);
            this.lblMenuPricipal.TabIndex = 0;
            this.lblMenuPricipal.Text = "Menu Principal : : Padarosa";
            // 
            // btnComandas
            // 
            this.btnComandas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComandas.Location = new System.Drawing.Point(89, 92);
            this.btnComandas.Name = "btnComandas";
            this.btnComandas.Size = new System.Drawing.Size(125, 71);
            this.btnComandas.TabIndex = 1;
            this.btnComandas.Text = "Comandas";
            this.btnComandas.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.Location = new System.Drawing.Point(220, 92);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(124, 71);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnCaixa
            // 
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.Location = new System.Drawing.Point(89, 169);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(255, 38);
            this.btnCaixa.TabIndex = 3;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnUsuários
            // 
            this.btnUsuários.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuários.Location = new System.Drawing.Point(89, 213);
            this.btnUsuários.Name = "btnUsuários";
            this.btnUsuários.Size = new System.Drawing.Size(255, 33);
            this.btnUsuários.TabIndex = 4;
            this.btnUsuários.Text = "Usuários";
            this.btnUsuários.UseVisualStyleBackColor = true;
            this.btnUsuários.Click += new System.EventHandler(this.btnUsuários_Click);
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Location = new System.Drawing.Point(87, 76);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(0, 13);
            this.lblSaudacao.TabIndex = 5;
//            this.lblSaudacao.Click += new System.EventHandler(this.lblSaudacao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Padarosa2023.Properties.Resources.Custom_Icon_Design_Flatastic_1_Delete_1_48;
            this.pictureBox1.Location = new System.Drawing.Point(396, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 324);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSaudacao);
            this.Controls.Add(this.btnUsuários);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnComandas);
            this.Controls.Add(this.lblMenuPricipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuPricipal;
        private System.Windows.Forms.Button btnComandas;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnUsuários;
        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}