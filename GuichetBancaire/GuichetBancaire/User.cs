using System;
using System.Collections.Generic;
using System.Text;

namespace GuichetBancaire
{
    public class User
    {
        protected string _nom;
        protected string _prenom;
        private float _numero;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public float Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public User(string nom, string prenom, float numero)
        {
            this._nom = nom;
            this._prenom = prenom;
            this._numero = numero;
        }

        public string CaracteUser()
        {
            string caracteUser = "Votre nom : " + _nom + " votre prénom : " + _prenom + " votre numero de téléphone : " + _numero;
            return caracteUser;
        }
    }
}
