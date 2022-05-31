using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Classe
{
    class Euro:Devise
    {
        private double TauxDollar;
        private double TauxMad;



        public Euro(double v,char s,double Td, double Tm):base(v,s) {
            this.TauxDollar = Td;
            this.TauxMad = Tm;
        
        }
        override public Devise ConvertTo(char c)
        {
            if (c == 'D')
                return CreateDollar(TauxDollar);
            else
                return CreateMad(TauxMad);
             
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write("TauxDollar : " + TauxDollar + "TauxMad : " + TauxMad);
        }

    }
}
