using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_2020_01_HW01_3A713105
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cryptoMD5 = System.Security.Cryptography.MD5.Create();
            var bytes = Encoding.UTF8.GetBytes(inputttb.Text);
            var hash = cryptoMD5.ComputeHash(bytes);
            var md5 = BitConverter.ToString(hash);
            outputtB.Text = md5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
