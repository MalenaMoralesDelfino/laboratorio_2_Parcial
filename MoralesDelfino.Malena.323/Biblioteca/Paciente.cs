using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Paciente:Persona
    {
        public string diagnostico;

        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }
        public Paciente (string nombre,string apellido, DateTime nacimiento, string barrioRecidencia) : base(nombre, apellido, nacimiento, barrioRecidencia)
        {
        }
        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("» Datos del paciente «");
            sb.AppendLine($"Recide en: {this.barrioRecidencia}");
            sb.AppendLine($"{Diagnostico}");
            return sb.ToString();
        }
    }
}
