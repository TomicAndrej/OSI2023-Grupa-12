using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem_za_tehnicki_pregled
{
    internal class funkcije
    {
        private bool provjeraKorisnickogImena(string username)
        {
            if (username.Length < 5 || username.Length > 32)
            {
                //MessageBox.Show("Korisničko ime mora imati između 5 i 32 karaktera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username.Contains(","))
            {
                MessageBox.Show("Korisničko ime ne smije sadržavati zarez!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username.Contains("\t"))
            {
                MessageBox.Show("Korisničko ime ne smije sadržavati tab!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username.Contains("\n"))
            {
                MessageBox.Show("Korisničko ime ne smije sadržavati novi red!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username.Contains(" "))
            {
                MessageBox.Show("Korisničko ime ne smije sadržavati razmak!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username[0] == '0' || username[0] == '1' || username[0] == '2' || username[0] == '3' || username[0] == '4' || username[0] == '5' || username[0] == '6' || username[0] == '7' || username[0] == '8' || username[0] == '9')
            {
                MessageBox.Show("Korisničko ime ne smije počinjati brojem!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username[0] == '.')
            {
                MessageBox.Show("Korisničko ime ne smije počinjati tačkom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username[username.Length - 1] == '.')
            {
                MessageBox.Show("Korisničko ime ne smije završavati tačkom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            List<char> dozvoljeniKarakteri = new List<char>("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789._");
            foreach (char karakter in username)
            {
                if (!dozvoljeniKarakteri.Contains(karakter))
                {
                    MessageBox.Show("Korisničko ime sadrži nedozvoljeni karakter!\nDozvoljeni karakteri su samo slova, donja crta i tačka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            FileStream fs = new FileStream(@"..\..\..\klijent.txt", FileMode.Open, FileAccess.Read);
            try
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string red = sr.ReadLine();
                        string[] podaci = red.Split(' ');
                        if (username == podaci[2])
                        {
                            MessageBox.Show("Korisničko ime već postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čitanju iz datoteke: " + ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
            return true;
        }


        private bool provjeraLozinke(string lozinka)
        {
            if (lozinka.Length < 8 || lozinka.Length > 32)
            {
                //MessageBox.Show("Lozinka mora imati između 8 i 32 karaktera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (char c in lozinka)
            {
                if (c == ',')
                {
                    MessageBox.Show("Lozinka ne smije sadržavati zarez!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (c == '\t')
                {
                    MessageBox.Show("Lozinka ne smije sadržavati tab!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (c == '\n')
                {
                    MessageBox.Show("Lozinka ne smije sadržavati novi red!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool provjeraKorisnickogImenaBoka(string korisnickoIme)
        {
            string putanjaDoDatoteke = "..\\..\\..\\baza.txt";
            try
            {
                using (StreamReader sr = new StreamReader(putanjaDoDatoteke))
                {
                    while (!sr.EndOfStream)
                    {
                        string red = sr.ReadLine();
                        string[] podaci = red.Split(',');

                        if (podaci.Length == 2)
                        {
                            string korisnickoImeDatoteke = podaci[0];

                            if (korisnickoIme == korisnickoImeDatoteke)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čitanju iz datoteke: " + ex.Message);
            }

            return false;
        }

        private bool provjeraLozinkeBoka(string lozinka)
        {
            string putanjaDoDatoteke = "..\\..\\..\\baza.txt";
            try
            {
                using (StreamReader sr = new StreamReader(putanjaDoDatoteke))
                {
                    while (!sr.EndOfStream)
                    {
                        string red = sr.ReadLine();
                        string[] podaci = red.Split(',');

                        if (podaci.Length == 2)
                        {
                            string lozinkaDatoteka = podaci[1];

                            if (lozinka == lozinkaDatoteka)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čitanju iz datoteke: " + ex.Message);
            }

            return false;
        }

        private bool ProveriKorisnickoImeBokaSRB(string korisnickoIme)
        {
            List<char> dozvoljeniKarakteri = new List<char>("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789._\t\n");

            foreach (char karakter in korisnickoIme)
            {
                if (!dozvoljeniKarakteri.Contains(karakter))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
