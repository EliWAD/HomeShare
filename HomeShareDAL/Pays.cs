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
        #endregion

        #region Functions
        #endregion
    }
}
