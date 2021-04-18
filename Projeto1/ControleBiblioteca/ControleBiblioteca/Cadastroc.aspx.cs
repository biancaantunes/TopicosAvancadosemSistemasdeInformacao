using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleBiblioteca
{
    public partial class Cadastroc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = getData();
            var db = new ClienteDB();

            if (cliente.Id == 0)
            {
                if (db.Insert(cliente))
                {
                    LblMsg.Text = "Registro inserido!";
                    LoadGrid();
                }
                else
                    LblMsg.Text = "Erro ao inserir registro";
            }
            /*else
            {

                if (db.Update(cliente))
                {
                    LblMsg.Text = "Registro atualizado!";
                }
                else
                {
                    LblMsg.Text = "Erro ao atualizar registro";
                }
            }*/
        }

        private void LoadGrid()
        {
            GVCliente.DataSource = new ClienteDB().GetAll();
            GVCliente.DataBind();
        }

        private Cliente getData()
        {
            return new Cliente()
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                Endereco = txtEndereco.Text,
                Cidade = txtCidade.Text,
                Pais = txtPais.Text,
                Cep = txtCep.Text,
                NumerodoCartao = txtCartao.Text,
                DatadeValidade = txtValidade.Text,
                CodigodeSeguranca = txtcodigo.Text

            };
        }
    }
}