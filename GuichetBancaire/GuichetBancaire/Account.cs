using System;
using System.Collections.Generic;
using System.Text;

namespace GuichetBancaire
{
    abstract class Account
    {
		protected string _idAccount;
		protected User _userName;
		protected double _solde;
		protected string _typeAccount;

        public string IdAccount
        {
			get { return _idAccount; }
			set { _idAccount = value; }
		}

        public User UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
         
        public string TypeAccount
        {
            get { return _typeAccount; }
            set { _typeAccount = value; }
        }

        public double Solde
        {
            get { return _solde; }
            set { _solde = value; }
        }

        public Account(string idAccount, User userName, double solde, string typeAccount)
        {
            this._idAccount = idAccount;
            this._userName = userName;
            this._solde = solde;
            this._typeAccount = typeAccount;
        }

        public String Crediter(int AddMoney)
        {
            _solde += AddMoney;
            return "L'argent à bien été ajouter sur votre compte : " + AddMoney + " €"; 
        }

        public abstract string Debiter(int RetireMoney);

        //public string Versement()
        //{

        //}

        //public abstract void VerifTransaction()
        //{

        //}

        //public string CaractCompte()
        //{

        //}
    }
}
