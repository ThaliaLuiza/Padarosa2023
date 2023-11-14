using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa2023.Views
{
    public partial class GerenciamentoUsuarios : Form
    {
        // Atributos 
        int idSelecinado = 0;
        public GerenciamentoUsuarios()
        {
            InitializeComponent();
            Classes.Usuario usuario= new Classes.Usuario();
            // Atribuir a tabela (resultado do select) no DGV:
            dgvUsuarios.DataSource = usuario.ListarTudo();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
          // Instanciar o usuário:
          Classes.Usuario usuario= new Classes.Usuario();
            // Obter os valores dos campos:
            usuario.NomeCompleto = txbNomeCad.Text;
            usuario.Email = txbEmailCad.Text;
            usuario.Senha = txbSenhaCad.Text;

            if (usuario.Cadastrar() == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                //Limpar os campos:
                txbNomeCad.Clear();
                txbEmailCad.Clear();
                txbSenhaCad.Clear();
                //Atualizar o dgv:
                dgvUsuarios.DataSource = usuario.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar usuário!");
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os groupsBox:
            grbEditar.Enabled= true;
            grbApagar.Enabled= true;

            // Obter a linha clicada:

            int linhaSelecionada = dgvUsuarios.CurrentCell.RowIndex;
            // Armazenar os dados da linha selecionada em "linha" (tipo um vetor):
            var linha = dgvUsuarios.Rows[linhaSelecionada];

            txbNomeEdi.Text = linha.Cells[1].Value.ToString();
            txbEmailEdi.Text = linha.Cells[1].Value.ToString();
            // Juntar o ID o nome para existir no apagar:
            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o id dp selecionado na variável global:
            idSelecinado = (int)linha.Cells[0].Value;

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario= new Classes.Usuario();
            usuario.Id = idSelecinado;

            // Apagar:
        }
    }
}
