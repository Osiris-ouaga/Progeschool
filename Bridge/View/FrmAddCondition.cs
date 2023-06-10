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
    public partial class FrmAddCondition : Form
    {
        public FrmAddCondition()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scaffolding.Models.Admission newAdmission = new Scaffolding.Models.Admission
            {
                // Id = 1, // Vous pouvez avoir besoin de générer cet ID de manière unique
                Niveaux = txtNiveau.Text,
                Branches = txtBranche.Text,
                Progression = double.Parse(txtProgression.Text),
                Rachat = double.Parse(txtRachat.Text),
                Redouble = double.Parse(txtRedouble.Text),
                Exclus = double.Parse(txtExclusion.Text),
                DateCreation = DateTime.Now
            };

            Business.Class1 businessClass = new Business.Class1();
            bool isSuccessful = businessClass.AddAdmission(newAdmission);

            if (isSuccessful)
            {
                MessageBox.Show("Les données ont été ajoutées avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite lors de l'ajout des données", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
