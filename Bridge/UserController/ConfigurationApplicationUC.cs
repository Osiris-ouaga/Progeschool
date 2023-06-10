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
    public partial class ConfigurationApplicationUC : UserControl
    {
        public ConfigurationApplicationUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConfigurationSchool frmConfigurationSchool = new FrmConfigurationSchool();
            frmConfigurationSchool.ShowDialog();
        }
    }
}
