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

namespace PassWard
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            int length = 10;

            string password = GetRandomPassword(length);
            Console.WriteLine(password);
        }


        public static string GetRandomPassword(int length)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void genereateBtn_Click(object sender, EventArgs e)
        {
            passLabel.Text = GetRandomPassword(Int32.Parse(numChtrs.Text));
            copiedlabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passLabel.Text);
            copiedlabel.Visible = true;
        }

        private void passLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string path = @"c:\temp\Passwords.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("All your Passwords:");
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("Website Used: " + websitetxt.Text);
                    sw.WriteLine("Password: " + passLabel.Text);
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }


    }
}
