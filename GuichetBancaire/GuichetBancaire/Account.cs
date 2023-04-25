using System;
using System.Collections.Generic;
using System.Text;

namespace GuichetBancaire
{
    public abstract class Account
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

        public abstract string Debiter(double RetireMoney);
        public abstract bool VerifTransaction();


        public string Versement(double RetireMoney)
        {
            if (this.VerifTransaction() == true)
            {
                _solde -= RetireMoney;
                return "L'argent à bien été retirer de votre compte : " + RetireMoney + " €";
            }
            else
            {
                return "L'argent à bien n'as pas été retirer de votre compte : Vous n'avez pas assez sur ce compte";
            }
        }

        public string CaractCompte()
        {
            return "votre numero de compte est : " + IdAccount + ". Vous avez un solde de : " + Solde + ". Ce compte est de type : " + TypeAccount;
        }
    }
}
