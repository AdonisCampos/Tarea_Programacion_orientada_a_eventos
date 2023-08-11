using Convertir_Grados.Resources;

namespace Convertir_Grados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cerraraplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Form activeForm = null;

        private void openChildForm(Form childrenForm)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childrenForm;
            childrenForm.TopLevel = false;
            childrenForm.FormBorderStyle = FormBorderStyle.None;
            childrenForm.Dock = DockStyle.Fill;
            contentpanel.Controls.Add(childrenForm);
            contentpanel.Tag = childrenForm;
            childrenForm.BringToFront();
            childrenForm.Show();
        }

        private void CelsiusaFathrenheitboton_Click(object sender, EventArgs e)
        {
            openChildForm(new celsiusFahrenheitForm());
        }

        private void farenheitacelsiusboton_Click(object sender, EventArgs e)
        {
            openChildForm(new fahrenheitToCelsiusForm());
        }
    }
}