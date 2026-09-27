using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form6 : Form
    {
        string name, lang;
        int age, marks;
        public Form6(string name,int age,string lang)
        {
            InitializeComponent();
            this.name = name;
            this.age = age;
            this.lang = lang;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                if (radioButton1.Checked == true)
                {
                    marks += 5;
                }
                else
                {


                    marks -= 1;

                }
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
            }
            if (radioButton5.Checked || radioButton6.Checked || radioButton7.Checked || radioButton8.Checked)
            {
                if (radioButton8.Checked == true)
                {
                    marks += 5;
                }
                else
                {

                    marks -= 1;

                }
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;
                radioButton7.Enabled = false;
                radioButton8.Enabled = false;
            }
            if (radioButton9.Checked || radioButton10.Checked || radioButton11.Checked || radioButton12.Checked)
            {
                if (radioButton10.Checked == true)
                {
                    marks += 5;
                }
                else
                {

                    marks -= 1;

                }
                radioButton9.Enabled = false;
                radioButton10.Enabled = false;
                radioButton11.Enabled = false;
                radioButton12.Enabled = false;
            }
            if (radioButton13.Checked || radioButton14.Checked || radioButton15.Checked || radioButton16.Checked)
            {
                if (radioButton13.Checked == true)
                {
                    marks += 5;
                }
                else
                {
                    marks -= 1;

                }
                radioButton13.Enabled = false;
                radioButton14.Enabled = false;
                radioButton15.Enabled = false;
                radioButton16.Enabled = false;
            }
            if (radioButton17.Checked || radioButton18.Checked || radioButton19.Checked || radioButton20.Checked)
            {
                if (radioButton19.Checked == true)
                {
                    marks += 5;
                }
                else
                {
                    marks = -1;
                }
                radioButton17.Enabled = false;
                radioButton18.Enabled = false;
                radioButton19.Enabled = false;
                radioButton20.Enabled = false;
            }

            Form3 f3 = new Form3(name, age, lang, marks);
            //  MessageBox.Show($"{name}");
            this.Hide();
            f3.ShowDialog();

        }
    }
}
