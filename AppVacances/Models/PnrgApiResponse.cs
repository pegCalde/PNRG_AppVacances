using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AppVacances
{
    public class PnrgApiResponse
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

            [JsonProperty("listLieuPrefUser")]
            public List<LieuPrefUser> ListLieuPrefUser
            {
                get;
                set;
            }
        }

    }
}

