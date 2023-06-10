using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge.View
{
    public partial class FrmCycle : Form
    {
        public FrmCycle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var businessClass = new Class1();

                // Convert string to DateTime
                DateTime dateCreation;
                if (!DateTime.TryParse(txtDateCycle.Text, out dateCreation))
                {
                    MessageBox.Show("Please enter a valid date in txtDateCycle.");
                    return;
                }

                bool isSuccess = businessClass.AddCycle(txtDesignationCycle.Text, txtLibCycle.Text, dateCreation);

                if (isSuccess)
                {
                    MessageBox.Show("Cycle was added successfully.");
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the cycle.");
                }
            }
            catch (Exception ex)
            {
                // Log the exception or display a message
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}
