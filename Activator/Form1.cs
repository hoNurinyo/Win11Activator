namespace Activator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //winactlibs
        public static class win11actlib
        {
            
            public static void win11pro()
            {
                var p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = @"C:\Windows\System32";
                p.StartInfo.Arguments = "/C set productKey=W269N-WFGWX-YVC9B-4J6C9-T83GX";
                p.Start();
            }
            public static void win11ent()
            {
                var p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = @"C:\Windows\System32";
                p.StartInfo.Arguments = "/C set productKey=NPPR9-FWDCX-D2C8J-H872K-2YT43";
                p.Start();
            }
            public static void win11home()
            {
                var p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = @"C:\Windows\System32";
                p.StartInfo.Arguments = "/C set productKey=TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
                p.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            getPage2();
        }

        private void getPage2()
        {
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            button6.Visible = true;
        }
        private void getPage1()
        {
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            button6.Visible = false;
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            getPage1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            win11actlib.win11pro();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            win11actlib.win11ent();
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            win11actlib.win11home();
        }
    }

}
