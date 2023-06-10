namespace Bridge.View
{
    partial class FrmCycle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCycle));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnAddCycle = new Button();
            txtDateCycle = new DateTimePicker();
            label3 = new Label();
            txtLibCycle = new TextBox();
            label2 = new Label();
            txtDesignationCycle = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtIdCyble = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtIdCyble);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(txtDateCycle);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtLibCycle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtDesignationCycle);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 278);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnAddCycle);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 138);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Traitements";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(253, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.ForeColor = Color.White;
            button4.Location = new Point(142, 97);
            button4.Name = "button4";
            button4.Size = new Size(93, 32);
            button4.TabIndex = 3;
            button4.Text = "Actualiser";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(284, 32);
            button3.Name = "button3";
            button3.Size = new Size(93, 47);
            button3.TabIndex = 2;
            button3.Text = "Supprimer";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(142, 32);
            button2.Name = "button2";
            button2.Size = new Size(105, 47);
            button2.TabIndex = 1;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnAddCycle
            // 
            btnAddCycle.FlatStyle = FlatStyle.Flat;
            btnAddCycle.Location = new Point(43, 32);
            btnAddCycle.Name = "btnAddCycle";
            btnAddCycle.Size = new Size(93, 47);
            btnAddCycle.TabIndex = 0;
            btnAddCycle.Text = "Ajouter";
            btnAddCycle.UseVisualStyleBackColor = true;
            btnAddCycle.Click += button1_Click;
            // 
            // txtDateCycle
            // 
            txtDateCycle.Location = new Point(101, 111);
            txtDateCycle.Name = "txtDateCycle";
            txtDateCycle.Size = new Size(194, 23);
            txtDateCycle.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 4;
            label3.Text = "Date création :";
            // 
            // txtLibCycle
            // 
            txtLibCycle.Location = new Point(101, 82);
            txtLibCycle.Name = "txtLibCycle";
            txtLibCycle.Size = new Size(196, 23);
            txtLibCycle.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 85);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Libellé :";
            // 
            // txtDesignationCycle
            // 
            txtDesignationCycle.Location = new Point(101, 53);
            txtDesignationCycle.Name = "txtDesignationCycle";
            txtDesignationCycle.Size = new Size(196, 23);
            txtDesignationCycle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 56);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Désignation :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 23);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Identifiant :";
            // 
            // txtIdCyble
            // 
            txtIdCyble.Location = new Point(101, 24);
            txtIdCyble.Name = "txtIdCyble";
            txtIdCyble.Size = new Size(196, 23);
            txtIdCyble.TabIndex = 8;
            // 
            // FrmCycle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(380, 278);
            Controls.Add(panel1);
            Name = "FrmCycle";
            Text = "FrmCycle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtLibCycle;
        private Label label2;
        private TextBox txtDesignationCycle;
        private Label label1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnAddCycle;
        private DateTimePicker txtDateCycle;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txtIdCyble;
    }
}