using Biblioteca;

namespace MoralesDelfino.Malena._323
{
    public partial class Malena : Form
    {
        public Malena()
        {
            InitializeComponent();
        }

        private void Malena_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedItems.Count <= 0 || lstPacientes.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PersonalMedico doctor = (PersonalMedico)lstMedicos.SelectedItem;
                Paciente paciente = (Paciente)lstPacientes.SelectedItem;
                Consulta nuevaconsulta = doctor + paciente;
                paciente.Diagnostico = "Paciente curado";
                MessageBox.Show(nuevaconsulta.ToString(), "Atención finalizada.", MessageBoxButtons.OK);
            }
            lstPacientes.SelectedItems.Clear();
            lstMedicos.SelectedItems.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedItem is null)
            {
                rtbInfoMedico.Clear();
            }
            else
            {
                rtbInfoMedico.Text = Persona.FichaPersonal((PersonalMedico)lstMedicos.SelectedItem);
            }
        }
    }
}
