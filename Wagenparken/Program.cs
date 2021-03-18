using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wagenparken
{
    class Program
    {
        static void Main(string[] args)
        {
                
            AutoMerk Merk1 = new AutoMerk("Mercedes", "De beste duitse auto");
            AutoMerk Merk2 = new AutoMerk("Paugeot", "Het ergste auto");
            AutoMerk[] automerken = new AutoMerk[50];
            automerken[0] = Merk1;
            automerken[1] = Merk2;
            Auto Auto1 = new Auto(Merk1, "Model1", 2018, Auto.Brandstof.Diesel, Auto.Transmissie.Automaat, Auto.Kleuren.Grijs, 25000);
            Auto Auto2 = new Auto(Merk1, "Model2", 2019, Auto.Brandstof.Electrisch, Auto.Transmissie.Automaat, Auto.Kleuren.Blauw, 25000);
            Auto Auto3 = new Auto(Merk1, "Model3", 2020, Auto.Brandstof.Diesel, Auto.Transmissie.Handschakeld, Auto.Kleuren.Grijs, 25000);
            Auto Auto4 = new Auto(Merk1, "Model4", 2021, Auto.Brandstof.Benzine, Auto.Transmissie.Automaat, Auto.Kleuren.Groen, 17000);
            Auto Auto5 = new Auto(Merk1, "Model5", 2018, Auto.Brandstof.Diesel, Auto.Transmissie.Handschakeld, Auto.Kleuren.Grijs, 25000);
            Auto Auto6 = new Auto(Merk1, "Model6", 2019, Auto.Brandstof.Diesel, Auto.Transmissie.Automaat, Auto.Kleuren.Wit, 25000);
            Auto Auto7 = new Auto(Merk1, "Model7", 2012, Auto.Brandstof.Aardgas, Auto.Transmissie.Handschakeld, Auto.Kleuren.Grijs, 7000);
            Auto Auto8 = new Auto(Merk1, "Model8", 2015, Auto.Brandstof.Diesel, Auto.Transmissie.Automaat, Auto.Kleuren.Zwart, 22000);
            Auto Auto9 = new Auto(Merk1, "Model9", 2018, Auto.Brandstof.Diesel, Auto.Transmissie.Automaat, Auto.Kleuren.Grijs, 12000);
            Auto Auto10 = new Auto(Merk1, "Model10", 2010, Auto.Brandstof.Hybride, Auto.Transmissie.Handschakeld, Auto.Kleuren.Zwart, 6000);
            Auto Auto11 = new Auto(Merk1, "Model11", 2016, Auto.Brandstof.Diesel, Auto.Transmissie.Automaat, Auto.Kleuren.Grijs, 14000);
            Auto Auto12 = new Auto(Merk1, "Model12", 2011, Auto.Brandstof.Benzine, Auto.Transmissie.Automaat, Auto.Kleuren.Rood, 25000);
            Auto[] autostable1 = new Auto[50];
            autostable1[0] = Auto1;
            autostable1[1] = Auto2;
            autostable1[2] = Auto3;
            autostable1[3] = Auto4;
            Garage Garage1 = new Garage("Deurne", "Stationlaan 5", 50,autostable1);
            int lengte1 = 4;
            Auto[] autostable2 = new Auto[50];
            autostable2[0] = Auto5;
            autostable2[1] = Auto6;
            autostable2[2] = Auto7;
            autostable2[3] = Auto8;
            Garage Garage2 = new Garage("Schoten", "Vogelstraaat 32", 40,autostable2);
            int lengte2 = 4;
            Auto[] autostable3 = new Auto[50];
            autostable3[0] = Auto9;
            autostable3[1] = Auto10;
            autostable3[2] = Auto11;
            autostable3[3] = Auto12;
            Garage Garage3 = new Garage("Wilrijk", "Italialei 67", 20,autostable3);
            int lengte3 = 4;
            bool trug = false;
            do
            {
                trug = false;
                switch (SelectMenu(Garage1.naam + " : " + Garage1.adress, Garage2.naam + " : " + Garage2.adress, Garage3.naam + " : " + Garage3.adress))
                {
                    case 1:
                        switch (SelectMenu("Auto lijst", "Nieuwe auto invoeren", "Auto verwijdren", "Trug"))
                        {
                            case 1:
                                for (int i = 0; i < Garage1.autos.Length; i++)
                                    if(Garage1.autos[i]!=null)
                                    Console.WriteLine($"{Garage1.autos[i].merk.naam} - {Garage1.autos[i].model} - {Garage1.autos[i].bouwjaar.ToString()} - {Garage1.autos[i].brandstoftype.ToString()} - {Garage1.autos[i].transmissie.ToString()} - {Garage1.autos[i].kleur}.");
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.Write("Auto merk:\t");
                                string[] merken = new string[50]; int teller = 0;
                                merken[0] = "Nieuw merk";
                                for (int i = 1; i <= 50; i++)
                                {
                                    if (automerken[i - 1] != null)
                                    {
                                        merken[i] = "\"" + automerken[i - 1].naam + "\"";
                                        teller++;
                                    }
                                    else
                                        break;
                                }
                                string[] Merken = new string[teller+1];
                                for (int i = 0; i < teller+1; i++)
                                {
                                    Merken[i] = merken[i];
                                }
                                int index = SelectMenu(Merken) ;
                                AutoMerk nieuweAutomerk = new AutoMerk();
                                if (index == 1)
                                {
                                    Console.Write("Naam: ");
                                    string nieuwmerknaam = Console.ReadLine();
                                    Console.WriteLine("Uitleg: ");
                                    nieuweAutomerk = new AutoMerk(nieuwmerknaam, Console.ReadLine());
                                }
                                else
                                    nieuweAutomerk = automerken[index-2];
                                for (int i = 0; i < automerken.Length; i++)
                                {
                                    if (automerken[i]==null)
                                    {
                                        automerken[i] = nieuweAutomerk;
                                        break;
                                    }
                                }
                                Auto.Brandstof nieuwBrandstof = new Auto.Brandstof();
                                switch (SelectMenu("Diesel", "Benzine", "Electrisch", "Hybride", "Aardgas"))
                                {
                                    case 1:
                                        nieuwBrandstof = Auto.Brandstof.Diesel;
                                        break;
                                    case 2:
                                        nieuwBrandstof = Auto.Brandstof.Benzine;
                                        break;
                                    case 3:
                                        nieuwBrandstof = Auto.Brandstof.Electrisch;
                                        break;
                                    case 4:
                                        nieuwBrandstof = Auto.Brandstof.Hybride;
                                        break;
                                    case 5:
                                        nieuwBrandstof = Auto.Brandstof.Aardgas;
                                        break;
                                }
                                Auto.Transmissie nieuwTransmessie = new Auto.Transmissie();
                                switch (SelectMenu("Automaat", "Handschakeld"))
                                {
                                    case 1:
                                        nieuwTransmessie = Auto.Transmissie.Automaat;
                                        break;
                                    case 2:
                                        nieuwTransmessie = Auto.Transmissie.Handschakeld;
                                        break;
                                }
                                Auto.Kleuren nieuwKleur = new Auto.Kleuren();
                                switch (SelectMenu("Wit", "Groen", "Bruin", "Zwart", "Grijs", "Rood", "Blauw"))
                                {
                                    case 1:
                                        nieuwKleur = Auto.Kleuren.Wit;
                                        break;
                                    case 2:
                                        nieuwKleur = Auto.Kleuren.Groen;
                                        break;
                                    case 3:
                                        nieuwKleur = Auto.Kleuren.Bruin;
                                        break;
                                    case 4:
                                        nieuwKleur = Auto.Kleuren.Zwart;
                                        break;
                                    case 5:
                                        nieuwKleur = Auto.Kleuren.Grijs;
                                        break;
                                    case 6:
                                        nieuwKleur = Auto.Kleuren.Rood;
                                        break;
                                    case 7:
                                        nieuwKleur = Auto.Kleuren.Blauw;
                                        break;
                                }
                                Console.Write("Model: ");
                                string nieuwModel = Console.ReadLine();
                                Console.WriteLine("Bouwjaar: ");
                                int nieuwBouwjaar = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Prijs: ");
                                double nieuwPrijs = Convert.ToDouble(Console.ReadLine());
                                Auto NieuweAuto = new Auto(nieuweAutomerk, nieuwModel, nieuwBouwjaar, nieuwBrandstof, nieuwTransmessie, nieuwKleur, nieuwPrijs);
                                Garage1.autos[lengte1] = NieuweAuto;
                                lengte1++;
                                break;
                            case 3:
                                string[] autos = new string[110]; int autosteller = 0;
                                for (int i = 0; i < 110; i++)
                                {
                                    if (Garage1.autos[i] != null)
                                    {
                                        autos[i] = "\"" + $"{Garage1.autos[i].merk.naam} - {Garage1.autos[i].model} - {Garage1.autos[i].bouwjaar.ToString()} - {Garage1.autos[i].brandstoftype.ToString()} - {Garage1.autos[i].transmissie.ToString()} - {Garage1.autos[i].kleur}." + "\"";
                                        autosteller++;
                                    }
                                    else
                                        break;
                                }
                                string[] aautos = new string[autosteller+1];
                                for (int i = 0; i < autosteller+1; i++)
                                {
                                    aautos[i] = autos[i];
                                }
                                Garage1.autos[SelectMenu(aautos) - 1] = Garage1.autos[autosteller - 1];
                                Garage1.autos[autosteller - 1] = null;
                                lengte1--;
                                break;
                            case 4:
                                trug = true;
                                break;

                        }
                        break;
                    case 2:
                        switch (SelectMenu("Auto lijst", "Nieuwe auto invoeren", "Auto verwijdren", "Trug"))
                        {
                            case 1:
                                for (int i = 0; i < Garage2.autos.Length; i++)
                                    if (Garage2.autos[i] != null)
                                        Console.WriteLine($"{Garage2.autos[i].merk.naam} - {Garage2.autos[i].model} - {Garage2.autos[i].bouwjaar.ToString()} - {Garage2.autos[i].brandstoftype.ToString()} - {Garage2.autos[i].transmissie.ToString()} - {Garage2.autos[i].kleur}.");
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.Write("Auto merk:\t");
                                string[] merken = new string[50]; int teller = 0;
                                merken[0] = "Nieuw merk";
                                for (int i = 1; i <= 50; i++)
                                {
                                    if (automerken[i - 1] != null)
                                    {
                                        merken[i] = "\"" + automerken[i - 1].naam + "\"";
                                        teller++;
                                    }
                                    else
                                        break;
                                }
                                string[] Merken = new string[teller + 1];
                                for (int i = 0; i < teller + 1; i++)
                                {
                                    Merken[i] = merken[i];
                                }
                                int index = SelectMenu(Merken) ;
                                AutoMerk nieuweAutomerk = new AutoMerk();
                                if (index == 1)
                                {
                                    Console.Write("Naam: ");
                                    string nieuwmerknaam = Console.ReadLine();
                                    Console.WriteLine("Uitleg: ");
                                    nieuweAutomerk = new AutoMerk(nieuwmerknaam, Console.ReadLine());
                                }
                                else
                                    nieuweAutomerk = automerken[index-2];
                                for (int i = 0; i < automerken.Length; i++)
                                {
                                    if (automerken[i] == null)
                                    {
                                        automerken[i] = nieuweAutomerk;
                                        break;
                                    }
                                }
                                Auto.Brandstof nieuwBrandstof = new Auto.Brandstof();
                                switch (SelectMenu("Diesel", "Benzine", "Electrisch", "Hybride", "Aardgas"))
                                {
                                    case 1:
                                        nieuwBrandstof = Auto.Brandstof.Diesel;
                                        break;
                                    case 2:
                                        nieuwBrandstof = Auto.Brandstof.Benzine;
                                        break;
                                    case 3:
                                        nieuwBrandstof = Auto.Brandstof.Electrisch;
                                        break;
                                    case 4:
                                        nieuwBrandstof = Auto.Brandstof.Hybride;
                                        break;
                                    case 5:
                                        nieuwBrandstof = Auto.Brandstof.Aardgas;
                                        break;
                                }
                                Auto.Transmissie nieuwTransmessie = new Auto.Transmissie();
                                switch (SelectMenu("Automaat", "Handschakeld"))
                                {
                                    case 1:
                                        nieuwTransmessie = Auto.Transmissie.Automaat;
                                        break;
                                    case 2:
                                        nieuwTransmessie = Auto.Transmissie.Handschakeld;
                                        break;
                                }
                                Auto.Kleuren nieuwKleur = new Auto.Kleuren();
                                switch (SelectMenu("Wit", "Groen", "Bruin", "Zwart", "Grijs", "Rood", "Blauw"))
                                {
                                    case 1:
                                        nieuwKleur = Auto.Kleuren.Wit;
                                        break;
                                    case 2:
                                        nieuwKleur = Auto.Kleuren.Groen;
                                        break;
                                    case 3:
                                        nieuwKleur = Auto.Kleuren.Bruin;
                                        break;
                                    case 4:
                                        nieuwKleur = Auto.Kleuren.Zwart;
                                        break;
                                    case 5:
                                        nieuwKleur = Auto.Kleuren.Grijs;
                                        break;
                                    case 6:
                                        nieuwKleur = Auto.Kleuren.Rood;
                                        break;
                                    case 7:
                                        nieuwKleur = Auto.Kleuren.Blauw;
                                        break;
                                }
                                Console.Write("Model: ");
                                string nieuwModel = Console.ReadLine();
                                Console.WriteLine("Bouwjaar: ");
                                int nieuwBouwjaar = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Prijs: ");
                                double nieuwPrijs = Convert.ToDouble(Console.ReadLine());
                                Auto NieuweAuto = new Auto(nieuweAutomerk, nieuwModel, nieuwBouwjaar, nieuwBrandstof, nieuwTransmessie, nieuwKleur, nieuwPrijs);
                                Garage2.autos[lengte2] = NieuweAuto;
                                lengte2++;
                                break;
                            case 3:
                                string[] autos = new string[110]; int autosteller = 0;
                                for (int i = 0; i < 110; i++)
                                {
                                    if (Garage2.autos[i] != null)
                                    {
                                        autos[i] = "\"" + $"{Garage2.autos[i].merk.naam} - {Garage2.autos[i].model} - {Garage2.autos[i].bouwjaar.ToString()} - {Garage2.autos[i].brandstoftype.ToString()} - {Garage2.autos[i].transmissie.ToString()} - {Garage2.autos[i].kleur}." + "\"";
                                        autosteller++;
                                    }
                                    else
                                        break;
                                }
                                string[] aautos = new string[autosteller + 1];
                                for (int i = 0; i < autosteller + 1; i++)
                                {
                                    aautos[i] = autos[i];
                                }
                                Garage2.autos[SelectMenu(aautos) - 1] = Garage2.autos[autosteller - 1];
                                Garage2.autos[autosteller - 1] = null;
                                lengte2--;
                                break;
                            case 4:
                                trug = true;
                                break;

                        }
                        break;
                    case 3:
                        switch (SelectMenu("Auto lijst", "Nieuwe auto invoeren", "Auto verwijdren", "Trug"))
                        {
                            case 1:
                                for (int i = 0; i < Garage3.autos.Length; i++)
                                    if (Garage3.autos[i] != null)
                                        Console.WriteLine($"{Garage3.autos[i].merk.naam} - {Garage3.autos[i].model} - {Garage3.autos[i].bouwjaar.ToString()} - {Garage3.autos[i].brandstoftype.ToString()} - {Garage3.autos[i].transmissie.ToString()} - {Garage3.autos[i].kleur}.");
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.Write("Auto merk:\t");
                                string[] merken = new string[50]; int teller = 0;
                                merken[0] = "Nieuw merk";
                                for (int i = 1; i <= 50; i++)
                                {
                                    if (automerken[i - 1] != null)
                                    {
                                        merken[i] = "\"" + automerken[i - 1].naam + "\"";
                                        teller++;
                                    }
                                    else
                                        break;
                                }
                                string[] Merken = new string[teller + 1];
                                for (int i = 0; i < teller + 1; i++)
                                {
                                    Merken[i] = merken[i];
                                }
                                int index = SelectMenu(Merken) ;
                                AutoMerk nieuweAutomerk = new AutoMerk();
                                if (index == 1)
                                {
                                    Console.Write("Naam: ");
                                    string nieuwmerknaam = Console.ReadLine();
                                    Console.WriteLine("Uitleg: ");
                                    nieuweAutomerk = new AutoMerk(nieuwmerknaam, Console.ReadLine());
                                }
                                else
                                    nieuweAutomerk = automerken[index-2];
                                for (int i = 0; i < automerken.Length; i++)
                                {
                                    if (automerken[i] == null)
                                    {
                                        automerken[i] = nieuweAutomerk;
                                        break;
                                    }
                                }
                                Auto.Brandstof nieuwBrandstof = new Auto.Brandstof();
                                switch (SelectMenu("Diesel", "Benzine", "Electrisch", "Hybride", "Aardgas"))
                                {
                                    case 1:
                                        nieuwBrandstof = Auto.Brandstof.Diesel;
                                        break;
                                    case 2:
                                        nieuwBrandstof = Auto.Brandstof.Benzine;
                                        break;
                                    case 3:
                                        nieuwBrandstof = Auto.Brandstof.Electrisch;
                                        break;
                                    case 4:
                                        nieuwBrandstof = Auto.Brandstof.Hybride;
                                        break;
                                    case 5:
                                        nieuwBrandstof = Auto.Brandstof.Aardgas;
                                        break;
                                }
                                Auto.Transmissie nieuwTransmessie = new Auto.Transmissie();
                                switch (SelectMenu("Automaat", "Handschakeld"))
                                {
                                    case 1:
                                        nieuwTransmessie = Auto.Transmissie.Automaat;
                                        break;
                                    case 2:
                                        nieuwTransmessie = Auto.Transmissie.Handschakeld;
                                        break;
                                }
                                Auto.Kleuren nieuwKleur = new Auto.Kleuren();
                                switch (SelectMenu("Wit", "Groen", "Bruin", "Zwart", "Grijs", "Rood", "Blauw"))
                                {
                                    case 1:
                                        nieuwKleur = Auto.Kleuren.Wit;
                                        break;
                                    case 2:
                                        nieuwKleur = Auto.Kleuren.Groen;
                                        break;
                                    case 3:
                                        nieuwKleur = Auto.Kleuren.Bruin;
                                        break;
                                    case 4:
                                        nieuwKleur = Auto.Kleuren.Zwart;
                                        break;
                                    case 5:
                                        nieuwKleur = Auto.Kleuren.Grijs;
                                        break;
                                    case 6:
                                        nieuwKleur = Auto.Kleuren.Rood;
                                        break;
                                    case 7:
                                        nieuwKleur = Auto.Kleuren.Blauw;
                                        break;
                                }
                                Console.Write("Model: ");
                                string nieuwModel = Console.ReadLine();
                                Console.WriteLine("Bouwjaar: ");
                                int nieuwBouwjaar = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Prijs: ");
                                double nieuwPrijs = Convert.ToDouble(Console.ReadLine());
                                Auto NieuweAuto = new Auto(nieuweAutomerk, nieuwModel, nieuwBouwjaar, nieuwBrandstof, nieuwTransmessie, nieuwKleur, nieuwPrijs);
                                Garage3.autos[lengte3] = NieuweAuto;
                                lengte3++;
                                break;
                            case 3:
                                string[] autos = new string[110]; int autosteller = 0;
                                for (int i = 0; i < 110; i++)
                                {
                                    if (Garage3.autos[i] != null)
                                    {
                                        autos[i] = "\"" + $"{Garage3.autos[i].merk.naam} - {Garage3.autos[i].model} - {Garage3.autos[i].bouwjaar.ToString()} - {Garage3.autos[i].brandstoftype.ToString()} - {Garage3.autos[i].transmissie.ToString()} - {Garage3.autos[i].kleur}." + "\"";
                                        autosteller++;
                                    }
                                    else
                                        break;
                                }
                                Garage3.autos[SelectMenu(autos) - 1] = Garage3.autos[autosteller - 1];
                                Garage3.autos[autosteller - 1] = null;
                                lengte3--;
                                break;
                            case 4:
                                trug = true;
                                break;

                        }
                        break;
                }
            } while (trug);
            Console.ReadLine();
        }
        static int SelectMenu(params string[] menu)
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Console.Clear();

            int selection = 1;
            bool selected = false;
            ConsoleColor selectionForeground = Console.BackgroundColor;
            ConsoleColor selectionBackground = Console.ForegroundColor;

            while (!selected)
            {
                for (int i = 0; i < menu.Length; i++)
                {
                    if (selection == i + 1)
                    {
                        Console.ForegroundColor = selectionForeground;
                        Console.BackgroundColor = selectionBackground;
                    }
                    Console.WriteLine((i + 1) + ": " + menu[i]);
                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selection--;
                        break;
                    case ConsoleKey.DownArrow:
                        selection++;
                        break;
                    case ConsoleKey.Enter:
                        selected = true;
                        break;
                }

                selection = Math.Min(Math.Max(selection, 1), menu.Length);
                Console.SetCursorPosition(0, 0);
            }

            Console.Clear();
            Console.CursorVisible = true;

            return selection;
        }
    }
}
