using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5_Draft
{
    public partial class FormGameSettings : Form
    {
        public FormGameSettings()
        {
            InitializeComponent();
            comboBoxSelectPattern.SelectedItem = comboBoxSelectPattern.Items[0];
            textBoxNumberApples.Text = "1";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sets the picture according to the 
        private void comboBoxSelectPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSelectPattern.SelectedItem.ToString())
            {
                case "Default":
                    pictureBoxSelectPattern.Image = Image.FromFile(@"Resources\Default.png");                
                break;
             
                case "Pattern 01":
                    pictureBoxSelectPattern.Image = Image.FromFile(@"Resources\Pattern_01.png");
                break;

                case "Pattern 02":
                    pictureBoxSelectPattern.Image = Image.FromFile(@"Resources\Pattern_02.png");
                break;

                case "Pattern 03":
                    pictureBoxSelectPattern.Image = Image.FromFile(@"Resources\Pattern_03.png");
                break;

                case "Pattern 04":
                    pictureBoxSelectPattern.Image = Image.FromFile(@"Resources\Pattern_04.png");
                break;

                case "Pattern 05":
                    pictureBoxSelectPattern.Image = Image.FromFile(@"Resources\Pattern_05.png");
                break;

                case "Pattern 06":
                    pictureBoxSelectPattern.Image = Image.FromFile(@"Resources\Pattern_06.png");
                break;

                case "Pattern 07":
                    pictureBoxSelectPattern.Image = Image.FromFile(@"Resources\Pattern_07.png");
                break;

                case "Pattern 08":
                    pictureBoxSelectPattern.Image = Image.FromFile(@"Resources\Pattern_08.png");
                break;

                case "Pattern 09":
                    pictureBoxSelectPattern.Image = Image.FromFile(@"Resources\Pattern_09.png");
                break;

                default:
                    pictureBoxSelectPattern.Image = Image.FromFile(@"Resources\Default.png");
                break;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            int NumberOfApples = 0;

            try
            {
                // Converting values to numbers.
                NumberOfApples = int.Parse(textBoxNumberApples.Text);

                if (NumberOfApples < 0)
                {
                    MessageBox.Show("Apples must be any positive integer.");
                    throw new FormatException();
                }

                MainForm mf = new MainForm(NumberOfApples, comboBoxSelectPattern.SelectedItem.ToString());         
                mf.ShowDialog();
            }
            catch (FormatException)
            {
                MessageBox.Show("Apples must be any positive integer.");
                textBoxNumberApples.Text = "1";
            }
        }
    }
}
