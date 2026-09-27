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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("C");
            listBox1.Items.Add("Java");
            listBox1.Items.Add("C#");
            listBox1.Items.Add("Python");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name="",lang="";
            int age=0;
            name = textBox1.Text;
            age = Convert.ToInt32(numericUpDown1.Value);
            lang = listBox1.SelectedItem?.ToString() ?? "";
            if (name == "" || lang == "" || age == 0)
            {
                MessageBox.Show("Enter complete detail");
            }
            else if(lang=="C")
            {
                Form2 f2 = new Form2(name, age, lang);
                this.Hide();
                f2.ShowDialog();
            }
            else if (lang == "Python")
            {
                //MessageBox.Show($"{name}");

                Form4 f4 = new Form4(name, age, lang);
                this.Hide();
                f4.ShowDialog();
            }
            else if (lang == "Java")
            {
                Form5 f5 = new Form5(name, age, lang);
                this.Hide();
                f5.ShowDialog();
            }
            else if (lang == "C#")
            {
                Form6 f6 = new Form6(name,age,lang);
                this.Hide();
                f6.ShowDialog();
            }


        }
    }
}
