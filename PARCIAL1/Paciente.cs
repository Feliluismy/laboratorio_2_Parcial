using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL1
{
    internal class Paciente : Persona
    {
        private string diagnostico;
        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioResidencial) 
            : base(nombre, apellido, nacimiento, barrioResidencial)
        {

        }

        public string Diagnostico { get; set; }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine(base.Edad.ToString());

            sb.AppendLine($"cide en barrio: {base.barrioRecidencia}");
            sb.AppendLine(Diagnostico);

            return sb.ToString();
        }

    }
}
