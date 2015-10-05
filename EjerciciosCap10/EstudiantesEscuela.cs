using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCap10
{
    class EstudiantesEscuela
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int Curso { get; set; }

        public EstudiantesEscuela(string n, string a, int e, int c)
        {
            this.Nombre = n;
            this.Apellido = a;
            this.Edad = e;
            this.Curso = c;
        }

        public EstudiantesEscuela() { }
    }
   
}
