using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsHomework
{
    public partial class Task2 : Form
    {
        private Image img;
        public Task2()
        {
            InitializeComponent();
            img = Image.FromFile("2.bmp");
        }

        void Solve()
        {
            try
            {
                if ("".Equals(A.Text) || "".Equals(X.Text) || "".Equals(Y.Text))
                {
                    aeLabel.Text = "";
                    beLabel.Text = "";
                    return;
                }
                double a = Double.Parse(A.Text);
                double x = Double.Parse(X.Text);
                double y = Double.Parse(Y.Text);

                aeLabel.Text = "E = { " + (-2 * a * x) + " ; " + (2 * a * y) + " }";
                beLabel.Text = "E = { " + (-a * y) + " ; " + (-a * x) + " }";


            }
            catch (Exception ex)
            {
                aeLabel.Text = "В одном из полей допущена ошибка";
                beLabel.Text = "В одном из полей допущена ошибка";
            }
        }

        private void picturePanel_Paint(object sender, PaintEventArgs e)
        {
            picturePanel.BackgroundImage = img;
        }

        private void A_TextChanged(object sender, EventArgs e)
        {
            Solve();
        }

        private void X_TextChanged(object sender, EventArgs e)
        {
            Solve();
        }

        private void Y_TextChanged(object sender, EventArgs e)
        {
            Solve();
        }
    }
}
