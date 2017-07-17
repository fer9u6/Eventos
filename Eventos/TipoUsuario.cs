using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class TipoUsuario
    {
        int tipoUsuario;

        public TipoUsuario()
        {
            tipoUsuario = 0;
        } 

        public int getTipoUsuario()
        {
            return tipoUsuario;
        }

        public void setTipoUsuario(int t)
        {
            tipoUsuario = t;
        }
    }
}
