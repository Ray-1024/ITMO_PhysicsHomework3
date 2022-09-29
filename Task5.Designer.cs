namespace PhysicsHomework
{
    partial class Task5
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picturePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aX = new System.Windows.Forms.TextBox();
            this.aY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aZ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rZ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.eLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // picturePanel
            // 
            this.picturePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePanel.Location = new System.Drawing.Point(10, 9);
            this.picturePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(263, 226);
            this.picturePanel.TabIndex = 0;
            this.picturePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.picturePanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Найти напряженность электрического поля потенциал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "которого имеет вид φ = ar, где a - постоянный вектор,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "r - радиус-вектор точки поля.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "a:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "X:";
            // 
            // aX
            // 
            this.aX.Location = new System.Drawing.Point(346, 79);
            this.aX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aX.Name = "aX";
            this.aX.Size = new System.Drawing.Size(110, 23);
            this.aX.TabIndex = 6;
            this.aX.TextChanged += new System.EventHandler(this.aX_TextChanged);
            // 
            // aY
            // 
            this.aY.Location = new System.Drawing.Point(346, 104);
            this.aY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aY.Name = "aY";
            this.aY.Size = new System.Drawing.Size(110, 23);
            this.aY.TabIndex = 8;
            this.aY.TextChanged += new System.EventHandler(this.aY_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y:";
            // 
            // aZ
            // 
            this.aZ.Location = new System.Drawing.Point(346, 128);
            this.aZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aZ.Name = "aZ";
            this.aZ.Size = new System.Drawing.Size(110, 23);
            this.aZ.TabIndex = 10;
            this.aZ.TextChanged += new System.EventHandler(this.aZ_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Z:";
            // 
            // rZ
            // 
            this.rZ.Location = new System.Drawing.Point(530, 125);
            this.rZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rZ.Name = "rZ";
            this.rZ.Size = new System.Drawing.Size(110, 23);
            this.rZ.TabIndex = 17;
            this.rZ.TextChanged += new System.EventHandler(this.rZ_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Z:";
            // 
            // rY
            // 
            this.rY.Location = new System.Drawing.Point(530, 100);
            this.rY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rY.Name = "rY";
            this.rY.Size = new System.Drawing.Size(110, 23);
            this.rY.TabIndex = 15;
            this.rY.TextChanged += new System.EventHandler(this.rY_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(507, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Y:";
            // 
            // rX
            // 
            this.rX.Location = new System.Drawing.Point(530, 76);
            this.rX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rX.Name = "rX";
            this.rX.Size = new System.Drawing.Size(110, 23);
            this.rX.TabIndex = 13;
            this.rX.TextChanged += new System.EventHandler(this.rX_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "X:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(484, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "r:";
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Location = new System.Drawing.Point(300, 184);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(0, 15);
            this.eLabel.TabIndex = 18;
            // 
            // Homework3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 250);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.rZ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rY);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.aZ);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Homework3";
            this.Text = "Homework 3(Task 5)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel picturePanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox aX;
        private TextBox aY;
        private Label label6;
        private TextBox aZ;
        private Label label7;
        private TextBox rZ;
        private Label label8;
        private TextBox rY;
        private Label label9;
        private TextBox rX;
        private Label label10;
        private Label label11;
        private Label eLabel;
    }
}