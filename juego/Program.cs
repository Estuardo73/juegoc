using System;

namespace juego
{
    class Program
    {
        static void Main(string[] args)
        {
            bool acierto = false ;

            Random numero = new Random();
            int numeroa = numero.Next(0, 100);
            Console.WriteLine("el numero es " + numeroa);

            int numero1 = 0;

            while (!acierto)
            {
                                

                Console.WriteLine("Ingresa numero entre 0 y 100: ");
                try
                {
                    numero1 = int.Parse(Console.ReadLine());
                    
                }
                
                
                catch (Exception ex) when (ex.GetType()!=typeof(FormatException))
                {
                    Console.WriteLine("no has introducico un valor numerico valido entre 0 y 100");
                    Console.WriteLine(ex.Message);
                    numero1 = 0;
                }                

                catch (FormatException ex)
                {
                    Console.WriteLine("has introducido texto, no es valido");
                    numero1 = 0;
                } 
                

                if (numero1 > numeroa) Console.WriteLine("el numero es mayor");
                if (numero1 < numeroa) Console.WriteLine("El numero es menor");                        

                if (numero1 == numeroa)
                {
                    acierto = true;
                    Console.WriteLine("Acertaste");
                }
                  
                else acierto = false;

            }
            Console.WriteLine("A partir de aca seguiria....");
        }
    }
}
