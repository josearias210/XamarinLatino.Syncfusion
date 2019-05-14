using System.Collections.Generic;
using XamarinLatino.Syncfusion.Models;

namespace XamarinLatino.Syncfusion.ViewModels
{
    public class LenguajeViewModel
    {
        public List<Lenguaje> Lenguajes2016 { get; set; }
        public List<Lenguaje> Lenguajes2017 { get; set; }
        public List<Lenguaje> Lenguajes2018 { get; set; }

        public LenguajeViewModel()
        {
            CargarData();
        }

        private void CargarData()
        {
            Lenguajes2016 = new List<Lenguaje>()
            {
                new Lenguaje { Nombre = "JAVA", Votos = 120 },
                new Lenguaje { Nombre = "C#", Votos = 220 },
                new Lenguaje { Nombre = "PHP", Votos = 190 },
                new Lenguaje { Nombre = "PYTHON", Votos = 160 }
            };

            Lenguajes2017 = new List<Lenguaje>()
            {
                new Lenguaje { Nombre = "JAVA", Votos = 180 },
                new Lenguaje { Nombre = "C#", Votos = 230 },
                new Lenguaje { Nombre = "PHP", Votos = 110 },
                new Lenguaje { Nombre = "PYTHON", Votos = 210 }
            };

            Lenguajes2018 = new List<Lenguaje>()
            {
                new Lenguaje { Nombre = "JAVA", Votos = 150 },
                new Lenguaje { Nombre = "C#", Votos = 220 },
                new Lenguaje { Nombre = "PHP", Votos = 90 },
                new Lenguaje { Nombre = "PYTHON", Votos = 140 }
            };
        }
    }
}
