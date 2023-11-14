﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa2023
{
    public partial class MenuPrincipal : Form
    {

        // Obejetos globais:
        Classes.Usuario Usuario = new Classes.Usuario();
        public MenuPrincipal(Classes.Usuario usuario)
        {
            InitializeComponent();


            //Atribuir o usuário local no global:
            this.Usuario = usuario;


            // Mudar a lei de apresentação:
            lblSaudacao.Text = "Olá, " + usuario.NomeCompleto;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuários_Click(object sender, EventArgs e)
        {
            // Instanciar a janela:
            Views.GerenciamentoUsuarios janela = new Views.GerenciamentoUsuarios();
            janela.Show();
        }
    }
}
