using System;

namespace T2008M_AP.As.Zoo
{
    public class Elaphant : Species,Body,Diet,Reproduction,Domestication
    {
        private string speciesname;
        private string eheight;
        private string eweight;

        public string Speciesname
        {
            get => speciesname;
            set => speciesname = value;
        }

        public string Eheight
        {
            get => eheight;
            set => eheight = value;
        }

        public string Eweight
        {
            get => eweight;
            set => eweight = value;
        }

        public Elaphant()
        {
        }

        public Elaphant(string speciesname, string eheight, string eweight)
        {
            this.speciesname = speciesname;
            this.eheight = eheight;
            this.eweight = eweight;
        }

        public void species()
        {
           Console.WriteLine(Speciesname+"\n");
        }

        public void trunk()
        {
            Console.WriteLine("- Trunk: Is used to tear up their food and then, place it in their mouth");
        }

        public void tusk()
        {
            Console.WriteLine("- Tusk: Used to dig for water, salt, and roots; to debark trees, to eat the bark; to dig into baobab trees to get at the pulp inside; and to move trees and branches when clearing a path");
        }

        public void teeth()
        {
            Console.WriteLine("- Teeth: They usually have 28 teeth");
        }

        public void skin()
        {
            Console.WriteLine("- Skin: It is extremely tough around most parts of its body and measures about 2.5 cm (1 in) thick ");
        }

        public void legsAndFeet()
        {
            Console.WriteLine("- Legs&Feet: They are great straight pillars, as they must be to support its bulk weight ");
        }

        public void Ears()
        {
            Console.WriteLine("- Ears: Elephant ears are made of a very thin layer of skin stretched over cartilage and a rich network of blood vessels \n");
        }

        public void diet()
        {
            Console.WriteLine("- Herbivores: Elephants are herbivores, spending 16 hours a day collecting plant food \n");
        }

        public void interval()
        {
            Console.WriteLine("- Interval: Females give birth at intervals of about every 5 years");
        }

        public void weight()
        {
            Console.WriteLine("- Weight: At birth, calves weigh around 90-115 kgs \n");
        }

        public void use()
        {
            Console.WriteLine("- Use: Elephants have been working animals used in various capacities by humans \n");
        }

        public void ShowInfo()
        {
            Console.WriteLine("Species: ");
            species();
            Console.WriteLine("\n" +
                              "Body Characteristics: ");
            trunk();
            tusk();
            teeth();
            skin();
            legsAndFeet();
            Ears();
            Console.WriteLine("\n" +
                              "Diet: ");
            diet();
            Console.WriteLine("\n" +
                              "Domestication: ");
            use();
        }
    }
}