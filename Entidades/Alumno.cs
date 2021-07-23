using System;
using System.Collections.Generic;

namespace ProyectoCSharp.Entidades
{
    public class Alumno:ObjetoEscuelaBase
    {
        public List<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();

    }
}