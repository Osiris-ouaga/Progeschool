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
    public partial class FrmConfigurationSchool : Form
    {
        public FrmConfigurationSchool()
        {
            InitializeComponent();
        }

        //private void button5_Click(object sender, EventArgs e)
        //{
        //  
        //}

        private void FrmConfigurationSchool_Load(object sender, EventArgs e)
        {

        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Now you can use ofd.FileName to get the chosen file's path
                string filePath = ofd.FileName;
                // Load the image file into your PictureBox called pictureBoxLogo
                pictureBoxLogo.Image = Image.FromFile(filePath);
            }
        }

        private void btnAddCycle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(schoolId.Text);  // assuming schoolId is a TextBox where you input the Id
            string designation = schoolDesignation.Text;
            string adresse = schoolAdresse.Text;
            string lib = schoolLib.Text;
            string email = schoolEmail.Text;
            DateTime dateCreation = DateTime.Parse(schoolDate.Text); // assuming schoolDate contains a valid DateTime string
            string nomFondateur = schoolNomFondateur.Text;
            string prenomFondateur = schoolPrenomFondateur.Text;
            string adresseFondateur = schoolAdresseFondateur.Text;

            // If you have a PictureBox named pictureBoxLogo, you can convert its image to a byte array
            byte[]? logo = null;
            if (pictureBoxLogo.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxLogo.Image.Save(ms, pictureBoxLogo.Image.RawFormat);
                    logo = ms.ToArray();
                }
            }

            var businessClass = new Class1();

            bool isSuccess = businessClass.AddSchoolInfo(
                id, designation, adresse, lib,
                email, dateCreation, nomFondateur,
                prenomFondateur, adresseFondateur, logo);

            if (isSuccess)
            {
                MessageBox.Show("School info was added successfully.");
            }
            else
            {
                MessageBox.Show("An error occurred while adding the school info.");
            }
        }


    }
}
