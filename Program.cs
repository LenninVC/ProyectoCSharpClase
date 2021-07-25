using System;
using System.Collections.Generic;
using ProyectoCSharp.Entidades;
using ProyectoCSharp.Util;
using static System.Console;

namespace ProyectoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            //Printer.Beep(10000, cantidad:10);
            ImpimirCursosEscuela(engine.Escuela);

            Printer.DrawLine(50);
            Printer.DrawLine(50);
            Printer.DrawLine(50);
            Printer.WriteTitle("Pruebas de Polimorfismo");

            var alumnoTest= new Alumno{Nombre="Claire UnderWood"};
            Printer.WriteTitle("Alumno");
            WriteLine($"Alumno: {alumnoTest.Nombre}");
            WriteLine($"Alumno: {alumnoTest.UniqueId}");
            WriteLine($"Alumno: {alumnoTest.GetType()}");

            ObjetoEscuelaBase ob=alumnoTest;
            Printer.WriteTitle("ObjetoEscuela");
            WriteLine($"Alumno: {ob.Nombre}");
            WriteLine($"Alumno: {ob.UniqueId}");
            WriteLine($"Alumno: {ob.GetType()}");

            var objDummy=new ObjetoEscuelaBase(){Nombre="Frank UnderWood"};
            Printer.WriteTitle("Creando el ObjetoEscuelaBase");
            WriteLine($"Alumno: {objDummy.Nombre}");
            WriteLine($"Alumno: {objDummy.UniqueId}");
            WriteLine($"Alumno: {objDummy.GetType()}");

            //No Seria valido si no ponemos (Alumno), y si lo igualamos al objeto objDummy (nos manda una excepcion)
            alumnoTest=(Alumno)ob;

        }

        private static void ImpimirCursosEscuela(Escuela escuela)
        {
            
            Printer.WriteTitle("Cursos de la Escuela");
            
            
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
                }
            }
        }
    }
}
