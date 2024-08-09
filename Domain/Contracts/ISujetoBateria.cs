using Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public interface ISujetoBateria
    {
        void Suscribir(IObserverSuscriptor sus);

        void Desuscribir(IObserverSuscriptor sus);

        void Notificar();
    }
}
