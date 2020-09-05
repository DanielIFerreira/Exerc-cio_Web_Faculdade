using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;

namespace WebUI
{
    public partial class CadastroNoticias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Noticia noticia = new Noticia();
            noticia.Titulo = txtTitulo.Text;
            noticia.DataPublicacao = Convert.ToDateTime(txtDataPublicacao.Text);
            noticia.Texto = txtTexto.Text;


            NoticiaDAL noticiaDAL = new NoticiaDAL();
            noticiaDAL.InserirNoticia(noticia);
            LimparDados();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            NoticiaDAL noticiaDAL = new NoticiaDAL();
            noticiaDAL.ExcluirNoticia(codigo);
            LimparDados();
        }

        public void LimparDados()
        {
            txtCodigo.Text = "";
            txtDataPublicacao.Text = "";
            txtTexto.Text = "";
            txtTitulo.Text = "";
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            Noticia noticia = new Noticia();
            noticia.Codigo = Convert.ToInt32(txtCodigo.Text);
            noticia.Titulo = txtTitulo.Text;
            noticia.DataPublicacao = Convert.ToDateTime(txtDataPublicacao.Text);
            noticia.Texto = txtTexto.Text;

            NoticiaDAL noticiaDAL = new NoticiaDAL();
            noticiaDAL.AtualizarNoticia(noticia);
            LimparDados();
        }
    }
}