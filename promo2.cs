using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
	
		 
	

namespace Agile
{
    public partial class promo2 : Form
    {
        public promo2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            promo promotion = new promo();
            promotion.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void promo2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet9.promotions' table. You can move, or remove it, as needed.
          //  this.promotionsTableAdapter.Fill(this.dashboardDataSet9.promotions);

        }

        private void txtsearchacg_TextChanged(object sender, EventArgs e)
        {
            Myconnection obj = new Myconnection();
            obj.con.Open();
            obj.qry = "select promotion,forward,date,approval from promotions where promotion like '%'+ '" + txtsearchacg.Text + "' + '%'";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.dr = obj.cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(obj.dr);
            DataGridView1.AutoGenerateColumns = true;
            DataGridView1.DataSource = dt;
            DataGridView1.Refresh();
            obj.con.Close();
        }
    }
}
