using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class RepoTodoList
    {
        //Metodo para crear tarea
        public List<Tarea> CrearTarea(List<Tarea> ListaT)
        {//Se instancia la clase tarea para llenar un objeto el cual luego se pasara a la lista mandada
            Tarea t = new Tarea();
            Console.WriteLine("Ingrese el nombre de la persona a cargo de la actividad");
            t.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la actividad");
            t.Actividad = Console.ReadLine();
            Console.WriteLine("Ingrese la hora");
            t.Hora = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha");
            t.Fecha = Console.ReadLine();
            Console.WriteLine("Ingrese el status");
            t.Status = Console.ReadLine();
            //aqui se añade dicho objeto a la lista
            ListaT.Add(t);
            return ListaT;
        }
        //Metodo para listar tareas
        public List<Tarea> ListarTareas(List<Tarea> ListaT)
        {
            //Aqui se utiliza un foreach para imprimir cada una de las actividades que estan en la lista
            foreach (var T in ListaT)
            {
                if(ListaT.Count != 0)
                {
                    Console.WriteLine(T.Actividad);                    
                }
            }
            return ListaT;
        }
        public List<Tarea> DetalleTarea(List<Tarea> ListaT)
        {//Metodo para mostrar los detalles de una tarea
            //aqui creo una variable contador para utilizar mas adelante en un if
            int c=0;
            Console.WriteLine("Escriba el nombre de la actividad de la cual quiera saber sus detalles. NOTA: Respete mayusculas");
            string Act = Console.ReadLine();
            Console.Clear();
            //aqui el foreach evalua que la lista contenga algo de no ser asi no hara nada, y luego un if nos evalua si el nombre ingresado coincide con alguno de la lista y de ser asi procede a imprimir los detalles
            foreach (var T in ListaT)
            {
                if(ListaT.Count != 0)
                {
                    if (T.Actividad == Act)
                    {
                        Console.WriteLine(T.Actividad);
                        Console.WriteLine(T.Nombre);
                        Console.WriteLine(T.Hora);
                        Console.WriteLine(T.Fecha);
                        Console.WriteLine(T.Status);
                        Console.WriteLine();
                        c = c + 1;
                    }
                }
                
                
            }
            //if en donde atravez del contador anteriormente mencionado se le informa al usuario que el nombre de la actividad no es valido o esta mal escrito
            if (c == 0)
            {
                Console.WriteLine("Nombre invalido o mal escrito");
                Console.WriteLine();
            }
            return ListaT;
        }
        //Metodo para listar status
        public List<Tarea> ListarStatus(List<Tarea> ListaT)
        {//Foreach para listar el status de las actividades
            foreach (var T in ListaT)
            {
                if(ListaT.Count != 0)
                {
                    Console.WriteLine(T.Actividad + ": " + T.Status);                
                }           
            }
            
            return ListaT;
        }
        //Metodo para cambiar un status
        public List<Tarea> CambiarStatus(List<Tarea> ListaT)
        {
            Console.WriteLine("Escriba el nombre de la actividad de la cual quiera cambiar su status. NOTA: Respete mayusculas");
            string Act = Console.ReadLine();
            //Al igual que en el de mostrar detalles de una actividad aqui tambien se evalua si el nombre coincide para proceder de una forma u otra.
            foreach (var T in ListaT)
            {
                if(ListaT.Count != 0)
                {
                    if (T.Actividad == Act)
                    {
                        Console.WriteLine("Ingrese el nuevo status de " + T.Actividad);
                        //Aqui cree una variable temporal para almacenar el valor guardado de t.status antes de cambiar para mostrar el cambio de resultado
                        string temp = T.Status;
                        T.Status = Console.ReadLine();
                        Console.WriteLine("Se cambio el status de: *" + temp + " a *" + T.Status);
                    }
                }                        
            }
            return ListaT;
        }

    }
}
