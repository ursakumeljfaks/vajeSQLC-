using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmi
{
    public partial class Filmi : Form
    {
        public Filmi()
        {
            InitializeComponent();
            string niz = @"Data Source=D:\vaje9\Filmi\filmi.sqlite";
            SQLiteConnection povezava = new SQLiteConnection(niz);
            povezava.Open();
            SQLiteCommand ukaz = new SQLiteCommand(povezava);
            ukaz.CommandText = "SELECT DISTINCT leto FROM filmi";
            SQLiteDataReader rezultat = ukaz.ExecuteReader();
            while (rezultat.Read())
            {
                leta.Items.Add(rezultat[0].ToString());
            }
            leta.Update();
            rezultat.Close();

            ukaz.CommandText = "SELECT DISTINCT reziser FROM filmi";
            rezultat = ukaz.ExecuteReader();
            while (rezultat.Read())
            {
                reziserji.Items.Add(rezultat[0].ToString());
            }
            reziserji.Update();
            rezultat.Close();

            ukaz.CommandText = "SELECT DISTINCT naslov FROM filmi";
            rezultat = ukaz.ExecuteReader();
            while (rezultat.Read())
            {
                naslovi.Items.Add(rezultat.GetValue(0).ToString());
            }
            naslovi.Update();
            rezultat.Close();




            povezava.Close();
        }

        private void izpisLeto_Click(object sender, EventArgs e)
        {
            string izbranoLeto = leta.SelectedItem.ToString();

            using (SQLiteConnection povezava = new SQLiteConnection(@"Data Source=D:\vaje9\Filmi\filmi.sqlite"))
            {
                povezava.Open();
                using (SQLiteCommand ukaz = new SQLiteCommand(povezava))
                {
                    ukaz.CommandText = "SELECT naslov, reziser, certifikat, dolzina, ocena, opis FROM filmi WHERE leto = @year";
                    ukaz.Parameters.AddWithValue("@year", izbranoLeto);

                    using (SQLiteDataReader rezultat = ukaz.ExecuteReader())
                    {
                        StringBuilder vse = new StringBuilder();
                        while (rezultat.Read())
                        {
                            string naslov = rezultat[0].ToString();
                            string reziser = rezultat[1].ToString();
                            string certifikat = rezultat[2].ToString();
                            string dolzina = rezultat[3].ToString();
                            string ocena = rezultat[4].ToString();
                            // v bazi ni kot TEXT ampak kot BLOB
                            byte[] opisBytes = (byte[])rezultat[5]; 
                            string opis = Encoding.UTF8.GetString(opisBytes);
                            vse.AppendLine($"Za leto {izbranoLeto}\nNaslov: {naslov}\nRežiser: {reziser}\nCertifikat: {certifikat}\nDolžina: {dolzina} min\nOcena: {ocena}/10\nOpis: {opis}\n");
                        }
                        izpis.Text = vse.ToString();
                    }

                }
            }
        }

        private void izpisReziser_Click(object sender, EventArgs e)
        {
            string izbranReziser = reziserji.SelectedItem.ToString();

            using (SQLiteConnection povezava = new SQLiteConnection(@"Data Source=D:\vaje9\Filmi\filmi.sqlite"))
            {
                povezava.Open();
                using (SQLiteCommand ukaz = new SQLiteCommand(povezava))
                {
                    ukaz.CommandText = "SELECT naslov, leto, certifikat, dolzina, ocena, opis FROM filmi WHERE reziser = @rezi";
                    ukaz.Parameters.AddWithValue("@rezi", izbranReziser);

                    using (SQLiteDataReader rezultat = ukaz.ExecuteReader())
                    {
                        StringBuilder vse = new StringBuilder();
                        while (rezultat.Read())
                        {
                            string naslov = rezultat[0].ToString();
                            string leto = rezultat[1].ToString();
                            string certifikat = rezultat[2].ToString();
                            string dolzina = rezultat[3].ToString();
                            string ocena = rezultat[4].ToString();
                            // v bazi ni kot TEXT ampak kot BLOB
                            byte[] opisBytes = (byte[])rezultat[5];
                            string opis = Encoding.UTF8.GetString(opisBytes);
                            vse.AppendLine($"Za režiserja: {izbranReziser}\nLeto {leto}\nNaslov: {naslov}\nCertifikat: {certifikat}\nDolžina: {dolzina} min\nOcena: {ocena}/10\nOpis: {opis}\n");
                        }
                        izpis.Text = vse.ToString();
                    }

                }
            }
        }

        private void izpisNaslov_Click(object sender, EventArgs e)
        {
            string izbranNaslov = naslovi.SelectedItem.ToString();

            using (SQLiteConnection povezava = new SQLiteConnection(@"Data Source=D:\vaje9\Filmi\filmi.sqlite"))
            {
                povezava.Open();
                using (SQLiteCommand ukaz = new SQLiteCommand(povezava))
                {
                    ukaz.CommandText = "SELECT leto, reziser, certifikat, dolzina, ocena, opis FROM filmi WHERE naslov = @title";
                    ukaz.Parameters.AddWithValue("@title", izbranNaslov);

                    using (SQLiteDataReader rezultat = ukaz.ExecuteReader())
                    {
                        StringBuilder vse = new StringBuilder();
                        while (rezultat.Read())
                        {
                            string leto = rezultat[0].ToString();
                            string reziser = rezultat[1].ToString();
                            string certifikat = rezultat[2].ToString();
                            string dolzina = rezultat[3].ToString();
                            string ocena = rezultat[4].ToString();
                            // v bazi ni kot TEXT ampak kot BLOB
                            byte[] opisBytes = (byte[])rezultat[5];
                            string opis = Encoding.UTF8.GetString(opisBytes);
                            vse.AppendLine($"Za naslov filma: {izbranNaslov}\nLeto {leto}\nRežiser: {reziser}\nCertifikat: {certifikat}\nDolžina: {dolzina} min\nOcena: {ocena}/10\nOpis: {opis}\n");
                        }
                        izpis.Text = vse.ToString();
                    }

                }
            }
        }

        private void gumbLeta_Click(object sender, EventArgs e)
        {
            string letoOd = letaOd.Text.ToString();
            string letoDo = letaDo.Text.ToString();

            using (SQLiteConnection povezava = new SQLiteConnection(@"Data Source=D:\vaje9\Filmi\filmi.sqlite"))
            {
                povezava.Open();
                using (SQLiteCommand ukaz = new SQLiteCommand(povezava))
                {
                    ukaz.CommandText = "SELECT naslov FROM filmi WHERE @od <= leto <= @do";
                    ukaz.Parameters.AddWithValue("@od", letoOd);
                    ukaz.Parameters.AddWithValue("@do", letoDo);


                    using (SQLiteDataReader rezultat = ukaz.ExecuteReader())

                    {
                        StringBuilder vse = new StringBuilder();
                        vse.AppendLine($"Vsi filmi med letom {letoOd} in {letoDo} so:\n");
                        while (rezultat.Read())
                        {
                            string naslov  = rezultat[0].ToString();
                            vse.AppendLine($"*{naslov}");
                        }
                        izpis.Text = vse.ToString();
                    }

                }
            }
        }

        private void top10_Click(object sender, EventArgs e)
        {

            using (SQLiteConnection povezava = new SQLiteConnection(@"Data Source=D:\vaje9\Filmi\filmi.sqlite"))
            {
                povezava.Open();
                using (SQLiteCommand ukaz = new SQLiteCommand(povezava))
                {
                    ukaz.CommandText = "SELECT naslov FROM filmi WHERE 9 <= ocena <= 10 LIMIT 10";

                    using (SQLiteDataReader rezultat = ukaz.ExecuteReader())

                    {
                        StringBuilder vse = new StringBuilder();
                        vse.AppendLine($"Top 10 filmov je:\n");
                        while (rezultat.Read())
                        {
                            string naslov = rezultat[0].ToString();
                            vse.AppendLine($"*{naslov}");
                        }
                        izpis.Text = vse.ToString();
                    }

                }
            }
        }
    }
}
