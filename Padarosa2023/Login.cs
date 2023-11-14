using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Instanciar o usuário:

            Classes.Usuario usuario= new Classes.Usuario();
            usuario.Email= txbEmail.Text;
            usuario.Senha= txbSenha.Text;

            // Obter o resultado do SELECT no banco:
            var resultado = usuario.Logar();

            if (resultado.Rows.Count == 1)
            {
                // Senha correta: proseeguir:
                usuario.NomeCompleto = resultado.Rows[0]["Nome_completo"].ToString();
                usuario.Id = (int)resultado.Rows[0]["id"];
                MessageBox.Show(usuario.NomeCompleto);
                // Próximo passo abrir a janela menu:
                MenuPrincipal janela = new MenuPrincipal(usuario);
                // Esconder a janela atual:
                Hide();
                // Mostrar o menu;
                
                janela.ShowDialog();
                // Mostrar o login quando o menu fechar:
                Show();
            }
           else
            {
                // Senha incorreta:
                MessageBox.Show("Email ou senha incorretos.", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
