using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class Principal
    {//Aqui proceso a instanciar en global las variables del tipo clase y en el constructor las creo para que existan antes y no se borren datos
        RepoTodoList R;
        List<Tarea> ListaT;
        public Principal()
        {
            ListaT = new List<Tarea>();
            R = new RepoTodoList();
        }
        //Creacion del metodo bienvenida, donde tambien se manda a llamar al metodo menu
        public void Bienvenido()
        {
            Console.WriteLine("---BIENVENIDO--AL--PROGRAMA---");
            Console.WriteLine("Presione cualquier tecla para ingresar al menu");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        //Creacion del metodo menu donde se le dan las instrucciones al usuario de como utilizarlo
        public void Menu()
        {
            Console.WriteLine("---MENU---");
            Console.WriteLine("Ingrese uno de los siguientes valores segun su preferencia.  \nNota: Cada vez que termine en cada opcion se le regresara al menu");
            Console.WriteLine("1- Crear tarea\n2- Lista de tarea\n3- Detalle de alguna de las tareas\n4- Lista de status\n5- Cambiar status de alguna tarea\n6- Salir del programa");
            //Creacion del switch
            switch(Console.ReadLine())
            {
                //En este caso se llama al metodo para crear una tarea
                case "1":
                    Console.Clear();
                    R.CrearTarea(ListaT);
                    Console.Clear();
                    Menu();
                    break;
                    //En este casos e llama al metodo para listar las tareas ya creadas
                case "2":
                    Console.Clear();
                    R.ListarTareas(ListaT);
                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier tecla para regresar al menu");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                //En este casos e llama al metodo encargado de mostrar los detalles de una tarea
                case "3":
                    Console.Clear();
                    R.DetalleTarea(ListaT);
                    Console.WriteLine("Presione cualquier tecla para regresar al menu");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                //En este casos e llama al metodo encargado de listar los status de las actividades
                case "4":
                    Console.Clear();
                    R.ListarStatus(ListaT);
                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier tecla para regresar al menu");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                //En este casos e llama al metodo encargado de cambiar algun status de alguna de las actividades
                case "5":
                    Console.Clear();
                    R.CambiarStatus(ListaT);
                    Console.WriteLine("Presione cualquier tecla para regresar al menu");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Seleccion invalida, regresando al menu");
                    Menu();
                    break;
            }
        }

        
    }
}
