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
    public partial class promo : Form
    {



        Oops.promotioninfo pro = new Oops.promotioninfo();

      
   

        public promo()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                //double oldsal = Convert.ToDouble(txtoldsalary.Text);
                pro.oldsalary = Convert.ToDouble(txtoldsalary.Text);
                txtcursalary.Text = pro.calculatecurrentsalary().ToString();



                Myconnection obj = new Myconnection();
                obj.con.Open();
                obj.qry = "insert into promotions values (@promotion, @forward, @title, @date,@currentsal,@oldsal,@approval, @discription,@note )";
                obj.cmd = new SqlCommand(obj.qry, obj.con);
                obj.cmd.Parameters.AddWithValue("@promotion", txtpromotion.Text);
                obj.cmd.Parameters.AddWithValue("@forward", txtforwardpro.Text);
                obj.cmd.Parameters.AddWithValue("@title", txttitlepro.Text);
                obj.cmd.Parameters.AddWithValue("@date", dateTimePicker1pro.Text);
                obj.cmd.Parameters.AddWithValue("@approval", txtapppro.Text);
                obj.cmd.Parameters.AddWithValue("@note", txtnotepro.Text);
                obj.cmd.Parameters.AddWithValue("@discription", txtrichpro.Text);
                obj.cmd.Parameters.AddWithValue("@currentsal", txtcursalary.Text);
                obj.cmd.Parameters.AddWithValue("@oldsal", txtoldsalary.Text);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();

                MessageBox.Show("data saved ");
            }
            catch
            {
                MessageBox.Show("there is an Error", "sorry!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           
        }

        private void promo_Load(object sender, EventArgs e)
        {
            txtpromotion.Items.Clear();

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
                txtpromotion.Items.Add(dr["name"]).ToString(); ;

            }


            obj.con.Close();
        }
        

        private void txtoldsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtrichpro.Height = 250;
                
        }

        
        }
    }
    

