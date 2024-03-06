using System.Collections;
using System.Diagnostics;

namespace Ejercicio9Array 
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// irodhan -> 06/03/2024
    /// </summary>
    class Program 
    {
        //Atributos
        static string frase = "aaaaa";
        static string fraseModificada = "aaaaa";
        static string[] frasePartida;
        //Arrays
        static char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
        //Listas
        static ArrayList listaFrase=new ArrayList{ };


        /// <summary>
        /// Método principal de la aplicacion
        /// irodhan -> 06/03/2024
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        {
            //Pedimos la frase
            pedirFrase();
            //Modificamos la frase
            modificarFrase();
            //Guardamos la frase en la lista separandola con un espacio
            guardarLista();
        }

        /// <summary>
        /// Metodo que pide la frase al usuario
        /// irodhan -> 06/03/2024
        /// </summary>
        /// <returns></returns>
        static string pedirFrase() 
        {
            //Le pedimos al usuario la frase
            Console.WriteLine("Escribe una frase:");
            frase = Console.ReadLine();
            return frase;
        }

        /// <summary>
        /// Metodo que modifica la frase introducida por el usuario
        /// irodhan -> 06/03/2024
        /// </summary>
        /// <returns></returns>
        static string modificarFrase() 
        {
            //Cambiamos las vocales por *
            fraseModificada = frase;
            for (int i = 0; i < vocales.Length; i++)
            {
                fraseModificada = fraseModificada.Replace(vocales[i], '*');
            }
            Console.WriteLine(fraseModificada);
            return fraseModificada;
        }
        /// <summary>
        /// Metodo que guarda la frase modificada en
        /// </summary>
        static string[] guardarLista()
        {
            string[] trozos= frase.Split(" ");
            listaFrase.AddRange(trozos);
            foreach (string t in listaFrase) 
            { 
                Console.WriteLine(t);
            }
            return trozos;
        }
    }
}
