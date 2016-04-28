﻿using System;
using System.Data;
using System.Windows.Forms;
using CAREMATCH;
using Oracle.ManagedDataAccess.Client;
using System.IO;

namespace Login
{
    public partial class GebruikerBeheer : Form
    {
        private Gebruiker gebruiker;
        private Database database;

        public GebruikerBeheer(Gebruiker gebruiker)
        {
            InitializeComponent();
            database = new Database();
            this.gebruiker = gebruiker;

            cmbBeheer.SelectedIndex = 0;
            //File.Open("p\\VOG.dot", FileMode.Open);
        }



        private void cmbBeheer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            database.GebruikerBeheer(cmbBeheer.Text).Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           
        }



        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            database.DataUpdateBeheerGebruiker(dataGridView1.Rows[e.RowIndex].Cells["GEBRUIKERSNAAM"].Value.ToString() + "' WHERE GEBRUIKERID = " + Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["GEBRUIKERID"].Value));
            database.DataUpdateBeheerRol(dataGridView1.Rows[e.RowIndex].Cells["APPROVED"].Value.ToString() + "' WHERE GEBRUIKERID = " + Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["GEBRUIKERID"].Value));


            if (dataGridView1.Rows[e.RowIndex].Cells["Rol"].Value.ToString().ToLower() != "beheerder" || dataGridView1.Rows[e.RowIndex].Cells["Rol"].Value.ToString().ToLower() != "vrijwilliger" || dataGridView1.Rows[e.RowIndex].Cells["Rol"].Value.ToString().ToLower() != "hulpbehoevende")
            {
                MessageBox.Show("Incorrecte rol.");
            }
            else
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE GEBRUIKER SET ROL ='" + dataGridView1.Rows[e.RowIndex].Cells["ROL"].Value.ToString() + "' WHERE GEBRUIKERID = " + Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["GEBRUIKERID"].Value);
                cmd.ExecuteNonQuery();
                con.Close();
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
