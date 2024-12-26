using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth;

namespace spyware_dll
{
    public partial class Form1 : Form
    {

        public static api KeyAuthApp = new api(
     name: "Dshahidx000's Application", // Application Name
     ownerid: "Dy5PDHs66n", // Owner ID
      secret: "d958c73a069f782f5cf127974c7f89291e60679d0ab06c722356886d25dc9399", // Application Secret
     version: "1.0" // 


 );
        public Form1()
        {
            InitializeComponent();
            KeyAuthApp.init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(User.Text, Pass.Text);
            if (KeyAuthApp.response.success)
            {
                timer1.Start();
            }
            else
            {
                Stt.Text = KeyAuthApp.response.message;
            }

        }      
                

        private void stt_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.guna2ProgressBar1.Increment(10);
            if (guna2ProgressBar1.Value >= guna2ProgressBar1.Maximum)
            {
                Form2 VIDEO = new Form2();
                VIDEO.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
