using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap10_And_Cap12.Clases
{
    //Diseño de una 
    public class Estudiante
    {
        private string NombreEstudiante;
        private string ApellidoEstudiante;
        private string Curso;
        public string Asignatura;
        private int CantidadAsignaturas;

        public Estudiante(string _NombreEstudiante, string _ApellidoEstudiante, string _Curso, string _Asignatura, int _CantidadAsignaturas)
        {
            NombreEstudiante = _NombreEstudiante;
            ApellidoEstudiante = _ApellidoEstudiante;
            Curso = _Curso;
            Asignatura = _Asignatura;
            CantidadAsignaturas = _CantidadAsignaturas;
        }
        
        //Setters
        public void SetNombreEstudiante(string _NombreEstudiante)
        {
            NombreEstudiante = _NombreEstudiante;
        }

        public void SetApellidoEstudiante(string _ApellidoEstudiante)
        {
            ApellidoEstudiante = _ApellidoEstudiante;
        }

        public void SetCurso(string _Curso)
        {
            Curso = _Curso;
        }

        public void SetAsignatura(string _Asignatura)
        {
            Asignatura = _Asignatura;
        }

        public void SetCantidadAsignaturas(int _CantidadAsignaturas)
        {
            CantidadAsignaturas = _CantidadAsignaturas;
        }
        
        //Getters
        public string GetNombreEstudiante()
        {
            return NombreEstudiante;
        }

        public string GetApellidoEstudiante()
        {
            return ApellidoEstudiante;
        }

        public string GetCurso()
        {
            return Curso;
        }

        public string GetAsignatura()
        {
            return Asignatura;
        }

        public int GetCantidadAsignaturas()
        {
            return CantidadAsignaturas;
        }
    }
}
