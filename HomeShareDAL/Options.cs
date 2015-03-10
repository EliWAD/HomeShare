using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShareDAL
{
    class Options
    {
        #region Fields
        private int _idOption;
        private string _Libelle;
        #endregion

        #region Properties
        /// <summary>
        /// Identifiant de l'Option
        /// </summary>
        public int IdOption
        {
            get { return _idOption; }
            set { _idOption = value; }
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
        public Options() { }
        public Options(int idOption, string libelle)
        {
            this.IdOption = idOption;
            this.Libelle = libelle;
        }
        #endregion

        #region Statics
        public static List<Options> chargerLesOptions()
        {
            List<Dictionary<string, object>> infosOptions = GestionConnexion.Instance.getData("SELECT * FROM Options");
            
            List<Options> listeOptions = new List<Options>();

            foreach(Dictionary<string,object> item in infosOptions)
            {
                Options opt =new Options()
                {
                    IdOption = (int)item["idOption"],
                    Libelle = item["Libelle"].ToString()
                };

                listeOptions.Add(opt);

            }

            return listeOptions;
        }
        #endregion

        #region Functions
        #endregion
    }
}
