using Microsoft.AspNetCore.SignalR;
using System;

namespace DeAutoAtlas
{
    public enum EnumUserType
    {
        Customer,
        Dealer
    }

    public class User
    {
        public int ID { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Email { get; set; }
        public string Telefoon { get; set; }
        public string Mobiel { get; set; }
        public Adres Adres { get; set; }
    }
}
