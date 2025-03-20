using System;

namespace DOO_Git1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            perro miPerro = new perro();

            miPerro.raza = "jackRussell";
            miPerro.edad = 11;
            miPerro.pais = "argentina";
            miPerro.sexo = "hembra";
            miPerro.tipo_de_pelo = "corto";

            miPerro.ladrar();
            miPerro.dormir();

            cerveza birra = new cerveza();

            birra.estilo = "BarleyWine";
            birra.alcohol = 10.5;
            birra.marca = "Antares";
            birra.origen = "mar del plata";
            birra.precio = 4000;

            birra.destapar();
            birra.servir();
            birra.beber();
        }



        public class perro
        {
            public string raza;
            public int edad;
            public string pais;
            public string sexo;
            public string tipo_de_pelo;

            public void ladrar()
            {
                Console.WriteLine("Estoy ladrando!");
            }
            public void dormir()
            {
                Console.WriteLine("Estoy Durmiendo...zZz");
            }
        }

        public class cerveza
        {
            public string estilo;
            public double alcohol;
            public string marca;
            public string origen;
            public double precio;


            public void destapar()
            {
                Console.WriteLine("pssss..");
            }
            public void servir()
            {
                Console.WriteLine("ahi va...");
            }
            public void beber()
            {
                Console.WriteLine("ñam ñam");
            }
        }
    }
}
    