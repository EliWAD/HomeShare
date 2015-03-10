using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShareDAL
{
    class OptionsBien
    {
        #region Fields
        private int _idOption;
        private int _idBien;
        private string _Valeur;
        #endregion

        #region Properties
        public int IdOption
        {
            get { return _idOption; }
            set { _idOption = value; }
        }

        public int IdBien
        {
            get { return _idBien; }
            set { _idBien = value; }
        }

        public string Valeur
        {
            get { return _Valeur; }
            set { _Valeur = value; }
        }
        #endregion

        #region Constructors
        public OptionsBien() { }
        public OptionsBien(int idBien, int idOption, string valeur)
        {
            this.IdBien = idBien;
            this.IdOption = idOption;
            this.Valeur = valeur;
        }
        #endregion

        #region Statics
        public static OptionsBien chargerlisteOptions(int idOption)
        {
            List<Dictionary<string, object>> infoOptions = GestionConnexion.Instance.getData("SELECT * FROM OptionsBien WHERE idOption = " + idOption);
            OptionsBien opt = new OptionsBien();
            
            foreach(Dictionary<string,object> item in infoOptions)
            {
                opt.IdBien = (int)item["idBien"];
                opt.IdOption = (int)item["idOption"];
                opt.Valeur = item["Valeur"].ToString();
            }

            return opt;
        }
        #endregion


    }
}
