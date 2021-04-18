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
    public partial class ComprarLivro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = getData();
            var db = new CarrinhoDB();

            if (carrinho.Id == 0)
            {
                if (db.Insert(carrinho))
                {
                    LblMsg.Text = "Registro inserido!";
                    LoadGrid();
                }
                else
                    LblMsg.Text = "Erro ao inserir registro";
            }
        }

        private void LoadGrid()
        {
            GVCarrinho.DataSource = new CarrinhoDB().GetAll();
            GVCarrinho.DataBind();
        }

        private Carrinho getData()
        {
            return new Carrinho()
            {
                Id_cliente = txtcliente.Text,
                Nome = txtNome.Text,
                Id_livro = txtlivro.Text,
                Titulo = txtTitulo.Text
            };
        }

    }
}