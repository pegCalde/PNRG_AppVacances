using System;
using System.Collections.Generic;

namespace AppVacances.Models
{
    public class Utilisateur
    {
        string username;
        string password;
        string nom;
        string prenom;
        List<LieuPrefUser> listLieuPrefUsers;


        public string Username
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public string Nom
        {
            get;
            set;
        }

        public string Prenom
        {
            get;
            set;
        }

        public List<LieuPrefUser> ListLieuPrefUsers
        {
            get;
            set;
        }


        public Utilisateur(String username, String password, String nom, String prenom, List<LieuPrefUser> listLieuPrefUsers)
        {
            Username = username;
            Password = password;
            Nom = nom;
            Prenom = prenom;
            ListLieuPrefUsers = listLieuPrefUsers;
        }
    }
}
