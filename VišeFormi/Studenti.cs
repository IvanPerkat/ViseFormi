using System.Windows.Forms;

namespace VišeFormi
{
    public partial class Studenti : Form
    {
        public Studenti()
        {
            InitializeComponent();
        }

        private void buttonObrisiStudenta_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            UnosNovogStudenta student = new UnosNovogStudenta();
            DialogResult rez = student.ShowDialog();

            if (rez == DialogResult.OK)
            {
                listBox1.Items.Add(student.Student1.ToString());
            }
        }

        private void buttonObrisiSve_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
