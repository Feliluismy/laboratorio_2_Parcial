namespace PARCIAL1
{
    public partial class Felipe_Mendiondo : Form
    {
        public Felipe_Mendiondo()
        {
            InitializeComponent();

            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstPacientes.SelectedItems.Count == 0 && lstMedicos.SelectedItems.Count == 0)
            {
                notifyIcon1.Text = "hola";
            }
        }
    }
}
