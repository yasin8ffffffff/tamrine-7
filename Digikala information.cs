///////////////یاسین منعم/////////////////﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digikala1.Model
{
    internal class Digikala_information
    {
        private Digikala digikala;
        private string line;
        public List<Digikala> digikalas { get; }
        public Digikala_information(string address)
        {

            digikalas = new List<Digikala>();

            using (StreamReader strread = new StreamReader(address))
            {
                strread.ReadLine();
                while (!strread.EndOfStream)
                {
                    line = strread.ReadLine();
                    digikala = new Digikala();

                    digikala.ID_Order = Convert.ToInt32(line.Split(",")[0]);
                    digikala.ID_Customer = Convert.ToInt32(line.Split(",")[1]);
                    digikala.ID_Item = Convert.ToInt32(line.Split(",")[2]);
                    digikala.DateTime_CartFinalize = Convert.ToDateTime(line.Split(",")[3]);
                    digikala.Amount_Gross_Order = Convert.ToInt32(line.Split(",")[4].Replace(".0", ""));
                    digikala.city_name_fa = line.Split(",")[5];

                    digikalas.Add(digikala);
                }
            }
        }
    }
}
