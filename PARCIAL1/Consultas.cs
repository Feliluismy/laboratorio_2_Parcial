using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL1
{
    internal class Consulta
    {
        private DateTime fecha;
        private Paciente Paciente;

        public DateTime Fecha { get { return fecha; } }
        public Paciente paciente { get; }

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }
        public override string ToString()
        {
            return $"{Fecha} se atendio a {Paciente.ToString()}";
        }
    }
}
