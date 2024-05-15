using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL1
{
    internal class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esRecidente)
            : base(nombre, apellido, nacimiento)
        {
            this.esResidente = esRecidente;
            this.consultas = new List<Consulta>();
        }
        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"¿Finalizo Residencia?: {esResidente}");
            sb.AppendLine($"{Environment.NewLine}ATENCIONES:");
            foreach (Consulta atencion in consultas)
            {
                sb.AppendLine(atencion.ToString());
            }
            return sb.ToString();
        }
        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta consulta = new Consulta(DateTime.Now, paciente);
            doctor.consultas.Add(consulta);

            return consulta;
        }
    }
}
