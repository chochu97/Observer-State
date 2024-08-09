using Domain.Contracts;
using Domain.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Bateria : ISujetoBateria
    {
        List<IObserverSuscriptor> susus;

        
        int carga;

        public Estado estado;
        public int Carga
        {
            get
            {
                return carga;
            }
            set
            {
                carga = value;
                TiempoCarga = 100 - carga;
                TiempoUso = carga;
            }
        } 
        
        public int TiempoCarga { get; set; }
        public int TiempoUso { get; set; }

        public Bateria(int carga)
        {
            susus = new List<IObserverSuscriptor>();
            Carga = carga;
            estado = new Conectado();
            
        }

        public void Desuscribir(IObserverSuscriptor sus)
        {
            if (susus.Contains(sus))
            {
                susus.Remove(sus);
            }
        }

        public void Notificar()
        {
            string on;
            if(susus.Count != 0)
            {
                foreach (var item in susus)
                {
                    item.Actualizar(this);
                }
            }
            else
            {
                Console.WriteLine("No hay objetos suscritos al objeto Bateria");
            }
            
            
        }

        public void Suscribir(IObserverSuscriptor sus)
        {
            if (!susus.Contains(sus))
            {
                susus.Add(sus);
            }
        }



        // ----------------------------------------

        public void DefinirEstado(Estado state)
        {
            estado = state;
            
            Notificar();
        }

        public void Accionar()
        {
            estado.ControlarEstado(this);
        }
    }
}
