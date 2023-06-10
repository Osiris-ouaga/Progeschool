using Bridge.View;
using Business;

namespace Bridge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scaffolding.Models.Admission newAdmission = new Scaffolding.Models.Admission
            {
                // Id = 1, // Vous pouvez avoir besoin de générer cet ID de manière unique
                Niveaux = "SomeValue",
                Branches = "AnotherValue",
                Progression = 70.5,
                Rachat = 15.2,
                Redouble = 5.0,
                Exclus = 9.3,
                DateCreation = DateTime.Now
            };

            Business.Class1 businessClass = new Business.Class1();
            businessClass.AddAdmission(newAdmission);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Créer une instance de ConfigurationsForm
            FrmConfiguration configurationsForm = new FrmConfiguration();

            // Afficher ConfigurationsForm
            configurationsForm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}