﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021
{
    public partial class RiepilogoCommesse : Form
    {
        int i = 0;
        string stringa_connessione = Properties.Resources.StringaConnessione;
        public RiepilogoCommesse()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            i = 7;
            passaggio();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            i = 8;
            passaggio();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            i = 9;
            passaggio();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            i = 6;
            passaggio();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            i = 5;
            passaggio();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = 4;
            passaggio();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 0;
            passaggio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 2;
            passaggio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 13;
            passaggio();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RiepilogoCommesse_Load(object sender, EventArgs e)
        {
            Calcolo();
        }

        private void Calcolo()
        {
            string query_of1, query_of2, query_of3, query_s1, query_s2, query_s3, query_t1, query_t2, query_t3, query_of11, query_of12, query_ass1, query_ass2, query_ass3;
            query_of1 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 1 AND Stato=0";
            query_of2 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 1 AND (Stato=2)";
            query_of3 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 1 AND (Stato>3)";
            query_of11 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 1 AND (Stato=3)";
            query_of12 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 1 AND (Stato=1)";
            query_s1 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 2 AND Stato=0";
            query_s2 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 2 AND Stato=1";
            query_s3 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 2 AND Stato=2";
            query_t1 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 3 AND Stato=0";
            query_t2 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 3 AND Stato=1";
            query_t3 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 3 AND Stato=2";
            query_ass1 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 4 AND Stato=0";
            query_ass2 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 4 AND Stato=1";
            query_ass3 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 4 AND Stato=2";
            SqlConnection connessione = new SqlConnection(stringa_connessione);
            SqlCommand comando2 = new SqlCommand(query_of1, connessione);
            SqlCommand comando1 = new SqlCommand(query_of2, connessione);
            SqlCommand comando = new SqlCommand(query_of3, connessione);
            SqlCommand comando3 = new SqlCommand(query_s1, connessione);
            SqlCommand comando4 = new SqlCommand(query_s2, connessione);
            SqlCommand comando5 = new SqlCommand(query_s3, connessione);
            SqlCommand comando6 = new SqlCommand(query_t1, connessione);
            SqlCommand comando7 = new SqlCommand(query_t2, connessione);
            SqlCommand comando8 = new SqlCommand(query_t3, connessione);
            SqlCommand comando11 = new SqlCommand(query_of11, connessione);
            SqlCommand comando12 = new SqlCommand(query_of12, connessione);
            SqlCommand comando13 = new SqlCommand(query_ass1, connessione);
            SqlCommand comando14 = new SqlCommand(query_ass2, connessione);
            SqlCommand comando15 = new SqlCommand(query_ass3, connessione);
            connessione.Open();
            button1.Text = Convert.ToString(comando.ExecuteScalar());
            button2.Text = Convert.ToString(comando1.ExecuteScalar());
            button3.Text = Convert.ToString(comando2.ExecuteScalar());
            button4.Text = Convert.ToString(comando3.ExecuteScalar());
            button5.Text = Convert.ToString(comando4.ExecuteScalar());
            button6.Text = Convert.ToString(comando5.ExecuteScalar());
            button7.Text = Convert.ToString(comando6.ExecuteScalar());
            button8.Text = Convert.ToString(comando7.ExecuteScalar());
            button9.Text = Convert.ToString(comando8.ExecuteScalar());
            button11.Text = Convert.ToString(comando11.ExecuteScalar());
            button12.Text = Convert.ToString(comando12.ExecuteScalar());
            button13.Text = Convert.ToString(comando15.ExecuteScalar());
            button14.Text = Convert.ToString(comando14.ExecuteScalar());
            button15.Text = Convert.ToString(comando13.ExecuteScalar());
            connessione.Close();
        }

        private void passaggio()
        {
            Dett_Riepilogo_Commesse dett = new Dett_Riepilogo_Commesse(i);
            dett.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ControllaAbbinamenti abbina = new ControllaAbbinamenti();
            abbina.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            i = 1;
            passaggio();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            i = 3;
            passaggio();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            i = 43;
            passaggio();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            i = 41;
            passaggio();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            i = 42;
            passaggio();
        }
    }
}
