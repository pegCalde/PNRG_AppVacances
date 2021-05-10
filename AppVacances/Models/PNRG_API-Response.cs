using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AppVacances.Models
{
    public class PNRG_API_Response
    {
        public partial class LieuPrefUser
        {
            [JsonProperty("nom")]
            public String Nom
            {
                get;
                set;
            }

            [JsonProperty("favoris")]
            public Boolean Favoris
            {
                get;
                set;
            }
        }

        public partial class UtilisateurObject
        {
            [JsonProperty("username")]
            public String Username
            {
                get;
                set;
            }

            [JsonProperty("password")]
            public String Password
            {
                get;
                set;
            }

            [JsonProperty("nom")]
            public String Nom
            {
                get;
                set;
            }

            [JsonProperty("prenom")]
            public String Prenom
            {
                get;
                set;
            }

            [JsonProperty("listeLieuPrefUser")]
            public List<LieuPrefUser> ListeLieuPrefUser
            {
                get;
                set;
            }
        }

    }
}

