using System;
using System.Collections.Generic;
using System.Text;

namespace GuichetBancaire
{
    public class AccountEpargne : Account
    {
        private int _tauxInteret;

        public int TauxInteret
        {
            get { return _tauxInteret; }
            set { _tauxInteret = value; }
        }

        public AccountEpargne(string idAccount, User userName, double solde, string typeAccount, int tauxInteret) : base(idAccount, userName, solde, typeAccount)
        {
            this._idAccount = idAccount;
            this._userName = userName;
            this._solde = solde;
            this._typeAccount = typeAccount;
            this._tauxInteret = tauxInteret;
        }

        public override bool VerifTransaction()
        {
            double transaction = 0; 
            if(transaction > Solde / 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string Debiter(double RetireMoney)
        {
            if (this.VerifTransaction() == true)
            {
                _solde -= RetireMoney;
                return "L'argent à bien été retirer de votre compte : " + RetireMoney + " €";
            }
            else
            {
                return "L'argent à bien n'as pas été retirer de votre compte : Vous n'avez pas retirer plus de la moitié en une fois sur ce compte";
            }
        }

    }
}
