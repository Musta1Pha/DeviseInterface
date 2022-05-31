using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Classe
{
    abstract class Devise:IDevise
    {
        private double Valeur;
        private char Symbole;

        abstract public Devise ConvertTo(char c);

        public Devise(double v, char s) {
            this.Valeur = v;
            this.Symbole = s;
        }

        public Devise CreateDollar(double TauxD) {
            Dollar d = new Dollar(this.Valeur * TauxD,'D',0.9,10);
            return d;
        }

        public Devise CreateEuro(double TauxE)
        {
            Euro d = new Euro(this.Valeur * TauxE,'E',1.1,11);
            return d;
        }
        public Devise CreateMad(double TauxM)
        {
            Mad d = new Mad(this.Valeur * TauxM, 'M', 11, 10);
            return d;
        }

        virtual public void Afficher() {
            Console.WriteLine("Valeur : " + this.Valeur + "Symbole : " + this.Symbole);
        }



    }

}
