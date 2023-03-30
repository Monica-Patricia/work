using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database_assignment
{
    public partial class Form1 : Form
    {
        stockScreen instockScreen = new stockScreen();

        searchScreen insearchScreen = new searchScreen();

        chartScreen inchartScreen = new chartScreen();
        public Form1()
        {
            InitializeComponent();
        }

        private void stock(object sender, EventArgs e)
        {
            instockScreen.Show();
        }

        private void showSearch(object sender, EventArgs e)
        {
            insearchScreen.Show();
        }

        private void showCharts(object sender, EventArgs e)
        {
            inchartScreen.Show();
        }
    }
}
