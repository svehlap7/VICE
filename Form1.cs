using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VICE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pocet = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ColorDialog barva = new ColorDialog();
        }
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (pocet < 10)
            {

                Button button1 = new Button(); 
                button1.DialogResult = DialogResult.OK;
                button1.Location = new Point(130, 189);
                button1.Size = new Size(75, 23);
                button1.Text = "ULOZIT";


                Button button2 = new Button();
                button2.DialogResult = DialogResult.Cancel;
                button2.Location = new Point(130, 130);
                button2.Size = new Size(75, 23);
                button2.Text = "ZRUSIT";


                TextBox textBox1 = new TextBox();
                textBox1.Clear();

                this.AcceptButton = button1;
                textBox1.Location = new Point(49, 40);
                textBox1.Size = new Size(188, 22);


                Form form2 = new Form();
                form2.Location = new Point(300, 600);
                form2.Controls.Add(textBox1);
                form2.Controls.Add(button2);
                form2.Controls.Add(button1);
                form2.Text = "MOZNOSTI";

                if (form2.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Add(textBox1.Text);
                    pocet++;
                }

            }
        }

    }
}
