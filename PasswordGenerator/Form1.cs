using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        bool includeSymbols = false;
        bool includeNumbers = false;
        bool includeUppercase = false;

        string symbols = "!\"#$%&()*+,-./:;<=>?@[\\]^_`{|}";
        string numbers = "1234567890";
        string uppercase = "qwertyuiopasdfghjklzxcvbnm".ToUpper();

        public Form1()
        {
            InitializeComponent();
        }

        private void numbersLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int scrollPosition = hScrollBar.Value;
            Console.WriteLine(scrollPosition);
            scrollBarValue.Text = $"Size: {scrollPosition}";
        }

        private void scrollBarValue_Click(object sender, EventArgs e)
        {
            
        }

        private void symbolsCB_CheckedChanged(object sender, EventArgs e)
        {
            includeSymbols = symbolsCB.Checked;
        }

        private void numbersCB_CheckedChanged(object sender, EventArgs e)
        {
            includeNumbers = numbersCB.Checked;
        }

        private void uppercaseCB_CheckedChanged(object sender, EventArgs e)
        {
            includeUppercase = uppercaseCB.Checked;
        }

        private string GeneratePassword()
        {
            Random random = new Random();
            string letters = "qwertyuiopasdfghjklzxcvbnm";
            if (includeUppercase) 
            {
                letters += uppercase;
            }
            if (includeNumbers)
            {
                letters += numbers;
            }
            if(includeSymbols)
            {
                letters += symbols;
            }
            char[] chars = letters.ToCharArray();
            letters = "qwertyuiopasdfghjklzxcvbnm";
            string password = "";
            for(int i = 0; i < hScrollBar.Value; i++)
            {
                password += chars[random.Next(0, chars.Length)];
            }
            return password;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            textBox.Text = GeneratePassword();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if(textBox.Text.Length > 0)
            {
                Clipboard.SetText(textBox.Text);
            }
        }
    }
}
