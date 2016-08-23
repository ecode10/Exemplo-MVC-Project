using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Negocio.Objects
{
    public class UsuarioObj
    {
        public string nomeUsuario { get; set; }

        public DateTime dataNascimento { get; set; }

        public string cpf { get; set; }

        public string conjuge { get; set; }

        public string identidade { get; set; }

        public string orgaoExpedidor { get; set; }

    }
}
