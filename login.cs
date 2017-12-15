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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Myconnection obj = new Myconnection();
            obj.con.Open();
            obj.qry = "select * from information where username='" + txtUserName.Text + "'" + " and password='" + txtPassword.Text + "'";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.dr = obj.cmd.ExecuteReader();
            if (obj.dr.Read() == true)
            {
                this.Hide();
                main_form main = new main_form();
                main.Show();
                obj.con.Close();

            }
            else
            {
                obj.con.Close();
                MessageBox.Show("Your User Name or Password is Incorrect Pls Try Again");
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtUserName.Focus();

            }
        }

        }
    }

