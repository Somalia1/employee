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
    public partial class transfer : Form
    {
        public transfer()
        {
            InitializeComponent();
        }

        private void transfer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet8.transfer' table. You can move, or remove it, as needed.
            this.transferTableAdapter1.Fill(this.dashboardDataSet8.transfer);
            // TODO: This line of code loads data into the 'dashboardDataSet7.transfer' table. You can move, or remove it, as needed.
            this.transferTableAdapter.Fill(this.dashboardDataSet7.transfer);
            //filldata();
        }
       



        private void txtsearchtra_TextChanged(object sender, EventArgs e)
        {
            Myconnection obj = new Myconnection();
            obj.con.Open();
            obj.qry = "select  employeetransfer,forward,title,date,approval from transfer where employeetransfer like '%'+ '" + txtsearchtra.Text + "' + '%'";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.dr = obj.cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(obj.dr);
            DataGridView1.AutoGenerateColumns = true;
            DataGridView1.DataSource = dt;
            DataGridView1.Refresh();
            obj.con.Close();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //filldata();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.transferTableAdapter.FillBy(this.dashboardDataSet7.transfer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            transfer2 trans = new transfer2();
            trans.Show();
        }
    }
}
