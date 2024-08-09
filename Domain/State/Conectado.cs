using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.State
{
    public class Conectado : Estado
    {
        public override string Name { get => "Conectado"; }

        public override void ControlarEstado(Bateria bat)
        {
            bat.DefinirEstado(new Desconectado());
            
        }
    }
}
