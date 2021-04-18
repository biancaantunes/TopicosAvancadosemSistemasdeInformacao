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
    public partial class CadastroL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Livro livro = getData();
            var db = new LivroDB();

            if (livro.Id == 0)
            {
                if (db.Insert(livro))
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
            GVLivro.DataSource = new LivroDB().GetAll();
            GVLivro.DataBind();
        }

        private Livro getData()
        {
            return new Livro()
            {
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                Editora = txtEditora.Text,
                DatadeLancamento = txtDatadeLancamento.Text,
                Preco = txtPreco.Text
            };
        }
    }
}