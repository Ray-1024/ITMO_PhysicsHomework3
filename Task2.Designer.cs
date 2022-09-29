namespace PhysicsHomework
{
    partial class Task2
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
            this.Y = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aeLabel = new System.Windows.Forms.Label();
            this.beLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(324, 92);
            this.Y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(110, 23);
            this.Y.TabIndex = 29;
            this.Y.TextChanged += new System.EventHandler(this.Y_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Y:";
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(324, 68);
            this.X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(110, 23);
            this.X.TabIndex = 27;
            this.X.TextChanged += new System.EventHandler(this.X_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "X:";
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(324, 43);
            this.A.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(110, 23);
            this.A.TabIndex = 25;
            this.A.TextChanged += new System.EventHandler(this.A_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "которого зависит от координат x,y по закону:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Определить напряженность электрического поля потенциал";
            // 
            // picturePanel
            // 
            this.picturePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePanel.Location = new System.Drawing.Point(12, 11);
            this.picturePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(263, 226);
            this.picturePanel.TabIndex = 19;
            this.picturePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.picturePanel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "a) φ = a(x^2 - y^2)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "б) φ = axy";
            // 
            // aeLabel
            // 
            this.aeLabel.AutoSize = true;
            this.aeLabel.Location = new System.Drawing.Point(302, 157);
            this.aeLabel.Name = "aeLabel";
            this.aeLabel.Size = new System.Drawing.Size(0, 15);
            this.aeLabel.TabIndex = 32;
            // 
            // beLabel
            // 
            this.beLabel.AutoSize = true;
            this.beLabel.Location = new System.Drawing.Point(302, 209);
            this.beLabel.Name = "beLabel";
            this.beLabel.Size = new System.Drawing.Size(0, 15);
            this.beLabel.TabIndex = 33;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 252);
            this.Controls.Add(this.beLabel);
            this.Controls.Add(this.aeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.X);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturePanel);
            this.Name = "Task2";
            this.Text = "Task2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox Y;
        private Label label7;
        private TextBox X;
        private Label label6;
        private TextBox A;
        private Label label5;
        private Label label2;
        private Label label1;
        private Panel picturePanel;
        private Label label3;
        private Label label4;
        private Label aeLabel;
        private Label beLabel;
    }
}