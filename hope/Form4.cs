using System.Net;

namespace hope
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //back button
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            Form3 frm3 = new Form3();
            frm3.Close();
            frm1.Show();
            this.Hide();
        }

        //makes panel moveable
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Point mouseLocation;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        //sends a request to an api to get a password and copies it to clipboard
        private void button1_Click(object sender, EventArgs e)
        {
            string PW = textBox1.Text;
            {
                string Pass = new WebClient() { Proxy = null }.DownloadString($"https://makemeapassword.ligos.net/api/v1/alphanumeric/plain?l={PW}");
                MessageBox.Show($"{Pass} copied to clipboard");
                Clipboard.SetText(Pass);
            }
        }

        //textbox for the password length
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
