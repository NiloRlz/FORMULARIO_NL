﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inicio_de_sesion_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void registrar1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7LDGQBD;Initial Catalog=login;Integrated Security=True");
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                throw;
            }
            String sql = "insert into inicio_sesion (user_log,pass_log)values ('" + Nombre2.Text +"' , '"+ Contraseña2.Text+ "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("USUARIO REGISTRADO");
                this.Hide();
                Form1 n1 = new Form1();
                n1.Show();
            }
            catch(SqlException ex) { MessageBox.Show("Error" + ex, ToString()); }
        }
    }
}
