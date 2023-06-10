namespace Bridge.View
{
    partial class FrmAddCondition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCondition));
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label6 = new Label();
            txtExclusion = new TextBox();
            label5 = new Label();
            txtRedouble = new TextBox();
            label4 = new Label();
            txtRachat = new TextBox();
            label3 = new Label();
            txtBranche = new TextBox();
            label2 = new Label();
            txtProgression = new TextBox();
            label1 = new Label();
            txtNiveau = new TextBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 279);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ajouter une condition d'admission";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(337, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(117, 110);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(21, 24);
            button1.Name = "button1";
            button1.Size = new Size(75, 66);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtExclusion);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtRedouble);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtRachat);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtBranche);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtProgression);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtNiveau);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(325, 241);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 211);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Exclusion";
            // 
            // txtExclusion
            // 
            txtExclusion.Location = new Point(99, 208);
            txtExclusion.Name = "txtExclusion";
            txtExclusion.Size = new Size(183, 23);
            txtExclusion.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 172);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Redouble";
            // 
            // txtRedouble
            // 
            txtRedouble.Location = new Point(99, 169);
            txtRedouble.Name = "txtRedouble";
            txtRedouble.Size = new Size(183, 23);
            txtRedouble.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 134);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Rachat";
            // 
            // txtRachat
            // 
            txtRachat.Location = new Point(99, 131);
            txtRachat.Name = "txtRachat";
            txtRachat.Size = new Size(183, 23);
            txtRachat.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 56);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Branche";
            // 
            // txtBranche
            // 
            txtBranche.Location = new Point(99, 53);
            txtBranche.Name = "txtBranche";
            txtBranche.Size = new Size(183, 23);
            txtBranche.TabIndex = 5;
            txtBranche.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 95);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Progression";
            // 
            // txtProgression
            // 
            txtProgression.Location = new Point(99, 92);
            txtProgression.Name = "txtProgression";
            txtProgression.Size = new Size(183, 23);
            txtProgression.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 24);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Niveau";
            // 
            // txtNiveau
            // 
            txtNiveau.Location = new Point(99, 21);
            txtNiveau.Name = "txtNiveau";
            txtNiveau.Size = new Size(183, 23);
            txtNiveau.TabIndex = 1;
            // 
            // FrmAddCondition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(481, 297);
            Controls.Add(groupBox1);
            Name = "FrmAddCondition";
            Text = "FrmAddCondition";
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtRachat;
        private Label label3;
        private TextBox txtBranche;
        private Label label2;
        private TextBox txtProgression;
        private Label label1;
        private TextBox txtNiveau;
        private Label label6;
        private TextBox txtExclusion;
        private Label label5;
        private TextBox txtRedouble;
        private GroupBox groupBox3;
        private Button button1;
    }
}