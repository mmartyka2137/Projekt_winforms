using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_winforms
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            DateFormatter dateFormatter = new DateFormatter();
            Date todayDate = new Date(dateTime.Year, dateTime.Month, dateTime.Day);
            this.timer_date.Text = dateFormatter.ToShortDateString(todayDate);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
