namespace StructEx2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.X.ToString();
            label2.Text = e.Location.Y.ToString();
        }
    }
}
