using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // this.radioButton1.CheckedChanged += new System.EventHandler(this.affiche);
           // this.radioButton2.CheckedChanged += new System.EventHandler(this.affiche);
            //this.radioButton3.CheckedChanged += new System.EventHandler(this.affiche);

           // this.checkBox1.CheckedChanged += new System.EventHandler(this.affiche);
           // this.checkBox2.CheckedChanged += new System.EventHandler(this.affiche);
            //this.checkBox3.CheckedChanged += new System.EventHandler(this.affiche);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.Title = "Save an Text File";
            // saveFileDialog1.ShowDialog();

            // Saves the Image via a FileStream created by the OpenFile method.

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String nomFichier = saveFileDialog1.FileName;
                StreamWriter fichier = null;
                try
                {
                    fichier = new StreamWriter(nomFichier);
                    foreach( object nom in listBox1.Items)
                    fichier.WriteLine(nom.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Probléme à l'ecriture du fichier ("
                        + ex.Message + ")", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    if (fichier != null)
                    {
                        fichier.Dispose();
                    }
                }

            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void affiche(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                CheckBox chk = (CheckBox)sender;
                listBox1.Items.Add(chk.Name + "=" + chk.Checked);
            }
            // est-ce un radiobutton ?
            if (sender is RadioButton)
            {
                RadioButton rdb = (RadioButton)sender;
                listBox1.Items.Add(rdb.Name + "=" + rdb.Checked);
            }
          
           
        }
    }
}
