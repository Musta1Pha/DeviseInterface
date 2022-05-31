using System;

namespace Interface_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro e = new Euro(50, 'E', 0.9, 11);
            Mad m = new Mad(50, 'M', 11, 10);
            Devise d1 = e.ConvertTo('D');

            //Devise m = e.ConvertTo('M');
            d1.Afficher();

        }
    }
}
