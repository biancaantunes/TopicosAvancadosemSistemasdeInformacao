using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleTransporte
{
    public partial class CadastroPonto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDadosPagina();
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string ruaTransporte = txtRua.Text;
            string bairroTransporte = txtBairro.Text;
            string horarioTransporte = txtHorario.Text;
            TB_TRANSPORTE v = new TB_TRANSPORTE() { rua = ruaTransporte, bairro = bairroTransporte, horario = horarioTransporte };
            transporteurbanoEntities contextTransporte = new transporteurbanoEntities();

            string valor = Request.QueryString["idItem"];

            if (String.IsNullOrEmpty(valor))
            {
                contextTransporte.TB_TRANSPORTE.Add(v);
                lblmsg.Text = "Registro Inserido!";
                Clear();
            }
            else
            {
                int id = Convert.ToInt32(valor);
                TB_TRANSPORTE transporte = contextTransporte.TB_TRANSPORTE.First(c => c.id == id);
                transporte.rua = v.rua;
                transporte.bairro = v.bairro;
                transporte.horario = v.horario;
                lblmsg.Text = "Registro Alterado";
            }
            contextTransporte.SaveChanges();
        }

        private void Clear()
        {
            txtRua.Text = "";
            txtBairro.Text = "";
            txtHorario.Text = "";
            txtRua.Focus();
        }

        private void CarregarDadosPagina()
        {
            string valor = Request.QueryString["idItem"];
            int idItem = 0;
            TB_TRANSPORTE transporte = new TB_TRANSPORTE();


            if (!String.IsNullOrEmpty(valor))
            {
                transporteurbanoEntities contextTransporte = new transporteurbanoEntities();
                idItem = Convert.ToInt32(valor);
                transporte = contextTransporte.TB_TRANSPORTE.First(c => c.id == idItem);

                txtRua.Text = transporte.rua;
                txtBairro.Text = transporte.bairro;
                txtHorario.Text = transporte.horario;
            }
        }
    }
}