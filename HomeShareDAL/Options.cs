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
        #endregion

        #region Statics
        #endregion

        #region Functions
        #endregion
    }
}
