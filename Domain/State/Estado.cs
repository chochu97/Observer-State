using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.State
{
    public abstract class Estado
    {
        public abstract string Name { get;}
        public abstract void ControlarEstado(Bateria bat);
        
    }
}
