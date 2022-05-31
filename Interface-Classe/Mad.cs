using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Classe
{
    class Mad:Devise
    {

        private double TauxDollar;
        private double TauxEuro;

        public Mad(double v, char s, double Td, double Te):base(v,s)
        {
            this.TauxDollar = Td;
            this.TauxEuro = Te;
        }
        override public Devise ConvertTo(char c) {
            if (c == 'D')
                return CreateDollar(TauxDollar);
            else 
                return CreateEuro(TauxEuro);
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write("TauxDollar : " + TauxDollar + "TauxEuro : " + TauxEuro);
        }



    }
}
