using Domain.Contracts;
using Domain.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SuscriptorVisual : IObserverSuscriptor
    {
        public string Name => "SuscriptorVisual";

        public void Actualizar(Bateria bateria)
        {
            Console.WriteLine("\nNotificacion para: SuscriptorVisual, Cambio del Estado de Bateria: " + bateria.estado.Name);
            Console.WriteLine("\nBateria Conectada? : " + bateria.estado.Name);
            Console.WriteLine("Porcentaje de Carga : " + bateria.Carga + "%");
            if (bateria.estado is Desconectado)
            {
                Console.WriteLine("Tiempo Estimado de Uso : " + bateria.TiempoUso + " minutos");
            }
            else
            {
                Console.WriteLine("Al estar la bateria conectada, no hay un tiempo de uso restante estimado");
            }
        }
    }
}
