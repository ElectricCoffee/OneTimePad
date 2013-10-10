using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace one_time_pad
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            ManualModeToggle.Checked = true;

        }

        private void EncodeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (EncodeRadio.Checked == true)
            {
                KeyBox.ReadOnly = ManualModeToggle.Checked;
                OriginalBox.ReadOnly = false;
                CodeBox.ReadOnly = true;
                CodeButton.Text = "Encode";
            }
            else
            {
                KeyBox.ReadOnly = false;
                OriginalBox.ReadOnly = true;
                CodeBox.ReadOnly = false;
                CodeButton.Text = "Decode";
            }
        }

        private void ManualModeToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (EncodeRadio.Checked == true)
            {
                if (ManualModeToggle.Checked == true)
                    KeyBox.ReadOnly = true;
                else
                    KeyBox.ReadOnly = false;
            }
        }

        private void CodeButton_Click(object sender, EventArgs e)
        {
            if (EncodeRadio.Checked == true) // if Encode mode is on
            {
                if (ManualModeToggle.Checked == true)// if random code generation is on
                {
                    string[] values = Cryptor.Encode(OriginalBox.Text);
                    KeyBox.Text = values[0];
                    CodeBox.Text = values[1];
                }
                else // if random code generation is off
                {
                    CodeBox.Text = Cryptor.Encode(KeyBox.Text, OriginalBox.Text);
                }
            }
            else // if decode mode is on
            {
                OriginalBox.Text = Cryptor.Decode(KeyBox.Text, CodeBox.Text);
            }
        }
    }
}
