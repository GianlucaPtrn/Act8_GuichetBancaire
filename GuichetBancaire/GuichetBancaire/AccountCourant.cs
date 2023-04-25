﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GuichetBancaire
{
    class AccountCourant : Account
    {
		private int _decouvertAut;

		public int DecouvertAut
        {
			get { return _decouvertAut; }
			set { _decouvertAut = value; }
		} 
		public AccountCourant(string idAccount, User userName, double solde, string typeAccount,int decouvertAut) : base(idAccount, userName, solde, typeAccount)
		{
            this._idAccount = idAccount;
            this._userName = userName;
            this._solde = solde;
            this._typeAccount = typeAccount;
            this._decouvertAut = decouvertAut;
        }

        public bool VerifTransaction()
        {

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
                return "L'argent à bien n'as pas été retirer de votre compte : Vous n'avez pas assez sur ce compte";
            }
        }
    }
}
