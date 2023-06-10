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
    public partial class FrmConfiguration : Form
    {
        public FrmConfiguration()
        {
            InitializeComponent();
        }

        private void ajouterUneConditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créer une instance de ConfigurationsForm
            FrmAddCondition conditionForm = new FrmAddCondition();

            // Afficher ConfigurationsForm
            conditionForm.ShowDialog();
        }

        private void btnApplicationConfig_Click(object sender, EventArgs e)
        {
            configurationStaticPageuc1.Hide();
            configurationPedagogyuc1.Hide();
            configurationApplicationuc1.Show();
        }

        private void FrmConfiguration_Load(object sender, EventArgs e)
        {
            configurationApplicationuc1.Hide();
            configurationPedagogyuc1.Hide();
        }

        private void configurationApplicationuc1_Load(object sender, EventArgs e)
        {

        }

        private void btnConfigurationPedagogy_Click(object sender, EventArgs e)
        {
            configurationStaticPageuc1.Hide();
            configurationPedagogyuc1.Show();
            configurationApplicationuc1.Hide();
        }
    }
}
