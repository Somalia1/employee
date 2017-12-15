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
    public partial class transfer2 : Form
    {
        public transfer2()
        {
            InitializeComponent();
        }
    Oops.TransferInformation transfer = new Oops.TransferInformation();

    private void Button1_Click(object sender, EventArgs e)
    {

        try
        {
            string forward = Convert.ToString(cmboxforward.Text);
            string transfertoemployee = Convert.ToString(cmbotransfer.Text);


            transfer.transferto(transfertoemployee);
            transfer.transferto(forward);



            Myconnection obj = new Myconnection();
            obj.con.Open();
            obj.qry = "insert into transfer values (@employeetransfer, @forward, @title, @date, @approval, @discription,@note )";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.cmd.Parameters.AddWithValue("@employeetransfer", cmbotransfer.Text);
            obj.cmd.Parameters.AddWithValue("@forward", cmboxforward.Text);
            obj.cmd.Parameters.AddWithValue("@title", txttitletra.Text);
            obj.cmd.Parameters.AddWithValue("@date", dateTimePicker1tra.Text);
            obj.cmd.Parameters.AddWithValue("@approval", txtapprovaltra.Text);
            obj.cmd.Parameters.AddWithValue("@note", txtnotetra.Text);
            obj.cmd.Parameters.AddWithValue("@discription", txtrichtra.Text);
            //obj.cmd.Parameters.AddWithValue("@transfernum", txtnum.Text);
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
            MessageBox.Show("Data Saved Successfully");

        }
        catch
        {
            MessageBox.Show("there is an Error", "oops!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

    }
        private void txtdisctra_TextChanged(object sender, EventArgs e)
        {

        }

        private void transfer2_Load(object sender, EventArgs e)
        {
            cmbotransfer.Items.Clear();
            Myconnection obj = new Myconnection();
            obj.con.Open();

            obj.qry = "select name from information order by id";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(obj.cmd);

            da1.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                cmbotransfer.Items.Add(dr["name"]).ToString();;
               
            }
            
           
            obj.con.Close();






        }
            //catch
            //{
               // MessageBox.Show("there is an Error", "oops!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //}
        }
}
  

