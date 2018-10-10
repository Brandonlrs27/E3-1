using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1
{
    class Program
    { //Lares Dominguez Brandon
        static void Main(string[] args)
        {          
            //Menu para seleccionar Opciones, primero se agrega la clase, luego datos de alumnos y finalmente se muestran.
            int menu = 0;
            //Aqui es creada la lista
            List<Tec> Isc = new List<Tec>();
            Tec Salon;
            //WHile para el menu
            do
            {
                Console.Clear();
                Console.WriteLine("Consulta de calificaciones.");
                Console.WriteLine("Escoga una opcion: ");
                Console.WriteLine("\n1.- Agregar Clases");
                Console.WriteLine("2.- Agregar alumnos");
                Console.WriteLine("3.- Ver alumnos");
                Console.WriteLine("4.- Salir");             
                menu = Convert.ToInt16(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        //Aqui escogemos cuantas clases habra, conforme ese valor, creara el for para determinar nombre de materia y su cantidad de alumnos.
                        Console.Write("Numero de clases: ");
                        int cl = Convert.ToInt16(Console.ReadLine());
                        for (int i = 0; i < cl; i++)
                        {
                            Console.Write("Nombre de la materia: ");
                            string Nom = Console.ReadLine();
                            Console.Write("Cuantos alumnos tiene la materia? ");
                            int Alumnos = Convert.ToInt16(Console.ReadLine());
                            //Aqui crea una clase Salon que ingresa en la lista con datos de cantidad de alumnos y nombre de materia.
                            Salon = new Tec(Alumnos, Nom);
                            Isc.Add(Salon);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        //Aqui es para agregar los alumnos con el metodo para ingresar sus nombres y calificaciones.
                        //Foreach para cada clase creada con Salon en la lista.
                        foreach (Tec i in Isc)
                        {
                            i.Alumnos();
                        }
                        break;
                    case 3:
                        //Utilizando igualmente las clases creadas con Salon, vemos los datos por materia  de los alumnos.
                        foreach (Tec i in Isc)
                        {
                            Console.Clear();
                            i.Ver();
                            Console.ReadKey();
                        }
                        break;
                    default:
                        //Para finalizar el programa.
                        Console.WriteLine("Presione cualquier tecla para salir");
                        Console.ReadKey();
                        break;
                }
            } while (menu != 4);
        }
    }
    //Primero comence creando la clase Tec que seria donde estaran los metodos para la lista y sus propiedades.
    public class Tec
    {
        //Cree una variable para nombre de materias, otro en modo de Array para nombres de alumnos por materia y el ultimo para sus calificaciones.
        public string Clases;
        public string[] Alum;
        public int[] Calif;
        //Este es mas que nada para agregar cantidad de alumnos y sus nombres de materias a las listas.
        public Tec(int Alumnos, string Nom)
        {
            Clases = Nom;
            Alum = new string[Alumnos];
            Calif = new int[Alumnos];
        }
        //Primer metodo es para Introducir nombre del alumno en cada materia y su respectiva calificacion.
        public void Alumnos()
        {
            //For para introducir nombre del alumno
            for (int i = 0; i < Alum.Length; i++)
            {
                Console.Clear();
                Console.Write("Clase {0} \nNombre del alumno: ", Clases);
                Alum[i] = Console.ReadLine();
            }
            //For para introducir calificacion.
            int num ;
            num = Alum.Length;
            for (int j = 0; j < Alum.Length; j++)
            {
                
                Console.Write("\nIntroduzca la calificacion del alumno {0} :", num);
                num = num - 1;
                Calif[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
        //Metodo que imprime calificaciones por materia con nombre del alumno y su calificacion respectivamente.
        public void Ver()
        {
            //Utilizando la longitud de cuantos alumnos es como va imprimiendo los datos.
            Console.WriteLine("Calificaciones de la materia {0} :", Clases);
            for (int i = 0; i < Alum.Length; i++)
            {
                Console.Write(Alum[i]);
                Console.Write(" ");            
                Console.Write(Calif[i]);
                Console.WriteLine("");
            }
        }
    }
}





