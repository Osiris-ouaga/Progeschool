using Bridge.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge.UserController
{
    public partial class ConfigurationPedagogyUC : UserControl
    {
        public ConfigurationPedagogyUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCycle frmCycle = new FrmCycle();
            frmCycle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmNiveau frmNiveau = new FrmNiveau();
            frmNiveau.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBranche frmBranche = new FrmBranche();
            frmBranche.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAdmission frmAdmission = new FrmAdmission();
            frmAdmission.ShowDialog();
        }
    }
}
