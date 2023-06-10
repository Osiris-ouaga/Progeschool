namespace Bridge.View
{
    partial class FrmConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguration));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnConfigurationPedagogy = new Button();
            btnApplicationConfig = new Button();
            configurationStaticPageuc1 = new UserController.ConfigurationStaticPageUC();
            configurationApplicationuc1 = new UserController.ConfigurationApplicationUC();
            configurationPedagogyuc1 = new UserController.ConfigurationPedagogyUC();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 116, 216);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnConfigurationPedagogy);
            panel1.Controls.Add(btnApplicationConfig);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 607);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(2, 170, 245);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 416);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(200, 189);
            button2.TabIndex = 8;
            button2.Text = "Gestion Electronique";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 278);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(200, 134);
            button1.TabIndex = 7;
            button1.Text = "Comptabilité ";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnConfigurationPedagogy
            // 
            btnConfigurationPedagogy.BackColor = Color.FromArgb(2, 170, 245);
            btnConfigurationPedagogy.FlatAppearance.BorderSize = 0;
            btnConfigurationPedagogy.FlatStyle = FlatStyle.Flat;
            btnConfigurationPedagogy.ForeColor = Color.White;
            btnConfigurationPedagogy.Image = (Image)resources.GetObject("btnConfigurationPedagogy.Image");
            btnConfigurationPedagogy.Location = new Point(0, 140);
            btnConfigurationPedagogy.Margin = new Padding(3, 2, 3, 2);
            btnConfigurationPedagogy.Name = "btnConfigurationPedagogy";
            btnConfigurationPedagogy.Size = new Size(200, 134);
            btnConfigurationPedagogy.TabIndex = 6;
            btnConfigurationPedagogy.Text = "Configuration pédagogie";
            btnConfigurationPedagogy.TextAlign = ContentAlignment.BottomCenter;
            btnConfigurationPedagogy.UseVisualStyleBackColor = false;
            btnConfigurationPedagogy.Click += btnConfigurationPedagogy_Click;
            // 
            // btnApplicationConfig
            // 
            btnApplicationConfig.BackColor = Color.Transparent;
            btnApplicationConfig.FlatAppearance.BorderSize = 0;
            btnApplicationConfig.FlatStyle = FlatStyle.Flat;
            btnApplicationConfig.ForeColor = Color.White;
            btnApplicationConfig.Image = (Image)resources.GetObject("btnApplicationConfig.Image");
            btnApplicationConfig.Location = new Point(0, 2);
            btnApplicationConfig.Margin = new Padding(3, 2, 3, 2);
            btnApplicationConfig.Name = "btnApplicationConfig";
            btnApplicationConfig.Size = new Size(200, 134);
            btnApplicationConfig.TabIndex = 3;
            btnApplicationConfig.Text = "Configuration application";
            btnApplicationConfig.TextAlign = ContentAlignment.BottomCenter;
            btnApplicationConfig.UseVisualStyleBackColor = false;
            btnApplicationConfig.Click += btnApplicationConfig_Click;
            // 
            // configurationStaticPageuc1
            // 
            configurationStaticPageuc1.BackColor = Color.White;
            configurationStaticPageuc1.Location = new Point(206, 0);
            configurationStaticPageuc1.Name = "configurationStaticPageuc1";
            configurationStaticPageuc1.Size = new Size(828, 607);
            configurationStaticPageuc1.TabIndex = 1;
            // 
            // configurationApplicationuc1
            // 
            configurationApplicationuc1.BackColor = Color.White;
            configurationApplicationuc1.Dock = DockStyle.Fill;
            configurationApplicationuc1.Location = new Point(200, 0);
            configurationApplicationuc1.Name = "configurationApplicationuc1";
            configurationApplicationuc1.Size = new Size(834, 607);
            configurationApplicationuc1.TabIndex = 2;
            configurationApplicationuc1.Load += configurationApplicationuc1_Load;
            // 
            // configurationPedagogyuc1
            // 
            configurationPedagogyuc1.BackColor = Color.White;
            configurationPedagogyuc1.Dock = DockStyle.Fill;
            configurationPedagogyuc1.Location = new Point(200, 0);
            configurationPedagogyuc1.Name = "configurationPedagogyuc1";
            configurationPedagogyuc1.Size = new Size(834, 607);
            configurationPedagogyuc1.TabIndex = 3;
            // 
            // FrmConfiguration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1034, 607);
            Controls.Add(configurationPedagogyuc1);
            Controls.Add(configurationApplicationuc1);
            Controls.Add(configurationStaticPageuc1);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "FrmConfiguration";
            Text = "FrmConfiguration";
            Load += FrmConfiguration_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnApplicationConfig;
        private Button button2;
        private Button button1;
        private Button btnConfigurationPedagogy;
        private UserController.ConfigurationStaticPageUC configurationStaticPageuc1;
        private UserController.ConfigurationApplicationUC configurationApplicationuc1;
        private UserController.ConfigurationPedagogyUC configurationPedagogyuc1;
    }
}