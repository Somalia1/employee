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
    public partial class achiev : Form
    {
        public achiev()
        {
            InitializeComponent();
        }
        Oops.achievementclass achievment = new Oops.achievementclass();

        private void Button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                achievment.employeename = txtemployeeach.Text;
                achievment.forwarapp = txtforwardach.Text;
                achievment.achievmenttitle = txttitleach.Text;
                achievment.approval = txtapprovalach.Text;
                achievment.discription = richboxach.Text;
                achievment.note = txtnoteach.Text;

                Myconnection obj = new Myconnection();
                obj.con.Open();
                obj.qry = "insert into achievements values (@employee, @forward, @title, @date, @approval, @discription,@note )";
                obj.cmd = new SqlCommand(obj.qry, obj.con);
                obj.cmd.Parameters.AddWithValue("@employee", txtemployeeach.Text);
                obj.cmd.Parameters.AddWithValue("@forward", txtforwardach.Text);
                obj.cmd.Parameters.AddWithValue("@title", txttitleach.Text);
                obj.cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());
                obj.cmd.Parameters.AddWithValue("@approval", txtapprovalach.Text);
                obj.cmd.Parameters.AddWithValue("@note", txtnoteach.Text);
                obj.cmd.Parameters.AddWithValue("@discription", richboxach.Text);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
                MessageBox.Show("Data Saved Successfully");
            }
            catch
            {
                MessageBox.Show("there is an Error", "sorry!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void achiev_Load(object sender, EventArgs e)
        {
            txtemployeeach.Items.Clear();
            Myconnection obj = new Myconnection();
            obj.con.Open();

            obj.qry = "select name from information order by id";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(obj.cmd);

            da1.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtemployeeach.Items.Add(dr["name"]).ToString(); ;

            }


            obj.con.Close();
        }
    }
}
