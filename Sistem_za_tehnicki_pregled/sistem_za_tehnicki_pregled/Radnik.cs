using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem_za_tehnicki_pregled
{
    internal class Radnik
    {
        private string username;
        private string password;
        private string ime;
        private string prezime;

        public Radnik(string username, string password, string ime, string prezime)
        {
            this.username = username;
            this.password = password;
            this.ime = ime;
            this.prezime = prezime;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string PrikaziFormat => $"{ime} {prezime} ({username})";
    }
}
