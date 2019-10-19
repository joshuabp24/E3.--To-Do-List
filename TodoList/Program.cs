using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se instancia la clase principal y se manda a llamar al metodo que de la bienvenida
            Principal p = new Principal();
            p.Bienvenido();
        }
    }
}
