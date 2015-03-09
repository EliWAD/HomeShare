using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShareDAL
{
    class Membre
    {
        #region Fields
        private int _idMembre;
        private string _Nom;
        private string _Prenom;
        private string _Email;
        private int _Pays;
        private string _Telephone;
        private string _Login;
        private string _Password;
        #endregion

        #region Properties
        /// <summary>
        /// Identifiant du Membre
        /// </summary>
        public int idMembre
        {
            get { return _idMembre; }
            set { _idMembre = value;}
        }

        /// <summary>
        /// Nom du Membre
        /// </summary>
        public string Nom
            {
            get { return _Nom; }
            set { _Nom = value;}
        }

        /// <summary>
        /// Prenom du Membre
        /// </summary>
        public string Prenom
            {
            get { return _Prenom; }
            set { _Prenom = value;}
        }

        /// <summary>
        /// Email du Membre
        /// </summary>
        public string Email
            {
            get { return _Email; }
            set { _Email = value;}
        }

        /// <summary>
        /// Identifiant du Pays du Membre
        /// </summary>
        public int Pays
            {
            get { return _Pays; }
            set { _Pays = value;}
        }

        /// <summary>
        /// Téléphone du Membre
        /// </summary>
        public string Telephone
            {
            get { return _Telephone; }
            set { _Telephone = value;}
        }

        /// <summary>
        /// Login du Membre
        /// </summary>
        public string Login
            {
            get { return _Login; }
            set { _Login= value;}
        }

        /// <summary>
        /// Password du Membre
        /// </summary>
        public string Password
            {
            get { return _Password; }
            set { _Password = value;}
        }
        #endregion

        #region Constructors
        public Membre() { }
        public Membre(int idMembre, string Nom, string Prenom, string Email, int Pays, string Telephone, string Login, string Password)
        {
            this.idMembre = _idMembre;
            this.Nom = _Nom;
            this.Prenom = _Prenom;
            this.Email = _Email;
            this.Pays = _Pays;
            this.Telephone = _Telephone;
            this.Login = _Login;
            this.Password = _Password;
        }
        #endregion

        #region Static Methods
        public static Membre getInfoMembre(int idMemb)
        {
            List<Dictionary<string, object>> infoMembre = GestionConnexion.Instance.getData("SELECT * FROM Membre WHERE idMembre =" + idMemb);
            Membre memb = new Membre();

            foreach(Dictionary<string,object> item in infoMembre)
            {
                memb.idMembre = idMemb;
                memb.Nom = item["Nom"].ToString();
                memb.Prenom = item["Prenom"].ToString();
                memb.Email = item["Email"].ToString();
                memb.Pays = (int)item["Pays"];
                memb.Telephone = item["Telephone"].ToString();
                memb.Login = item["Login"].ToString();
                memb.Password = item["Password"].ToString();
            }

            return memb;
        }

        public static List<Membre> getInfosMembres()
        {
            List<Dictionary<string, object>> infosMembres = GestionConnexion.Instance.getData("SELECT * FROM Membre");
            List<Membre> listeMembres = new List<Membre>();

            foreach(Dictionary<string,object> item in infosMembres)
            {
                Membre me = new Membre();
                me.idMembre = (int)item["idMembre"];
                me.Nom = item["Nom"].ToString();
                me.Prenom = item["Prenom"].ToString();
                me.Email = item["Email"].ToString();
                me.Pays = (int)item["Pays"];
                me.Telephone = item["Telephone"].ToString();
                me.Login = item["Login"].ToString();
                me.Password = item["Password"].ToString();

                listeMembres.Add(me);
            }

            return listeMembres;
        }
        #endregion

        #region Functions
        /// <summary>
        /// Enregistre un nouveau Membre dans la DB
        /// </summary>
        /// <returns></returns>
        public bool inscrireMembre()
        {
            Membre memb = Membre.getInfoMembre(this.idMembre);

            string query = "";

            if(memb == null)
            {
                query = @"INSERT INTO [HomeShare].[dbo].[Membre]
                            ([Nom],
                             [Prenom],
                             [Email],
                             [Pays],
                             [Telephone],
                             [Login],
                             [Password])
                            VALUES (@Nom,@Prenom,@Email,@Pays,@Telephone, @Login, @Password)";
            }

            Dictionary<string, object> dicoValues = new Dictionary<string, object>();
            dicoValues.Add("Nom", Nom);
            dicoValues.Add("Prenom", Prenom);
            dicoValues.Add("Email", Email);
            dicoValues.Add("Pays", Pays);
            dicoValues.Add("Telephone", Telephone);
            dicoValues.Add("Login", Login);
            dicoValues.Add("Password", Password);

            if(GestionConnexion.Instance.saveData(query, GenerateKey.APP,dicoValues))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void effacerMembre(int idMembre)
        {
            Membre memb = Membre.getInfoMembre(idMembre);

            string query = @"DELETE FROM [HomeShareDB].[dbo].[Membre]
                                WHERE [idMembre] = @idMembre";

            Dictionary<string, object> dicoValues = new Dictionary<string, object>();

            GestionConnexion.Instance.saveData(query, GenerateKey.APP, dicoValues);

        }
        #endregion
    }
}
