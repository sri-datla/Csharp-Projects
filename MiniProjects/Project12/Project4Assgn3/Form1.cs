using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4Assgn3
{
    delegate string ReturnMessage();
    public partial class Form1 : Form
    {

                        /*
                         Create a graphical user interface that can be used by a community group
                to enable youths to sign up for different sporting events. Include radio
                buttons with a minimum of five sports. Wire a single event-handler
                method to each of the radio buttons. Program the method to display
                a different message for each different sport. For example, if one of the
                sports is skiing, the message might say, “Bring warm clothes!” Also
                include a PictureBox object on the form to display a different picture based on which sporting event was selected. One approach would
                be to layer multiple picture box objects in the same location. When the
                particular sport is selected, make the associated PictureBox visible.
                You can find free graphics on the Internet to use in your application.
                Hint: One way to associate a file to the PictureBox control is to Import
                an image from the Image property.
                         */
        public Form1()
        {
            InitializeComponent();
        }
        public string ButtonClick1()
        {
            pictureBox1.Visible = true;
            return "You have selected Cricket. So, Please bring your own bat and ball";
        }
        public string ButtonClick2()
        {
            pictureBox2.Visible = true;
            return "You have selected Football. So, please bring your own ball";
        }
        public string ButtonClick3()
        {
            pictureBox3.Visible = true;
            return "You have selected Volleyball. So, Please bring your own ball";
        }
        public string ButtonClick4()
        {
            pictureBox4.Visible = true;
            return "You have selected Skiing. So, Please bring warm clothes";
        }
        public string ButtonClick5()
        {
            pictureBox5.Visible = true;
            return "You have selected hockey. So, Please bring your own hockey bat";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            ReturnMessage message;
            if (radioButton1.Checked == true)
            {
                message = new ReturnMessage(ButtonClick1);
            }
            else if (radioButton2.Checked == true)
            {
                message = new ReturnMessage(ButtonClick2);
            }
            else if (radioButton3.Checked == true)
            {
                message = new ReturnMessage(ButtonClick3);
            }
            else if (radioButton4.Checked == true)
            {
                message = new ReturnMessage(ButtonClick4);
            }
            else
            {
                message = new ReturnMessage(ButtonClick5);
            }
            MessageBox.Show(message());
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
        }
    }
}
