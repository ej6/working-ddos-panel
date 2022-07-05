using System.Diagnostics;
using System.Net;


namespace hope
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //back button sends you back to form 1 and hides this
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        //makes panel moveable
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Point mouseLocation;

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

        //connects to vpn
        private void button1_Click(object sender, EventArgs e)
        {
            string vpn = textBox1.Text;
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\OpenVPN\bin\openvpn-gui.exe";
                startInfo.Arguments = $"--connect {vpn}";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show("connecting");
            }
        }

        //textbox for the vpn
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //disconnects the vpn
        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "taskkill",
                Arguments = $"/f /im openvpn.exe",
                CreateNoWindow = true,
                UseShellExecute = false
            }).WaitForExit();
            MessageBox.Show("You've disconnected from the server");
        }

        //an api that shows your ip
        private void button4_Click(object sender, EventArgs e)
        {
            string myip = new WebClient() { Proxy = null }.DownloadString($"https://api.ipify.org/?format=plain");
            MessageBox.Show(myip);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
