using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{//Aqui se crea la clase Tarea donde se le asignan sus atributos los cuales para mayor comodidad y flexibilidad son de tipo string
    public class Tarea
    {
        public string Nombre { get; set; }
        public string Actividad { get; set; }
        public string Hora { get; set; }
        public string Fecha { get; set; }
        public string Status { get; set; }
    }
}
