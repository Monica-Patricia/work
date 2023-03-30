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
    public partial class searchScreen : Form
    {
        public searchScreen()
        {
            InitializeComponent();
        }

        private void SearchScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoeDatabaseDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.shoeDatabaseDataSet.Stock);

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
