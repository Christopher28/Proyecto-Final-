using System;

namespace Sui_generis_program
{
    class Program
    {
        private static bool y;

        static void Main(string[] args)
        {
        //Estas son mis variables
            int NotaDe80a100 = 0;
            int NotaDe70a79 = 0;
            int NotaDe50a69 = 0;
            int NotaMenorOIgual49 = 0;
            string NotaEstudiante;
        //Presentacion
        Console.WriteLine("_____________________________________________________________________________________");
        Console.WriteLine("__Bienvenido al leector de calificaciones Seccion 0463 de Programacion Estructurada__");
        Console.WriteLine("_____________________________________________________________________________________");
        Console.WriteLine("__Christopher Alcantara        17-EIIT-1-049_________________________________________");
        Console.WriteLine("__Dara Reyes                   17-EIIN-1-005_________________________________________");
        Console.WriteLine("__Elaine Rodriguez             17-EIIT-1-003_________________________________________");
        Console.WriteLine("__Jose Mariño                  17-EIIT-1-042_________________________________________");
        Console.WriteLine("__Elias Matos                  17-EIIT-1-047_________________________________________");    
        Console.WriteLine("_____________________________________________________________________________________");    
            
        //Ciclo for 
            for (int i = 1; i < 11; i++)
            {


                Console.WriteLine("Digite la calificacion para el estudiante > " + i + ".");
                NotaEstudiante = Console.ReadLine();
               
                    if (Convert.ToInt32(NotaEstudiante) <= 0 || Convert.ToInt32(NotaEstudiante) > 100)
                    {
                    //Ciclo do while
                        do {
                        Console.WriteLine("Nota Fuera de Rango");
                        Console.WriteLine("Digite una nota valida entre 1 a 100");
                        NotaEstudiante = Console.ReadLine();
                        break;
                    }while (Convert.ToInt32(NotaEstudiante) >= 1 || Convert.ToInt32(NotaEstudiante) <= 100);
                    }



                    if (Convert.ToInt32(NotaEstudiante) > 79 && Convert.ToInt32(NotaEstudiante) <= 100)
                {
                    NotaDe80a100 = NotaDe80a100 + 1;
                }
                    if (Convert.ToInt32(NotaEstudiante) > 69 && Convert.ToInt32(NotaEstudiante) <= 79)
                {
                    NotaDe70a79 = NotaDe70a79 + 1;
                }
                    if (Convert.ToInt32(NotaEstudiante) > 49 && Convert.ToInt32(NotaEstudiante) <= 69)
                {
                    NotaDe50a69 = NotaDe50a69 + 1;
                }
                if (Convert.ToInt32(NotaEstudiante) <= 49)
                {
                    NotaMenorOIgual49 = NotaMenorOIgual49 + 1;
                }

            }
            Console.WriteLine("La Cantidad De Estudiantes con nota entre 80 a 100 Son " + NotaDe80a100);
            Console.WriteLine("La Cantidad De Estudiantes con nota entre 70 < 80 Son " + NotaDe70a79);
            Console.WriteLine(value: "La Cantidad De Estudiantes con nota entre 50 < 70 Son " + NotaDe50a69);
            Console.WriteLine("La Cantidad De Estudiantes con nota menor a 50 Son " + NotaMenorOIgual49);
            Console.ReadKey();

            
            //---------grupo Sui generis------------
            //Christopher Alcantara    17-EIIT-1-049 
            //Dara Reyes               17-EIIN-1-005
            //Vicente Mariño           17-EIIT-1-042
            //Elias Matos              17-EIIT-1-047
            //Elaine Rodriguez         17-EIIT-1-005
        
        }
    }
}  
    

