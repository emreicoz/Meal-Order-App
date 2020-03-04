using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(textBox3.Text);
            listBox5.Items.Add(listBox1.Text);
            
            foreach(Control kontrol in this.groupBox1.Controls)
            {

                if(kontrol is CheckBox)
                {
                    if(((CheckBox)kontrol).Checked == true){

                        listBox6.Items.Add(((CheckBox)kontrol).Text.ToString());

                        }
                }
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;

            foreach (Control kontrol in this.groupBox1.Controls)
            {

                if (kontrol is CheckBox)
                {

                    CheckBox checkBox = (CheckBox)kontrol;
                    checkBox.Checked = false;

                }
            }


        }
    }
}
