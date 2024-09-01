using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoJao
{
    //Lucas ou villa, depois excluam as funções que não estamos usando pf
    public partial class Form1 : Form
    {
        public int cliques = 0;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel4.Location = new Point(panel4.Location.X, vScrollBar1.Maximum-vScrollBar1.Value);
            panel5.Location = new Point(panel5.Location.X, vScrollBar1.Maximum - vScrollBar1.Value);
            panel6.Location = new Point(6,panel5.Location.Y-107);
            panel7.Location = new Point(93, panel4.Location.Y - 107);
            panel10.Location = new Point(6, panel6.Location.Y - 107);
            panel9.Location = new Point(93, panel7.Location.Y - 107);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BtnClique_Click(object sender, EventArgs e)
        {
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (i < imageList1.Images.Count)
            {
                pictureBox3.BackgroundImage = imageList1.Images[i];
                i++;
                pictureBox3.Location = new Point(pictureBox3.Location.X - 12, pictureBox3.Location.Y);

            }
            else if (i >= imageList1.Images.Count && i < 27)
            {
                i++;
                pictureBox4.Location = new Point(750, 290);

            }
            else {
                if (a<imageList2.Images.Count) 
                { 
                    pictureBox4.Location = new Point(9999, 290);
                    pictureBox3.BackgroundImage = imageList2.Images[a];
                    pictureBox3.Location = new Point(pictureBox3.Location.X + 12, pictureBox3.Location.Y);a++;
                }
                else { TimerAnimação.Stop(); }
            }
                
            // Teste de commit do Pedro VV
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnClique_Click_1(object sender, EventArgs e)
        {

            cliques++;
            TxtCliques.Text = cliques.ToString();
            //Resgatar do banco de dados//
            TxtDinheiro.Text = Convert.ToString(Convert.ToDouble(TxtDinheiro.Text) + 1);
        }
    }
}
