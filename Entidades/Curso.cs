using System;
using System.Collections.Generic;

namespace ProyectoCSharp.Entidades
{
    public class Curso:ObjetoEscuelaBase
    {

        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        
    }
}