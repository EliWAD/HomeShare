using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShareDAL
{
    /// <summary>
    /// Class déccrivant un Bien enregistré sur le site
    /// </summary>
    class BienEchange
    {
        #region Fields
        private int _idBien;
        private string _titre;
        private string _DescCourte;
        private string _DescLong;
        private int _NombrePerson;
        private int _idPays;
        private string _Ville;
        private string _Numero;
        private string _CodePostal;
        private string _Photo;
        private bool _AssuranceObligatoire;
        private bool _isEnabled;
        private DateTime ?_DisableDate;
        private string _Latitude;
        private string _Longitude;
        private int _idMembre;
        private DateTime _DateCreation;
        private Pays _pays;
        private Membre _membre;
        #endregion

        #region Properties
        /// <summary>
        /// Identifiant du Bien
        /// </summary>
        public int IdBien
        {
            get { return _idBien;  }
            set { _idBien = value;}
        }

        /// <summary>
        /// Titre de l'annonce présentant le Bien
        /// </summary>
        public string titre
        {
            get { return _titre;  }
            set { _titre = value; }
        }

        /// <summary>
        /// Description Courte Décrivant le Bien
        /// </summary>
        public string DescCourte
        {
            get { return _DescCourte;  }
            set { _DescCourte = value; }
        }

        /// <summary>
        /// Descrition Longue décrivant le Bien
        /// </summary>
        public string DescLong
        {
            get { return _DescLong;  }
            set { _DescLong = value; }
        }

        /// <summary>
        /// Capacité du Bien
        /// = nombre de personnes pouvant séjournées dans le Bien
        /// </summary>
        public int NombrePerson
        {
            get { return _NombrePerson;  }
            set { _NombrePerson = value; }
        }

        /// <summary>
        /// identifiant du Pays dans lequel se trouve le Bien
        /// </summary>
        public int idPays
        {
            get { return _idPays;  }
            set { _idPays = value; }
        }

        /// <summary>
        /// Ville dans lequel se trouve le Bien
        /// </summary>
        public string Ville
        {
            get { return _Ville;  }
            set { _Ville = value; }
        }

        /// <summary>
        /// Numéro de l'adresse du Bien
        /// </summary>
        public string Numero
        {
            get { return _Numero;  }
            set { _Numero = value; }
        }

        /// <summary>
        /// Code Postal de l'adresse du Bien
        /// </summary>
        public string CodePostal
        {
            get { return  _CodePostal;  }
            set { _CodePostal = value; }
        }

        /// <summary>
        /// Désignation du fichier Photo
        /// = Photo du Bien pour la présentation dans l'annonce
        /// </summary>
        public string Photo
        {
            get { return _Photo;  }
            set { _Photo = value; }
        }
        
        /// <summary>
        /// Paramètre indiquant si l'Assurance est Obligatoire lors de la réservation
        /// </summary>
        public bool AssuranceObligatoire
        {
            get { return _AssuranceObligatoire;  }
            set { _AssuranceObligatoire = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool isEnabled
        {
            get { return _isEnabled;  }
            set { _isEnabled = value; }
        }

        /// <summary>
        /// Date à laquelle le Bien n'est pas disponible
        /// </summary>
        public DateTime? DisableDate
        {
            get { return _DisableDate;  }
            set { _DisableDate = value; }
        }

        /// <summary>
        /// Latitude de la position du Bien
        /// </summary>
        public string Latitude
            {
            get { return _Latitude;  }
                set { _Latitude = value; }
        }

        /// <summary>
        /// Longitude de la position du Bien
        /// </summary>
        public string Longitude
        {
            get { return _Longitude;  }
            set { _Longitude = value; }
        }

        /// <summary>
        /// Identifiant du Membre louant le Bien
        /// </summary>
        public int idMembre
        {
            get { return _idMembre;  }
            set { _idMembre = value; }
        }

        /// <summary>
        /// Date de création de l'annonce dans laquelle se trouve le Bien
        /// </summary>
        public DateTime DateCreation
        {
            get { return  _DateCreation;  }
            set { _DateCreation = value; }
        }

        /// <summary>
        /// Objet Pays permettant d'accéder à la class Pays
        /// </summary>
        public Pays pays
        {
            get{ return _pays = _pays ?? Pays.getInfoPays(this.idPays);}
        }

        /// <summary>
        /// Navigation Properties permettant de récupérer les Membre du BienEchange courant
        /// </summary>
        public Membre membre
        {
            get{ return _membre = _membre ?? Membre.getInfoMembre(this.idMembre); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructeur vide pour accéder à la DB
        /// </summary>
        public BienEchange() { }
        /// <summary>
        /// Constructeur complet d'un BienEchange
        /// </summary>
        /// <param name="IdBien">Identifiant du BienEchange</param>
        /// <param name="titre"></param>
        /// <param name="DescCourte"></param>
        /// <param name="DescLong"></param>
        /// <param name="NombrePerson"></param>
        /// <param name="Pays"></param>
        /// <param name="Ville"></param>
        /// <param name="Numero"></param>
        /// <param name="CodePostal"></param>
        /// <param name="Photo"></param>
        /// <param name="AssuranceObligatoire"></param>
        /// <param name="isEnabled"></param>
        /// <param name="DisableDate"></param>
        /// <param name="Latitude"></param>
        /// <param name="Longitude"></param>
        /// <param name="idMembre"></param>
        /// <param name="DateCreation"></param>
        public BienEchange(int IdBien, string titre,string DescCourte, string DescLong, int NombrePerson,int Pays,string Ville, string Numero, string CodePostal, string Photo, bool AssuranceObligatoire, bool isEnabled, DateTime ?DisableDate, string Latitude, string Longitude , int idMembre, DateTime DateCreation)
        {
            this.IdBien = _idBien;
            this.titre = _titre;
            this.DescCourte = _DescCourte;
            this.DescLong =  _DescLong;
            this.NombrePerson = _NombrePerson;
            this.idPays =  _idPays;
            this.Ville = _Ville;
            this.Numero = _Numero;
            this.CodePostal = _CodePostal;
            this.Photo = _Photo;
            this.AssuranceObligatoire = _AssuranceObligatoire;
            this.isEnabled =  _isEnabled;
            this.DisableDate = _DisableDate;
            this.Latitude =  _Latitude;
            this.Longitude = _Longitude;
            this.idMembre = _idMembre;
            this.DateCreation = _DateCreation;
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Récupération des infos concernant un BienEchange
        /// </summary>
        /// <param name="idBien">Identifiant du BienEchange</param>
        /// <returns>un objet BienEchange</returns>
        public static BienEchange getInfoBien(int idBien)
        {
            List<Dictionary<string,object>> infoBien =  GestionConnexion.Instance.getData("SELECT * FROM BienEchange WHERE idBien = " + idBien);
            BienEchange bien = new BienEchange();

            foreach(Dictionary<string,object> item in infoBien)
            {
                bien.IdBien = idBien;
                bien.titre = item["titre"].ToString();
                bien.DescCourte = item["DescCourte"].ToString();
                bien.DescLong = item["DescLong"].ToString();
                bien.NombrePerson = (int)item["NombrePerson"];
                bien.idPays = (int)item["Pays"];
                bien.Ville = item["Ville"].ToString();
                bien.Numero = item["Numero"].ToString();
                bien.CodePostal = item["CodePostal"].ToString();
                bien.Photo = item["Photo"].ToString();
                bien.AssuranceObligatoire = (bool)item["AssuranceObligatoire"];
                bien.isEnabled = (bool)item["isEnabled"];
                bien.DisableDate = DateTime.Parse(item["DisableDate"].ToString());
                bien.Latitude = item["Latitude"].ToString();
                bien.Longitude = item["Longitude"].ToString();
                bien.idMembre = (int)item["idMembre"];
                bien.DateCreation = (DateTime)item["DateCreation"];
            }

            return bien; 
        }

        /// <summary>
        /// Récupération de la liste des BienEchange
        /// </summary>
        /// <returns>un liste de BienEchange</returns>
        public static List<BienEchange> getInfosBiens()
        {
            List<Dictionary<string, object>> infosBiens = GestionConnexion.Instance.getData("SELECT * FROM BienEchange");
            List<BienEchange> listebiens = new List<BienEchange>();

            foreach (Dictionary<string, object> item in infosBiens)
            {
                BienEchange bien = new BienEchange();
            
                bien.IdBien = (int)item["idBien"];
                bien.titre = item["titre"].ToString();
                bien.DescCourte = item["DescCourte"].ToString();
                bien.DescLong = item["DescLong"].ToString();
                bien.NombrePerson = (int)item["NombrePerson"];
                bien.idPays = (int)item["Pays"];
                bien.Ville = item["Ville"].ToString();
                bien.Numero = item["Numero"].ToString();
                bien.CodePostal = item["CodePostal"].ToString();
                bien.Photo = item["Photo"].ToString();
                bien.AssuranceObligatoire = (bool)item["AssuranceObligatoire"];
                bien.isEnabled = (bool)item["isEnabled"];
                bien.DisableDate = DateTime.Parse(item["DisableDate"].ToString());
                bien.Latitude = item["Latitude"].ToString();
                bien.Longitude = item["Longitude"].ToString();
                bien.idMembre = (int)item["idMembre"];
                bien.DateCreation = (DateTime)item["DateCreation"];

                listebiens.Add(bien);
            }

            return listebiens; 
        }

        /// <summary>
        /// Récupération de la liste des BienEchange en fonction du Pays
        /// </summary>
        /// <param name="idPays">Identifiant du Pays</param>
        /// <returns>une List<BienEchange></returns>
        public List<BienEchange> getBienByPays(int idPays)
        {
            List<BienEchange> listeBiens = new List<BienEchange>();

            List<Dictionary<string, object>> lesBiens = GestionConnexion.Instance.getData("SELECT * FROM BienEchange WHERE idPays = " + idPays);
            
            foreach(Dictionary<string,object> item in lesBiens)
            {
                BienEchange leBien = new BienEchange()
                {
                    IdBien = (int)item["idBien"],
                    titre = item["titre"].ToString(),
                    DescCourte = item["DescCourte"].ToString(),
                    DescLong = item["DescLong"].ToString(),
                    NombrePerson = (int)item["NombrePerson"],
                    idPays = idPays,
                    Ville = item["Ville"].ToString(),
                    Numero = item["Numero"].ToString(),
                    CodePostal = item["CodePostal"].ToString(),
                    Photo = item["Photo"].ToString(),
                    AssuranceObligatoire = (bool)item["AssuranceObligatoire"],
                    isEnabled = (bool)item["isEnabled"],
                    DisableDate = DateTime.Parse(item["DisableDate"].ToString()),
                    Latitude = item["Latitude"].ToString(),
                    Longitude = item["Longitude"].ToString(),
                    idMembre = (int)item["idMembre"],
                    DateCreation = (DateTime)item["DateCreation"]
                };

                listeBiens.Add(leBien);

            }

            return listeBiens;
        }

        /// <summary>
        /// Récupération de la liste des BienEchange en fonction de leur Capacité d'accueil
        /// </summary>
        /// <param name="leNbrPerson">Capacité</param>
        /// <returns>une List<BienEchange></returns>
        public List<BienEchange> getBienbyCapacite(int leNbrPerson)
        {
            List<BienEchange> listeBiens = new List<BienEchange>();

            List<Dictionary<string, object>> lesBiens = GestionConnexion.Instance.getData("SELECT * FROM BienEchange WHERE NombrePerson = " + leNbrPerson);

            foreach (Dictionary<string, object> item in lesBiens)
            {
                BienEchange leBien = new BienEchange()
                {
                    IdBien = (int)item["idBien"],
                    titre = item["titre"].ToString(),
                    DescCourte = item["DescCourte"].ToString(),
                    DescLong = item["DescLong"].ToString(),
                    NombrePerson = leNbrPerson,
                    idPays = (int)item["idPays"],
                    Ville = item["Ville"].ToString(),
                    Numero = item["Numero"].ToString(),
                    CodePostal = item["CodePostal"].ToString(),
                    Photo = item["Photo"].ToString(),
                    AssuranceObligatoire = (bool)item["AssuranceObligatoire"],
                    isEnabled = (bool)item["isEnabled"],
                    DisableDate = DateTime.Parse(item["DisableDate"].ToString()),
                    Latitude = item["Latitude"].ToString(),
                    Longitude = item["Longitude"].ToString(),
                    idMembre = (int)item["idMembre"],
                    DateCreation = (DateTime)item["DateCreation"]
                };

                listeBiens.Add(leBien);

            }

            return listeBiens;
        }

        #endregion

        #region Functions
        /// <summary>
        /// ajout d'un BienEchange dans la DB
        /// </summary>
        /// <returns></returns>
        public bool addBien()
        {
            BienEchange bienE = BienEchange.getInfoBien(this.IdBien);
            string query = @"INSERT INTO [HomeShareDB].[dbo].[BienEchange]
                                ([titre],
                                 [DescCourte],
                                 [DescLong],
                                 [NombrePerson],
                                 [Pays],
                                 [Ville],
                                 [Numero],
                                 [CodePostal],
                                 [Photo],
                                 [AssuranceObligatoire],
                                 [isEnabled],
                                 [DisableDate],
                                 [Latitude],
                                 [Longitude],
                                 [idMembre],
                                 [DateCreation])
                            VALUES(@tire, @DescCourte, @descLong, @NombrePerson, @Pays, @Ville, @Numero, @CodePostal, @Photo, @AssuranceObligatoire, @isEnable, @DisableDate, @Latitude, @Longitude, @idMembre, @DateCreation)";

            Dictionary<string, object> dicoValues = new Dictionary<string, object>();
            dicoValues.Add("titre", this.titre);
            dicoValues.Add("DescCourte", this.DescCourte);
            dicoValues.Add("DescLong", this.DescLong);
            dicoValues.Add("NombrePerson", this.NombrePerson);
            dicoValues.Add("Pays", this.idPays);
            dicoValues.Add("Ville", this.Ville);
            dicoValues.Add("Numero", this.Numero);
            dicoValues.Add("CodePostal", this.CodePostal);
            dicoValues.Add("Photo", this.Photo);
            dicoValues.Add("isEnable", this.isEnabled);
            dicoValues.Add("DisableDate", this.DisableDate == default(DateTime) ? DBNull.Value : (object)this.DisableDate);
            dicoValues.Add("Latitude", this.Latitude);
            dicoValues.Add("Longitude", this.Longitude);
            dicoValues.Add("idMembre", this.idMembre);
            dicoValues.Add("DateCreation", this.DateCreation);

            if(GestionConnexion.Instance.saveData(query, GenerateKey.APP, dicoValues))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Permet de modifier un BienEchange déjà existant
        /// </summary>
        /// <param name="idBien">Identifiant du BienEchange</param>
        /// <returns></returns>
        public bool modifyBien(int idBien)
        {
            BienEchange bienE = BienEchange.getInfoBien(idBien);

            string query = @"UPDATE [HomeShareDB].[dbo].[BienEchange]
                                SET [titre] = @titre,
                                    [DescCourte] = @DescCourte,
                                    [DescLong] = @DescLong,
                                    [NombrePerson] = @NombrePerson,
                                    [Pays] = @Pays,
                                    [Ville] = @Ville,
                                    [Numero] = @Numero,
                                    [CodePostal] = @CodePostal,
                                    [Photo] = @Photo,
                                    [isEnable] = @isEnable,
                                    [DisableDate]= @DisableDate,
                                    [Latitude] = @Latitude,
                                    [Longitude] = @Longitude,
                                    [idMembre] = @idMembre,
                                    [DateCreation]= @DateCreation
                                WHERE [idBien] = @idBien";

            Dictionary<string, object> dicoValues = new Dictionary<string, object>();
            dicoValues.Add("titre", this.titre);
            dicoValues.Add("DescCourte", this.DescCourte);
            dicoValues.Add("DescLong", this.DescLong);
            dicoValues.Add("NombrePerson", this.NombrePerson);
            dicoValues.Add("Pays", this.idPays);
            dicoValues.Add("Ville", this.Ville);
            dicoValues.Add("Numero", this.Numero);
            dicoValues.Add("CodePostal", this.CodePostal);
            dicoValues.Add("Photo", this.Photo);
            dicoValues.Add("isEnable", this.isEnabled);
            dicoValues.Add("DisableDate", this.DisableDate == default(DateTime) ? DBNull.Value : (object)this.DisableDate);
            dicoValues.Add("Latitude", this.Latitude);
            dicoValues.Add("Longitude", this.Longitude);
            dicoValues.Add("idMembre", this.idMembre);
            dicoValues.Add("DateCreation", this.DateCreation);

            if (GestionConnexion.Instance.saveData(query, GenerateKey.APP, dicoValues))
            {
                return true;
            }
            else
            {
                return false;
            }                        
        }

        public void effacerBien(int idBien)
        {
            BienEchange bienE = BienEchange.getInfoBien(idBien);

            string query = @"DELETE FROM [HomeShareDB].[dbo].[BienEchange]
                                WHERE [idBien]=@idBien";

            Dictionary<string, object> dicoValues = new Dictionary<string, object>();
            dicoValues.Add("idBien", idBien);
            GestionConnexion.Instance.saveData(query, GenerateKey.APP, dicoValues);
        }

        #endregion

        #region Private
        private List<Membre> chargerLesMembres()
        {
            string query = @"SELECT memb.* FROM Membre memb WHERE idMembre =" + this.idMembre;

            List<Dictionary<string, object>> mesMembres = GestionConnexion.Instance.getData(query);
            List<Membre> listeMembres = new List<Membre>();

            foreach (Dictionary<string,object>item in mesMembres)
            {
                Membre memb = new Membre();
                memb.idMembre = (int)item["idMembre"];
                memb.Nom = item["Nom"].ToString();
                memb.Prenom = item["Prenom"].ToString();
                memb.Email = item["Email"].ToString();
                memb.idPays = (int)item["idPays"];
                memb.Telephone = item["Telephone"].ToString();
                memb.Login = item["Login"].ToString();
                memb.Password = item["Password"].ToString();

                listeMembres.Add(memb);
            }

            return listeMembres;
        }
        #endregion
    }
}
