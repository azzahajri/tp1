using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_tp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Remplir votre champ svp "
                          + "!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
            else
                    {
                        listBox1.Items.Add(textBox1.Text);
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                int i = listBox1.SelectedIndex;
                  if (i < 0)
                  {
                      MessageBox.Show("selectionner un item");
                  }
                 else
                listBox2.Items.Add(listBox1.Text);
                 listBox1.Items.Remove(listBox1.Text); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = listBox2.SelectedIndex;
            if (i < 0)
            {
                MessageBox.Show("selectionner un item");
            }
            else
                listBox1.Items.Add(listBox2.Text);
            listBox2.Items.Remove(listBox2.Text); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           // for (int i = 0; i < listBox1.Items.Count; i++)
          //  {
          //      listBox1.Items.Remove(listBox1.Text); 
          //  }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < listBox2.Items.Count; i++)
            {
                listBox2.SetSelected(i, true);
                listBox1.Items.Add(listBox2.Text);
            }
            listBox2.Items.Clear();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
