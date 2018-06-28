using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme1
{
    public class Animal
    {
        public string Grupa  { get; set; }
        public string GradDomesticire { get; set; }
        public string Rasa { get; set; }
        public int DurataViata { get; set; }
        public int GreutateMedie { get; set; }
        public bool NecesitaLesa { get; set; }

        public Animal()
        {

        }
        public Animal(string grupa, string gradDomesticire, string rasa, int durataViata, int greutateMedie, bool necesitaLesa)
        {
            Grupa = grupa;
            GradDomesticire = gradDomesticire;
            Rasa = rasa;
            DurataViata = durataViata;
            GreutateMedie = greutateMedie;
            NecesitaLesa = necesitaLesa;
        }
        public virtual void Display()
        {
            Console.WriteLine("Animalul ales:");
            Console.WriteLine($"Este din grupa {Grupa} , fiind un animal {GradDomesticire}, din rasa {Rasa} !!");
            Console.WriteLine($"Acesta are o greutate medie de {GreutateMedie}, si o durata medie de viata de {DurataViata} ani!");
        }

    }

    public abstract class Mamifer:Animal
    {
        public bool Latra { get; set; }
        public bool Domestic { get; set; }
        public int Varsta { get; set; }
        public string Nume { get; set; }
        public string Tip { get; set; }
        
        public Mamifer ()
        {

        }
        public Mamifer(string gradDomesticire, string rasa, int durataViata, int greutateMedie, bool NecesitaLesa) : base("Mamifer", gradDomesticire, rasa, durataViata, greutateMedie,NecesitaLesa)
        {

        }
        public Mamifer(string nume,bool latra, bool domestic, int varsta, string tip)
        {
            Latra = latra;
            Domestic = domestic;
            Varsta = varsta;
            Nume = nume;
            Tip = tip;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Acesta este {Nume} si are {DurataViata} de ani!");
            if(Domestic==true)
            {
                Console.WriteLine("Este un animal domestic!");
            }
            else
            {
                Console.WriteLine("Este un animal salbatic!");
            }
            if (Latra==true)
            {
                Console.WriteLine("Acest animal latra!");
            }
            else
            {
                Console.WriteLine("Acest animal nu latra!");
            }
        }

    }
    public abstract class Pasare : Animal
    {
        public bool ImitaSunete { get; set; }
        public bool Domestic { get; set; }
        public string Varsta { get; set; }
        public string Nume { get; set; }

        public Pasare()
        {

        }
        public Pasare(string grupa, string gradDomesticire, string rasa, int durataViata, int greutateMedie,bool necesitaLesa) : base("Pasare", gradDomesticire, rasa, durataViata, greutateMedie, necesitaLesa)
        {

        }
        protected Pasare(string nume, bool imitaSunete, bool domestic, string varsta)
        {
            ImitaSunete = imitaSunete;
            Domestic = domestic;
            Varsta = varsta;
            Nume = nume;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Acesta este {Nume} si are {Varsta} de ani!");
            if (Domestic == true)
            {
                Console.WriteLine("Este un animal domestic!");
            }
            else
            {
                Console.WriteLine("Este un animal salbatic!");
            }
            if (ImitaSunete == true)
            {
                Console.WriteLine("Acest animal poate sa va imite !");
            }
            else
            {
                Console.WriteLine("Acest animal doar ciripeste!");
            }
        }

    }
    sealed class Papagal:Pasare
    {
        public Papagal(string grupa, string gradDomesticire, string rasa, int durataViata, int greutateMedie,bool necesitaLesa): base( grupa, gradDomesticire, "Papagal",  durataViata,greutateMedie,necesitaLesa)
        {

        }
         Papagal(string nume, bool imitaSunete, bool domestic, string varsta): base( nume,  imitaSunete, domestic, varsta)
        {

        }
        public override string ToString()
        {
            return $"Object -> Papagalul {Nume} este {Grupa} si are {Varsta} de ani! ";
        }
    }
    public class Caine : Mamifer
    {  
        public Caine()
        {

        }

        public Caine (string grupa, string gradDomesticire, string rasa, int durataViata, int greutateMedie, bool necesitaLesa) : base(gradDomesticire, "Caine", durataViata, greutateMedie, necesitaLesa)
        {

        }
        public Caine(string nume, bool latra, bool domestic,int varsta,string tip) : base(nume, latra, domestic, varsta,tip)
        {
            
        }
        public override string ToString()
        {
            return $" Cainele {Nume} este {Grupa} si are {DurataViata} de ani, cu o greutate{GreutateMedie} kg!! ";
        }

    }
}

