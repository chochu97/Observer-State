using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bateria bat = new Bateria(90);
            SuscriptorBitacora sus = new SuscriptorBitacora();
            SuscriptorVisual susu = new SuscriptorVisual();

            bat.Accionar();
            Console.ReadKey();

            bat.Suscribir(susu);
            bat.Accionar();
            Console.ReadKey();

            bat.Suscribir(sus);
            bat.Accionar();
            bat.Accionar();
            Console.ReadKey();

            sus.MostrarBitacora();

            Console.ReadKey();
        }
    }
}
