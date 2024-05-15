using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL1
{
    abstract class Persona
    {
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.apellido = apellido;
            this.barrioRecidencia = "";
            this.nacimiento = nacimiento;
            this.nombre = nombre;
        }
        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia)
        {
            this.apellido = apellido;
            this.barrioRecidencia = barrioRecidencia;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
        }

        public int Edad { get
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }
        public string NombreCompleto
        {
            get
            {
                return $"{apellido} {nombre}"; 
            }
        }
        public string ToString()
        {
            return NombreCompleto;
        }
        internal abstract string FichaExtra();
        public string FichaPersonal(Persona P)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre Completo: {P.NombreCompleto}");
            sb.AppendLine($"Edad: {Edad}");
            sb.AppendLine($"Barrio: {P.barrioRecidencia}");
            sb.AppendLine($"Fecha de Nacimiento: {P.nacimiento}");

            return sb.ToString();
        }
    }
}
