namespace LovingAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {            
            Random x = new Random();

            Point pt = new Point(
                int.Parse(x.Next(400).ToString()),
                int.Parse(x.Next(250).ToString())
                );
            noBtn.Location = pt;
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are Lovely!","Bravo");
        }
    }
}