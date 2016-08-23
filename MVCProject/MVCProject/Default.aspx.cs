using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MVCProject.Negocio.Objects;
using MVCProject.Negocio.Controller;

namespace MVCProject
{
    public partial class _Default : Page
    {
        UsuarioController _usuarioController;

        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioObj usuario = new UsuarioObj();
            usuario.nomeUsuario = "Mauricio";
            usuario.dataNascimento = Convert.ToDateTime("29/03/1982");
            usuario.conjuge = "Gisele bul";

            //instancia
            _usuarioController = new UsuarioController();
            _usuarioController.inserirUsuarioMeuQualquer(usuario);

            teste();
        }

        private void teste()
        {
            _usuarioController.updateUsuario();
        }
    }
}