using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Domain.State
{
    public class Desconectado : Estado
    {
        public override string Name { get => "Desconectado"; }

        public override void ControlarEstado(Bateria bat)
        {
            bat.DefinirEstado(new Conectado());
            
        }
    }
}
