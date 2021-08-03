using System;
using System.Collections.Generic;
using ProyectoCSharp.Entidades;
using ProyectoCSharp.Util;
using static System.Console;
using System.Linq;

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

            #region Polimorfismo
                 /* POLIMORFISMO
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

            /*No Seria valido si no ponemos (Alumno), y si lo igualamos al objeto objDummy (nos manda una excepcion)
            alumnoTest=(Alumno)ob;

            var evaluación= new Evaluacion(){Nombre="Evaluación de Mate",Nota=4.5f};
            Printer.WriteTitle("Evaluacion");
            WriteLine($"Evaluacion: {evaluación.Nombre}");
            WriteLine($"Evaluacion: {evaluación.UniqueId}");
            WriteLine($"Evaluacion: {evaluación.Nota}");
            WriteLine($"Evaluacion: {evaluación.GetType()}");

            ob=evaluación;
            Printer.WriteTitle("ObjetoEscuela");
            WriteLine($"Alumno: {ob.Nombre}");
            WriteLine($"Alumno: {ob.UniqueId}");
            WriteLine($"Alumno: {ob.GetType()}");

            /* Con esta declaracion no sale el error al codificar, sale el error en la ejecucion ya que no es posible
            alumnoTest=(Alumno)(ObjetoEscuelaBase)evaluación;*/
            #endregion
           
            var listaObjetos= engine.GetObjetosEscuela();

            var listaILugar= from obj in listaObjetos
                             where obj is ILugar
                             select (ILugar) obj;

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
