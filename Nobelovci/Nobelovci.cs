using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Nobelovci
{
    public partial class Nobelovci : Form
    {
        public Nobelovci()
        {
            InitializeComponent();
            string niz = @"Data Source=D:\vaje9\Nobelovci\nobelDB.db";
            SQLiteConnection povezava = new SQLiteConnection(niz);
            povezava.Open();
            SQLiteCommand ukaz = new SQLiteCommand(povezava);
            ukaz.CommandText = "SELECT DISTINCT(yr) FROM nobel";
            SQLiteDataReader rezultat = ukaz.ExecuteReader();
            while (rezultat.Read()) 
            {
                leta.Items.Add(rezultat[0].ToString());
            }
            leta.Update();
            rezultat.Close();

            ukaz.CommandText = "SELECT DISTINCT(winner) FROM nobel";
            rezultat = ukaz.ExecuteReader();
            while (rezultat.Read())
            {
                zmagovalci.Items.Add(rezultat[0].ToString());
            }
            zmagovalci.Update();
            rezultat .Close();

            ukaz.CommandText = "SELECT DISTINCT(subject) FROM nobel";
            rezultat = ukaz.ExecuteReader();
            while (rezultat.Read())
            {
                podrocja.Items.Add(rezultat.GetValue(0).ToString());
            }
            zmagovalci.Update();
            rezultat.Close();


            povezava.Close();
        }


        private void isci_Click(object sender, EventArgs e)
        {
            string izbranoLeto = leta.SelectedItem.ToString();
            string izbranoPodrocje = podrocja.SelectedItem.ToString();

            using (SQLiteConnection povezava = new SQLiteConnection(@"Data Source=D:\vaje9\Nobelovci\nobelDB.db"))
            {
                povezava.Open();
                using (SQLiteCommand ukaz = new SQLiteCommand(povezava))
                {
                    ukaz.CommandText = "SELECT winner FROM nobel WHERE subject = @podrocje AND yr = @leto";
                    ukaz.Parameters.AddWithValue("@podrocje", izbranoPodrocje);
                    ukaz.Parameters.AddWithValue("@leto", izbranoLeto);

                    using (SQLiteDataReader rezultat = ukaz.ExecuteReader())
                    {
                        StringBuilder vsiNagrajenci = new StringBuilder();
                        vsiNagrajenci.AppendLine($"Vsi nagrajenci za izbrano leto {izbranoLeto} in področje {izbranoPodrocje} so:\n");
                        while (rezultat.Read())
                        {
                            string nagrajenec = rezultat[0].ToString();
                            vsiNagrajenci.AppendLine($"*{nagrajenec}\n");

                        }
                        izpis.Text = vsiNagrajenci.ToString();
                    }

                }
            }
        }

        private void isciLeto_Click(object sender, EventArgs e)
        {
            string imeNagrajenca = zmagovalci.SelectedItem.ToString();

            using (SQLiteConnection povezava = new SQLiteConnection(@"Data Source=D:\vaje9\Nobelovci\nobelDB.db"))
            {
                povezava.Open();
                using (SQLiteCommand ukaz = new SQLiteCommand(povezava))
                {
                    ukaz.CommandText = "SELECT subject, yr FROM nobel WHERE winner = @zmagovalec";
                    ukaz.Parameters.AddWithValue("@zmagovalec", imeNagrajenca);

                    using (SQLiteDataReader rezultat = ukaz.ExecuteReader())
                    {
                        StringBuilder vsiNagrajenci = new StringBuilder();
                        vsiNagrajenci.AppendLine($"Vsa leta in področja za izbranega zmagovalca {imeNagrajenca}:\n");
                        while (rezultat.Read())
                        {
                            string podrocje = rezultat[0].ToString();
                            string leto = rezultat[1].ToString();
                            vsiNagrajenci.AppendLine($"*{leto}: {podrocje}\n");

                        }
                        izpis.Text = vsiNagrajenci.ToString();
                    }

                }
            }
        }
    }
}
