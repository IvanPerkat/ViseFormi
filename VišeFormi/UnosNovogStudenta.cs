using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VišeFormi
{
    public partial class UnosNovogStudenta : Form
    {
        public UnosNovogStudenta()
        {
            InitializeComponent();

            comboBoxSmjer.Items.Add("Programer");
            comboBoxSmjer.Items.Add("Sistem administrator");
            comboBoxSmjer.Items.Add("Mrežni administrator");
        }

        public Student Student1 { get; set; }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSmjer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            Student1 = new Student(
                textBoxIme.Text,
                textBoxPrezime.Text,
                textBoxBrojIndeks.Text,
                comboBoxSmjer.SelectedItem.ToString(),
                dateTimePickerDatumrodjenja.Value
            );

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
