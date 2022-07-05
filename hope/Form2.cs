using System.Net;
using System.Diagnostics;

//make sure you change all pastebins and put your api key in also pay attention to what everything does
namespace hope
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //just a label for the words
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //login using key from pastebin
        private void Button1_Click(object sender, EventArgs e)
        {
            string whitelist = new WebClient() { Proxy = null }.DownloadString($"https://pastebin.com/raw/hgW5zLjs");
            if (textBox1.Text.Contains(whitelist))
            {
                MessageBox.Show("<3");
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            } else {
                MessageBox.Show("key incorrect");
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        //updater change pastebins make sure to only change the ending numbhers you need the /raw/
        //it checks the version if its true it continues if its false it sends the person to the link set in the pastebin and closes all
        //you need to change the version number in ("1.0".Contains(vers)) and in the pastebin
        private void Form2_Load(object sender, EventArgs e)
        {
            string vers = new WebClient() { Proxy = null }.DownloadString($"https://pastebin.com/raw/wby7nxJv");
            string down = new WebClient() { Proxy = null }.DownloadString($"https://pastebin.com/raw/G2kdLdwh");
            if ("2.5".Contains(vers))
            {
                MessageBox.Show("correct version number");
            }
            else
            {
                Process.Start(new ProcessStartInfo($"{down}") { UseShellExecute = true });
                MessageBox.Show("incorrect version number please download new version");
                Form1 frm1 = new Form1();
                Form3 frm3 = new Form3();
                Form4 frm4 = new Form4();
                frm4.Close();
                frm3.Close();
                frm1.Close();
                this.Close();
            }
        }
    }
}
