using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleTransporte
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista()
        {
            transporteurbanoEntities context = new transporteurbanoEntities();
            List<TB_TRANSPORTE> lstTransporte = context.TB_TRANSPORTE.ToList<TB_TRANSPORTE>();

            GVTransporte.DataSource = lstTransporte;
            GVTransporte.DataBind();
        }

        protected void GVTransporte_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idItem = Convert.ToInt32(e.CommandArgument.ToString());
            transporteurbanoEntities contextTransporte = new transporteurbanoEntities();
            TB_TRANSPORTE transporte = new TB_TRANSPORTE();

            transporte = contextTransporte.TB_TRANSPORTE.First(c => c.id == idItem);

            if (e.CommandName == "ALTERAR")
            {
                Response.Redirect("CadastroPonto.aspx?idItem=" + idItem);
            }
            else if (e.CommandName == "EXCLUIR")
            {
                contextTransporte.TB_TRANSPORTE.Remove(transporte);
                contextTransporte.SaveChanges();
                string msg = "Excluída com sucesso !";
                string titulo = "Informação";
                CarregarLista();
                DisplayAlert(titulo, msg, this);
            }
        }

        public void DisplayAlert(string titulo, string mensagem, System.Web.UI.Page page)
        {
            h1.InnerText = titulo;
            lblMsgPopup.InnerText = mensagem;
            ClientScript.RegisterStartupScript(typeof(Page), Guid.NewGuid().ToString(),
                "MostrarPopupMensagem();", true);
        }
    }
}