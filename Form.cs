using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace EnzoOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void WebICON_Click(object sender, EventArgs e)
        {
            Browser.Visible = true;
            Browser.Enabled = true;
            Browser.BringToFront();
        }

        private void HTTP_TextChanged(object sender, EventArgs e)
        {
            
            Web.Navigate(@"http://www." + HTTP.Text);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Web.GoBack();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Web.Navigate(@"http://www.yandex.com");
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Web.Navigate(@"http://www." + HTTP.Text);
        }

        private void Forvard_Click(object sender, EventArgs e)
        {
            Web.GoForward();
        }

        private void Close1_Click(object sender, EventArgs e)
        {
            Browser.Visible = false;
            Browser.Enabled = false;
        }

        private void NoteICON_Click(object sender, EventArgs e)
        {
            Note.Visible = true;
            Note.Enabled = true;
            Note.BringToFront();
        }

        private void Close2_Click(object sender, EventArgs e)
        {
            Note.Visible = false;
            Note.Enabled = false;
        }

        private void Сlear_Click(object sender, EventArgs e)
        {
            OneCalc.Text = " ";
            TwoCalc.Text = " ";
            Ravno.Text = " ";
        }

        private void Razdel_Click(object sender, EventArgs e)
        {

            double result = Convert.ToDouble(OneCalc.Text) / Convert.ToDouble(TwoCalc.Text);
            Ravno.Text = result.ToString();
        }

        private void Umnozit_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(OneCalc.Text) * Convert.ToDouble(TwoCalc.Text);
            Ravno.Text = result.ToString();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(OneCalc.Text) + Convert.ToDouble(TwoCalc.Text);
            Ravno.Text = result.ToString();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(OneCalc.Text) - Convert.ToDouble(TwoCalc.Text);
            Ravno.Text = result.ToString();
        }

        private void CaicICON_Click(object sender, EventArgs e)
        {
            Calc.Visible = true;
            Calc.Enabled = true;
            Calc.BringToFront();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Calc.Visible = false;
            Calc.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToShortTimeString();
        }
        private void displayTime()
        {
            Time.Text = DateTime.Now.ToShortTimeString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CalendarICON_Click(object sender, EventArgs e)
        {
            Calendar.Visible = true;
            Calendar.Enabled = true;
            Calendar.BringToFront();
        }

        private void Close4_Click(object sender, EventArgs e)
        {
            Calendar.Visible = false;
            Calendar.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void InfoICON_Click(object sender, EventArgs e)
        {
            Info.Visible = true;
            Info.Enabled = true;
            Info.BringToFront();
        }

        private void Close9_Click(object sender, EventArgs e)
        {
            Info.Visible = false;
            Info.Enabled = false;
        }
    
        
    }
}
