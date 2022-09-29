namespace PhysicsHomework
{
    public partial class Task5 : Form
    {
        private Image img;
        public Task5()
        {
            InitializeComponent();
            img = Image.FromFile("5.bmp");
        }

        void Solve()
        {
            try
            {
                if ("".Equals(aX.Text) || "".Equals(aY.Text) || "".Equals(aZ.Text) || "".Equals(rX.Text) || "".Equals(rY.Text) || "".Equals(rZ.Text))
                {
                    eLabel.Text = "";
                    return;
                }
                double ax = Double.Parse(aX.Text);
                double ay = Double.Parse(aY.Text);
                double az = Double.Parse(aZ.Text);

                double rx = Double.Parse(rX.Text);
                double ry = Double.Parse(rY.Text);
                double rz = Double.Parse(rZ.Text);

                eLabel.Text = "E = { " + (-ax) + " ; " + (-ay) + " ; " + (-az) + " }";


            }
            catch (Exception ex)
            {
                eLabel.Text = "В одном из полей допущена ошибка";
            }
        }

        private void aX_TextChanged(object sender, EventArgs e)
        {
            Solve();
        }

        private void aY_TextChanged(object sender, EventArgs e)
        {
            Solve();
        }

        private void aZ_TextChanged(object sender, EventArgs e)
        {
            Solve();
        }

        private void rX_TextChanged(object sender, EventArgs e)
        {
            Solve();
        }

        private void rY_TextChanged(object sender, EventArgs e)
        {
            Solve();
        }

        private void rZ_TextChanged(object sender, EventArgs e)
        {
            Solve();
        }

        private void picturePanel_Paint(object sender, PaintEventArgs e)
        {
            
            picturePanel.BackgroundImage = img;
        }
    }
}