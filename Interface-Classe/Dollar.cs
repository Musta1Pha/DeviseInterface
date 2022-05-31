using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Classe
{
    class Dollar:Devise
    {
        private double TauxMad;
        private double TauxEuro;


        public Dollar(double v,char s,double Te, double Tm):base(v,s)
        {
            this.TauxEuro = Te;
            this.TauxMad = Tm;

        }
       
        override public Devise ConvertTo(char c)
        {
            if (c == 'M')
                return CreateMad(TauxMad);
            else
                return CreateEuro(TauxEuro);
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write("TauxMad : " + TauxMad + "TauxEuro : " + TauxEuro);
        }


    }
}
