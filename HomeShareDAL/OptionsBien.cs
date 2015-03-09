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
        #endregion

        #region Statics
        #endregion

        #region Functions
        #endregion
    }
}
