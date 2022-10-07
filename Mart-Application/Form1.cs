using System;
using System.Runtime.InteropServices;          //Library
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mart_Application
{
    public partial class Form1 : Form
    {


        



        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                pineapple_updown.Enabled = true;
                c_pineapple.Enabled = true;
            }
            else
            {
                pineapple_updown.Enabled = false;
                c_pineapple.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                orange_updown.Enabled = true;
                c_orange.Enabled = true;
            }
            else
            {
                orange_updown.Enabled = false;
                c_orange.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                peach_updown.Enabled = true;
                c_peach.Enabled = true;
            }
            else
            {
                peach_updown.Enabled = false;
                c_peach.Enabled = false;
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                apple_updown.Enabled = true;
                c_apple.Enabled = true;
            }
            else
            {
                apple_updown.Enabled = false;
                c_apple.Enabled = false;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                mango_updown.Enabled = true;
                c_mango.Enabled = true;
            }
            else
            {
                mango_updown.Enabled = false;
                c_mango.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                stawbery_updown.Enabled = true;
                c_stawbery.Enabled = true;
            }
            else
            {
                stawbery_updown.Enabled = false;
                c_stawbery.Enabled = false;
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            date_time.Text = "Date:" + DateTime.Now.ToString();
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            PrintDocument Pd = new PrintDocument();

            Pd.PrintPage += this.printDocument1_PrintPage;
            ppd.Document = Pd;
            ppd.ShowDialog();

           
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //  Bitmap bmp = new Bitmap(groupBox1.ClientRectangle.Width, groupBox1.ClientRectangle.Height);
            //  groupBox1.DrawToBitmap(bmp, groupBox1.ClientRectangle);
            //  e.Graphics.DrawImage(bmp, 0, 0);

            Bitmap bmp = new Bitmap(groupBox1.Width, groupBox1.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            groupBox1.DrawToBitmap(bmp, new Rectangle(0, 0, groupBox1.Width, groupBox1.Height));
            e.Graphics.DrawImage((Image)bmp, 0, 0);
        }

        private void date_time_Click(object sender, EventArgs e)
        {
            
        }

        private void apple_updown_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void apple_q_Click(object sender, EventArgs e)
        {
            
        }

        private void p_quantity_Click(object sender, EventArgs e)
        {
            

        }

        private void mango_q_Click(object sender, EventArgs e)
        {

        }

        private void orange_q_Click(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            apple_q.Text= apple_updown.Text;
            mango_q.Text = mango_updown.Text;
            orange_q.Text = orange_updown.Text;
            pineapple_q.Text = pineapple_updown.Text;
            peach_q.Text = peach_updown.Text;
            stawbery_q.Text = stawbery_updown.Text;

            
            double apple = Convert.ToDouble(apple_q.Text);
            double mango = Convert.ToDouble(mango_q.Text);
            double stawbery = Convert.ToDouble(stawbery_q.Text);
            double peach = Convert.ToDouble(peach_q.Text);
            double pineapple = Convert.ToDouble(pineapple_q.Text);
            double orange = Convert.ToDouble(orange_q.Text);
            double n = apple + mango+ stawbery + peach+ pineapple + orange;
            p_quantity.Text = n.ToString();

            //APPLE
            if (c_apple.SelectedText == "Good")
            {
                double value= apple * 200;
                apple_p.Text = value.ToString();
            }
            else
            {
                double value = apple * 150;
                apple_p.Text = value.ToString();
            }
            //ORANGE
            if (c_orange.SelectedText == "Good")
            {
                double value = orange * 300;
                orange_p.Text = value.ToString();
            }
            else
            {
                double value = orange * 200;
                orange_p.Text = value.ToString();
            }

            //MANGO
            if (c_mango.SelectedText == "Good")
            {
                double value = mango * 150;
                mango_p.Text = value.ToString();
            }
            else
            {
                double value = mango * 120;
                mango_p.Text = value.ToString();
            }
            //PEACH
            if (c_peach.SelectedText == "Good")
            {
                double value = peach * 250;
                peach_p.Text = value.ToString();
            }
            else
            {
                double value = peach * 200;
                peach_p.Text = value.ToString();
            }
            //PINEAPPLE
            if (c_pineapple.SelectedText == "Good")
            {
                double value = pineapple * 1000;
                pineapple_p.Text = value.ToString();
            }
            else
            {
                double value = pineapple * 800;
                pineapple_p.Text = value.ToString();
            }
            //STAWBERY
            if (c_stawbery.SelectedText == "Good")
            {
                double value = stawbery * 90;
                stawbery_p.Text = value.ToString();
            }
            else
            {
                double value = stawbery * 60;
                stawbery_p.Text = value.ToString();
            }

            double apple_t = Convert.ToDouble(apple_p.Text);
            double mango_t = Convert.ToDouble(mango_p.Text);
            double stawbery_t = Convert.ToDouble(stawbery_p.Text);
            double peach_t = Convert.ToDouble(peach_p.Text);
            double pineapple_t = Convert.ToDouble(pineapple_p.Text);
            double orange_t = Convert.ToDouble(orange_p.Text);
            if(discount.Checked==true)
            {
                double total_price = apple_t + mango_t + stawbery_t + peach_t + pineapple_t + orange_t - 50;
                price.Text = total_price.ToString();
            }
            if(radioButton1.Checked==true)
            {
                double total_price = apple_t + mango_t + stawbery_t + peach_t + pineapple_t + orange_t + 20;
                price.Text = total_price.ToString();
            }
            else if(radioButton2.Checked==true)
            {
                double total_price = apple_t + mango_t + stawbery_t + peach_t + pineapple_t + orange_t;
                price.Text = total_price.ToString();
            }
            else
            {
                MessageBox.Show("Please UnCheck if you dont need Bag !");
            }
            


            //price.Text= apple_p.Text + orange_p.Text + mango_p + stawbery_p + peach_p + pineapple_p;
        }

        private void c_apple_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
