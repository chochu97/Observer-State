using Domain.Contracts;
using Domain.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SuscriptorBitacora : IObserverSuscriptor
    {
        
        public List<Bateria> bitacora = new List<Bateria>();

        string IObserverSuscriptor.Name => "SuscriptorBitacora";

        public void Actualizar(Bateria bateria)
        {
               bitacora.Add(bateria);
            Console.WriteLine("Notificacion para: SuscriptoraBitacora, Cambio del Estado de Bateria: " + bateria.estado.Name);
        }

        public void MostrarBitacora()
        {
            foreach(var item in bitacora)
            {
                Console.WriteLine("\nBateria Conectada? : " + item.estado.Name);
                Console.WriteLine("Porcentaje de Carga : " + item.Carga + "%");
                if (item.estado is Desconectado)
                {
                    Console.WriteLine("Tiempo Estimado de Uso : " + item.TiempoUso + " minutos");
                }
                else
                {
                    Console.WriteLine("Al estar la bateria conectada, no hay un tiempo de uso restante estimado");
                }
            }
        }
    }
}
