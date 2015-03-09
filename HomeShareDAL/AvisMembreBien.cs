using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShareDAL
{
    /// <summary>
    /// Class décrivant un Avis donné sur un Bien par un Membre
    /// </summary>
    class AvisMembreBien
    {

        #region Fields
        private int _idAvis;
        private int _note;
        private string _message;
        private int _idMembre;
        private int _idBien;
        private DateTime _DateAvis;
        //l'AvisMembreBien doit être Approuvé avant d'être publié 
        //par défaut _Approuve est False
        private bool _Approuve = false;
        #endregion

        #region Properties
        /// <summary>
        /// Identifiant de l'Avis
        /// </summary>
        public int IdAvis
        {
            get { return _idAvis; }
            set { _idAvis = value; }
        }

        /// <summary>
        /// Note donnée à l'avis
        /// </summary>
        public int Note
        {
            get { return _note; }
            set { _note = value; }
        }

        /// <summary>
        /// Texte Message écrit par le Membre
        /// </summary>
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        /// <summary>
        /// Identifiant du Membre qui laisse l'Avis
        /// </summary>
        public int IdMembre
        {
            get { return _idMembre; }
            set { _idMembre = value; }
        }

        /// <summary>
        /// Identifiant du Bien commenté
        /// </summary>
        public int IdBien
        {
            get { return _idBien; }
            set { _idBien = value; }
        }

        /// <summary>
        /// Date à laquelle l'Avis est enregistré
        /// </summary>
        public DateTime DateAvis
        {
            get { return _DateAvis; }
            set { _DateAvis = value; }
        }

        /// <summary>
        /// Attribut permettant la publication de l'Avis
        /// True  =  approuvé donc publiable
        /// </summary>
        public bool Approuve
        {
            get { return _Approuve; }
            set { _Approuve = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Consttructeur vide permettant d'accéder à la DB
        /// </summary>
        public AvisMembreBien() { }

        /// <summary>
        /// Constructeur avec tous les paramètres de l'objet AvisMembreBien
        /// </summary>
        /// <param name="IdAvis">Identifiant de l'Avis</param>
        /// <param name="Note">Note donée à l'avis</param>
        /// <param name="Message">Message écrit par le Membre qui note le Bien</param>
        /// <param name="IdMembre">Identifiant du Membre qui note le Bien</param>
        /// <param name="IdBien">Identifiant du Bien noté</param>
        /// <param name="DateAvis">Date à laquelle l'Avis est enregistré</param>
        /// <param name="Approuve">Attribut permettant la publication de l'Avis</param>
        public AvisMembreBien(int IdAvis, int Note, string Message, int IdMembre, int IdBien, DateTime DateAvis, bool Approuve)
        {
            this.IdAvis = _idAvis;
            this.Note = _note;
            this.Message = _message;
            this.IdMembre = _idMembre;
            this.IdBien = _idBien;
            this.DateAvis = _DateAvis;
            this.Approuve = _Approuve;
        }

        #endregion

        #region Static Methods
        /// <summary>
        /// Récupération des données d'un Avis
        /// qui sera affiché dans la partial view...
        /// </summary>
        /// <param name="idAvis">identifiant de l'AvisMembreBien</param>
        /// <returns>un objet Avis</returns>
        public static AvisMembreBien chargerUnAvis(int idAvis)
        {
            List<Dictionary<string, object>> infoAvis = GestionConnexion.Instance.getData("SELECT * FROM AvisMembreBien WHERE idAvis = " + idAvis);
            AvisMembreBien avis = new AvisMembreBien();

            foreach(Dictionary<string,object> item in infoAvis)
            {
                avis.IdAvis = idAvis;
                avis.Note = (int)item["note"];
                avis.Message = item["message"].ToString();
                avis.IdMembre = (int)item["idMembre"];
                avis.IdBien = (int)item["idBien"];
                avis.DateAvis = (DateTime)item["DateAvis"];
                avis.Approuve = (bool)item["Approuve"];
             
            }

            return avis;

        }

        /// <summary>
        /// Récupération de tous les Avis 
        /// </summary>
        /// <returns>un list d'AvisMembreBien</returns>
        public static List<AvisMembreBien> chargerTousLesAvis()
        {
            List<Dictionary<string, object>> infosAvis = GestionConnexion.Instance.getData("SELECT * FROM AvisMembreBien");
            List<AvisMembreBien> listeAvis = new List<AvisMembreBien>();

            foreach (Dictionary<string, object> item in infosAvis)
            {
                AvisMembreBien avis = new AvisMembreBien();
                avis.IdAvis = (int)item["idAvis"];
                avis.Note = (int)item["note"];
                avis.Message = item["message"].ToString();
                avis.IdMembre = (int)item["idMembre"];
                avis.IdBien = (int)item["idBien"];
                avis.DateAvis = (DateTime)item["DateAvis"];
                avis.Approuve = (bool)item["Approuve"];

                listeAvis.Add(avis);

            }

            return listeAvis;
        }

        public static List<AvisMembreBien> getAvisFromBien(int idBien)
        {
            List<AvisMembreBien> listeAvisFromBien = new List<AvisMembreBien>();

            List<Dictionary<string, object>> desAvis = GestionConnexion.Instance.getData("SELECT * FROM AvisMembreBien WHERE idBien = " + idBien);

            foreach(Dictionary<string,object> item in desAvis)
            {
                AvisMembreBien avis = new AvisMembreBien();
                {
                    avis.IdAvis = (int)item["idAvis"];
                    avis.Note = (int)item["Note"];
                    avis.Message = item["message"].ToString();
                    avis.IdMembre = (int)item["idMembre"];
                    avis.IdBien = idBien;
                    avis.DateAvis = (DateTime)item["DateAvis"];
                    avis.Approuve = (bool)item["Approuve"];
                
                };
                
                listeAvisFromBien.Add(avis);
            }
            return listeAvisFromBien;
        }
        #endregion


        
        #region Functions
        /// <summary>
        /// Ajout d'un AvisMembreBien à la DB
        /// ou 
        /// modification d'un AvisMembreBien sélectionné
        /// </summary>
        /// <param name="note">Note donnée par le Membre</param>
        /// <param name="message">Message écrit par le Membre</param>
        /// <param name="idMembre">Identifiant du Membre qui écrit</param>
        /// <param name="idBien">Identifiant du Bien noté</param>
        /// <param name="dateAvis">Date d'neregistrement de l'AvisMembreBien</param>
        /// <param name="approuve">Approuve est à False car l'AvisMembreBien n'est pas Approuvé par le Membre qui l'écrit : il n'y a donc pas accés lors de l'ajout</param>
        public bool addAvis()
        {
            AvisMembreBien a = AvisMembreBien.chargerUnAvis(this.IdAvis);
            string query = "";
            if (a == null)
            {
                 query = @"INSERT INTO [HomeShareDB].[dbo].[AvisMembreBien]
                                ([note],
                                 [message],
                                 [idMembre],
                                 [idBien],
                                 [DateAvis],
                                 [Approuve])
                            VALUES (@note, @message, @idMembre, @idBien, @DateAvis, @Approuve)";

            }
            else
            {
                query = @"UPDATE [HomeShareDB].[dbo].[AvisMembreBien]
                             SET[note]=@note,
                                [message]=@message,
                                [idMembre] = @idMembre,
                                [idBien]= @idBien,
                                [DateAvis] = @DateAvis,
                                [Approuve] = @Approuve
                           WHERE [idAvis] = @idAvis";
            }

            Dictionary<string, object> dicoValues = new Dictionary<string, object>();
            dicoValues.Add("note", Note);
            dicoValues.Add("message", Message);
            dicoValues.Add("idMembre", IdMembre);
            dicoValues.Add("idBien", IdBien);
            dicoValues.Add("DateAvis", DateAvis);
            dicoValues.Add("Approuve", Approuve);

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
        /// Permet d'effacer un AvisMembreBien
        /// </summary>
        public void effacerAvis(int idAvis)
        {
            AvisMembreBien a = AvisMembreBien.chargerUnAvis(idAvis);

            string query = @"DELETE FROM[HomeShareDB].[dbo].[AvisMembreBien]                             
                             WHERE [idAvis] = @idAvis";

            Dictionary<string, object> dicoValues = new Dictionary<string, object>();
            dicoValues.Add("idAvis", idAvis);
            GestionConnexion.Instance.saveData(query, GenerateKey.APP, dicoValues);
        }
        
        #endregion
    }
}
