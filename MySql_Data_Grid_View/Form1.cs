using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySql_Data_Grid_View
{
    public partial class Form1 : Form
    {
        string dbconstr = "SERVER=localhost; DATABASE=sales; UID=root; PWD=12345";
        public Form1()
        {
            InitializeComponent();
        }

        public void ActiveUsersTotal()


        {
            using (var connection = new MySqlConnection(dbconstr))
            {
                using (var cmd = new MySqlCommand("SELECET COUNT(city) AS TOTAL FROM sales WHERE city='london' ", connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dt = cmd.ExecuteReader();
                        if (dt.Read())
                        {
                            int activeuserstoplam = Convert.ToInt32(dt["TOTAL"].ToString());
                            if (activeuserstoplam < 1)
                            {
                                lblActiveUsers.Text = "Not Found Active Users";
                            }
                            else
                            {
                                lblActiveUsers.Text = $"TOTAL{activeuserstoplam} Active Users Found";
                            }
                        }

                    }
                    catch (Exception Error)
                    {

                        MessageBox.Show("There is an error:\n" +Error.Message);
                    }


                }

            }
        }

        public void PassiveUsersTotal()


        {
            using (var connection = new MySqlConnection(dbconstr))
            {
                using (var cmd = new MySqlCommand("SELECET COUNT(city) AS TOTAL FROM sales WHERE city='manchester' ", connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dt = cmd.ExecuteReader();
                        if (dt.Read())
                        {
                            int activeuserstoplam = Convert.ToInt32(dt["TOTAL"].ToString());
                            if (activeuserstoplam < 1)
                            {
                                lblActiveUsers.Text = "Not Found Passive Users";
                            }
                            else
                            {
                                lblActiveUsers.Text = $"TOTAL{activeuserstoplam} Passive Users Found";
                            }
                        }

                    }
                    catch (Exception Error)
                    {

                        MessageBox.Show("There is an error:\n" + Error.Message);
                    }


                }

            }
        }


        private void btnActiveUsers_Click(object sender, EventArgs e)
        {
            #region active users pulled up           
            using (var connect = new MySqlConnection(dbconstr))
            {
                using (var adap = new MySqlDataAdapter("SELECT * FROM sales WHERE city='london'", connect))
                {
                    try
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        dgvUsers.DataSource = dt;
                        dgvUsers.Columns[0].HeaderText = "CUSTOMER ID";
                        dgvUsers.Columns[1].HeaderText = "INVOICE";
                        dgvUsers.Columns[2].HeaderText = "BRANCH";
                        dgvUsers.Columns[3].HeaderText = "CITY";
                        dgvUsers.Columns[4].HeaderText = "CUSTOMER";
                        dgvUsers.Columns[5].HeaderText = "GENDER";
                        dgvUsers.Columns[6].HeaderText = "PRODUCT";
                        connect.Close();

                    }
                    catch (Exception)
                    {
                        throw;

                    }
                }
            }
            #endregion
            
        }


        private void btnPassiveUsers_Click(object sender, EventArgs e)
        {
            #region Passive users pulled up
            using (var connect = new MySqlConnection(dbconstr))
            {
                using (var adap = new MySqlDataAdapter("SELECT * FROM sales WHERE city ='manchester'", connect))
                {
                    try
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        dgvUsers.DataSource = dt;
                        dgvUsers.Columns[0].HeaderText = "CUSTOMER ID";
                        dgvUsers.Columns[0].Visible = false;
                        dgvUsers.Columns[1].HeaderText = "INVOICE";
                        dgvUsers.Columns[2].HeaderText = "BRANCH";
                        dgvUsers.Columns[3].HeaderText = "CITY";
                        dgvUsers.Columns[4].HeaderText = "CUSTOMER";
                        dgvUsers.Columns[5].HeaderText = "GENDER";
                        dgvUsers.Columns[6].HeaderText = "PRODUCT";
                        connect.Close();

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            #endregion
        }
    }
}




