﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace updatetiket
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=jecationn; User Id=postgres; Password=dita041003");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from tiket_masuk where id_tiket_masuk = 2";
            NpgsqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())

            {
                textBox1.Text = reader["id_tiket_masuk"].ToString();
                textBox2.Text = reader["kategori"].ToString();
                textBox3.Text = reader["harga_tiket_masuk"].ToString();
            }
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=jecationn; User Id=postgres; Password=dita041003");
            conn.Open();
            NpgsqlCommand comm = conn.CreateCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update tiket_masuk set harga_tiket_masuk = '" + textBox3.Text + "' where id_tiket_masuk = '" + textBox1.Text + "' and kategori = '" + textBox2.Text + "'";
            comm.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Harga tiket berhasil diperbarui!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
    }
}
