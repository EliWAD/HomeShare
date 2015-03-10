using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShareDAL
{
    class Pays
    {
        #region Fields
        
        private int _idPays;
        
        private string _Libelle;
        #endregion

        #region Properties
        /// <summary>
        /// Identifiant du Pays
        /// </summary>
        public int IdPays
        {
            get { return _idPays; }
            set { _idPays = value; }
        }

        /// <summary>
        /// Designation du Pays
        /// </summary>
        public string Libelle
        {
            get { return _Libelle; }
            set { _Libelle = value; }
        }

        #endregion

        #region Constructors
        public Pays() { }
        public Pays(int idPays, string Libelle)
        {
            this.IdPays = _idPays;
            this.Libelle = _Libelle;
        }
        #endregion

        #region Statics
        public static Pays getInfoPays(int idPays)
        {
            List<Dictionary<string, object>> unPays = GestionConnexion.Instance.getData("SELECT * FROM Pays WHERE idPays = " + idPays);

            Pays pays = new Pays();

            foreach(Dictionary<string,object> item in unPays)
            {
                pays.IdPays = idPays;
                pays.Libelle = item["Libelle"].ToString();
            }

            return pays;
        }

        public static List<Pays> getInfosPays()
        {
            List<Dictionary<string, object>> tousLesPays = GestionConnexion.Instance.getData("SELECT * FROM Pays");

            List<Pays> listePays = new List<Pays>();

            foreach (Dictionary<string, object> item in tousLesPays)
            {
                Pays pays = new Pays()
                {
                    IdPays = (int)item["idPays"],
                    Libelle = item["Libelle"].ToString()

                };

                listePays.Add(pays);
            }

            return listePays;
        }

        #endregion

        #region Functions
        #endregion
    }
}
