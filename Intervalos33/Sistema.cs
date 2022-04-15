using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervalos33
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();
            Console.WriteLine("\n Recuerde seguir las instrucciones. Presione cualquier tecla para continuar");


            DateTime fechaUno = Validador.ValidarFechaIngresada("\n Ingrese una fecha y sabrá cuantos dias faltan " +
                                                                "para fin de año.");

            DateTime fechaDos = new DateTime(fechaUno.Year,12,31);

            TimeSpan intervaloTiempo = fechaDos.Subtract(fechaUno);


            Console.Clear();
            Console.WriteLine("\n Faltan: " + intervaloTiempo.Days / 1 + " días" +
                              "\n Para el 31 de Diciembre del " +fechaUno.Year + ".");

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
