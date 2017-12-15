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
    public partial class achiev2 : Form
    {
        public achiev2()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void achiev2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet6.achievements' table. You can move, or remove it, as needed.
            this.achievementsTableAdapter.Fill(this.dashboardDataSet6.achievements);
            filldata();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            achiev achiev = new achiev();
            achiev.Show();


        }
        void filldata()
        {
            Myconnection obj = new Myconnection();
            obj.con.Open();
            obj.qry = "select * from   achievements order by employee";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.dr = obj.cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(obj.dr);
            DataGridView1.AutoGenerateColumns = true;
            DataGridView1.DataSource = dt;
            DataGridView1.Refresh();
            obj.con.Close();

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Myconnection obj = new Myconnection();
            obj.con.Open();
            obj.qry = "select employee, forward,title,date,approval from achievements where employee like '%'+ '" + txtsearch.Text + "' + '%'";
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
