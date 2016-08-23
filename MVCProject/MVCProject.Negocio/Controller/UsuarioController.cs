
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//import
using MVCProject.Negocio.Objects;
using MVCProject.Negocio.Model;


namespace MVCProject.Negocio.Controller
{
    /// <summary>
    /// Controller
    /// Esta classe é responsável pela regra de negocio e chamada para model
    /// </summary>
    public class UsuarioController
    {
        UsuarioModel _usuarioModel;

        /// <summary>
        /// Método construtor da classe
        /// </summary>
        public UsuarioController()
        {
            if (_usuarioModel == null)
                _usuarioModel = new UsuarioModel();
        }

        public Boolean updateUsuario()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean inserirUsuarioMeuQualquer(UsuarioObj obj)
        {
            try
            {
                Boolean bRetorno = _usuarioModel.insertUsuario(obj);
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
    }
}
