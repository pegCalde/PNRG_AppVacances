using System;
using System.Collections.Generic;
using System.Text;

namespace AppVacances.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Lieu { get; set; }
        public string NbVue { get; set; }
        public string NbShare { get; set; }
        public string Photo { get; set; }
        public string Background { get; set; }
        public User()
        {
            Username = "Perceval";
            Description = "Chef de clan des semi-croustillants";
            Date = "20/08/2000";
            Lieu = "Nice";
            NbVue = "0";
            NbShare = "0";
            Photo = "https://cdn.pixabay.com/photo/2015/04/19/08/32/marguerite-729510_1280.jpg";
            Background = "https://www.proflowers.com/blog/wp-content/uploads/2019/08/mexican-flowers-hero.jpg";
        }
    }
}
