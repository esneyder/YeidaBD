using DemoYeidaBD.Logica;
using DemoYeidaBD.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoYeidaBD
{
    class Program
    {
        

        static void Main(string[] args)
        {

            FormPersona fr = new FormPersona();
            fr.ShowDialog();

            /*
            
            Persona p = new Persona();
            p.Id = 2;
            p.Nombre = "Mi primera actualizacion";
            p.Apellido = "Update 1";
            p.Apodo = "Hola update";
            LogicaNegocio logica = new LogicaNegocio();
           
            if (logica.EliminarPersona(5))//acpa era el metodo update
            {
                Console.WriteLine(logica.Mensaje);
                logica.getPesonas();
            }
            Console.ReadLine();
            */
           


            //como se puede ver esta bastante facil trabajar con esta librería.
            //nos vemos en un proxímo vídeo donde aprenderemos a usar los métodos para ejecutar procedimientos almacenados
            //SALUDOS DEV ;)


        }
    }
}
