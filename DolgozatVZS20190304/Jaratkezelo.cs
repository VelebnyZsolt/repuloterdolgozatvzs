using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatVZS20190304
{
    class Jaratkezelo

    {

        public int keses { get; set; }
        public string jaratszam { get; set; }
        public string repterhonnan { get; set; }
        public string repterhova { get; set; }
        public DateTime indulas {get; set;}


        List<Jaratkezelo> Jaratok = new List<Jaratkezelo>();

        public Jaratkezelo(string jaratszam, string repterhonnan, string repterhova, DateTime indulas, int keses)
        {
            this.jaratszam = jaratszam;
            this.repterhonnan = repterhonnan;
            this.repterhova = repterhova;
            this.indulas = indulas;
            this.keses = keses;
        }

        public void Ujjarat(string jaratszam, string repterhonnan, string repterhova, DateTime indulas,int keses)
        {


            jaratszam = jaratszam;
            repterhonnan = repterhonnan;
            repterhova = repterhova;
            indulas = indulas;

            var j = new Jaratkezelo(jaratszam, repterhonnan, repterhova, indulas,keses);
            Jaratok.Add(j);

        }

        public void mennyitkesik(string jaratszam, int keses)
        {

            keses = 0;
            this.keses = 0;

            Console.WriteLine("A járat " + jaratszam + "ennyit késik:" + keses);

        }


        public void Mikorindul(int keses, string jaratszam, DateTime indulas)
        {


            if (keses.Equals(0))
            {
                Console.WriteLine(indulas.GetDateTimeFormats();

            }
            else
            {
                Console.WriteLine("Ennyit késik a gép" + keses);

            }
  

        }




    }
}
