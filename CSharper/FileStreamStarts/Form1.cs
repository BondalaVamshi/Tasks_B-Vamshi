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

namespace FileStreamStarts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("F:/C#.net/FormFile.txt", FileMode.Create, FileAccess.Write);
            fs.WriteByte(5);
            fs.WriteByte(44);
            fs.Flush();
            MessageBox.Show("DATA INNSERTED");
            byte[] ba = new byte[] { 22, 23, 23, 14, 65, 75, 24 };
            fs.Write(ba, 0, ba.Length);
            fs.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("F:/C#.net/FormFile.txt", FileMode.Open, FileAccess.Read);
            MessageBox.Show(fs.ReadByte().ToString());
            MessageBox.Show(fs.ReadByte().ToString());
           byte[] ba = new byte[fs.Length];
            fs.Read(ba, 0, ba.Length);
            foreach(byte b in ba)
            {
                MessageBox.Show(b.ToString());
            }
            fs.Close();
        }
    }
}
