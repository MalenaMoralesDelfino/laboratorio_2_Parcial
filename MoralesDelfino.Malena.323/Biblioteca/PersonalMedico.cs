using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PersonalMedico:Persona
    {
        private List<Consulta> consultas = new List<Consulta>();
        private bool esRecidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esRecidente):base(nombre, apellido, nacimiento)
        {
            this.esRecidente = esRecidente;
        }
        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("» Datos del médico. «");
            sb.AppendLine($"¿Finalizó la residencia? {this.esRecidente}");
            if (esRecidente)
            {
                sb.Append($"» ATENCIONES:");
                foreach (Consulta c in consultas)
                {
                    sb.AppendLine($"- {c}");
                }
            }
            else
            {
                sb.AppendLine("Aun no tiene consultas.");
            }
            return sb.ToString();
        }
        public static Consulta operator+(PersonalMedico doctor, Paciente paciente)
        {
            Consulta nuevaConsulta = new Consulta(DateTime.Now, paciente);
            doctor.consultas.Add(nuevaConsulta);
            return nuevaConsulta;
        }
    }
}
