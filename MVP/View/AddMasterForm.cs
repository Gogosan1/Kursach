using System;
using System.Windows.Forms;

namespace ModelMainForm
{
    public partial class AddMasterForm : Form
    {
       
        public AddMasterForm()
        {
            InitializeComponent();
        }


        private void addServiceToMaster_Click(object sender, EventArgs e)
        {
            try
            {
                time = Convert.ToInt32(textBox1.Text);
                if (time <= 0)
                    MessageBox.Show("Время не может быть меньше нуля");
                else
                    this.Close();
            }
            catch(FormatException)
            {
                MessageBox.Show("введите число!");
            }
        }

        private int time;
        public int GetTime() => time;

    }
}
