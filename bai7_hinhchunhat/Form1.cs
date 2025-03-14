using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai7_hinhchunhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            int dai = Int32.Parse(txtDai.Text);
            int rong = Int32.Parse(txtRong.Text);
            int dientich, chuvi = 0;

            chuvi = dai + rong * 2;
            dientich = dai * rong;

            txtChuVi.Text = chuvi.ToString();
            txtDienTich.Text = dientich.ToString();


        }
    }
}
