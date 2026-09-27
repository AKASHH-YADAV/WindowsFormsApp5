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
    public partial class Form3 : Form
    {
        string name, lang;
        int age, marks;
      
        public Form3(string name, int age, string lang, int marks)
        {
            this.name = name;
            this.age = age;
            this.lang = lang;
            this.marks = marks;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = $"NAME: {name}";
            label2.Text = $"AGE: {age}";
            label3.Text = $"LANGUAGE:  {lang}";
            label4.Text = $"MARKS: {marks}";

        }
    }
}
