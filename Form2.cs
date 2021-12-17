using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_manadger
{
    public partial class Form2 : Form
    {
        public DialogResult result;
        public string name;
        public Form2(string text, string text2)
        {
            InitializeComponent();
            label1.Text = text;
            textBox1.Text = text2;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            if (textBox1.Text != "")
            {
                name = textBox1.Text;
                this.Close();
            }
            else
                MessageBox.Show("Ошибка", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            this.Close();
        }
    }
}
