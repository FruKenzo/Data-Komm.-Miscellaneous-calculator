using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//Julian d07 24-09-2025

namespace Ekstra_opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definerer variabler
            string gentagSvar;
            string udregnerValg;
            bool validUdregner = true;

            int antalGennemsnitTal;
            int gennemsnitIndex;
            double gennemsnitTal;
            double gennemsnitSum = 0;

            double arimUdregnerTal1;
            double arimUdregnerTal2;
            double sumUdregnerTotal;
            double forskelUdregnerTotal;
            double produktUdregnerTotal;
            double kvotientUdregnerTotal;

            int antalTimer;
            int antalMinutter;
            int tidSum;

            double originalRabatTal;
            double rabatProcent;
            double rabatMængde;
            double rabatTotal;

            //double[] gennemsnitArray = new double[];

            //Kører programmet mindst en gang, og gentager igen hvis man svarer ja til at man vil prøve igen
            do
            {
                //Kører mindst en gang, og kører igen hvis man ikke indtaster et godkendt svar
                do
                {
                    //Clearer skærmen for tekst og farver
                    Console.Clear();

                    //Spørger om hvilken udregner man gerne vil bruge og udskriver muligheder
                    //Header
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Hvilken udregner vil du bruge?\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    //Muligheder
                    Console.WriteLine($"1. Gennemsnits udregner");
                    Console.WriteLine("2. Arimetisk udregning mellem to tal");
                    Console.WriteLine("3. Time til minutter udregner");
                    Console.WriteLine("4. Rabat udregner");
                    //Beder om input 
                    Console.WriteLine("\nIndtast tallet på den udregner du gerne vil bruge");
                    udregnerValg = Console.ReadLine();

                    //Aflæser input og skifter til den passende udregner
                    switch (udregnerValg)
                    {
                        //Gennemsnits udregner
                        case ("1"):
                            {
                                //Clearer skærmen for tekst og farver og sikrer sig at man har valgt en godkendt mulighed
                                Console.Clear();
                                validUdregner = true;

                                //Header
                                Console.BackgroundColor = ConsoleColor.DarkCyan;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Gennemsnits udregner\n");
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Gray;

                                //Beder brugeren om at indtaste hvor mange tal de vil finde gennemsnit på og aflæser input
                                Console.Write("Hvor mange tal vil du finde gennemsnittet af? ");
                                antalGennemsnitTal = int.Parse(Console.ReadLine());

                                //Tom række til formatering
                                Console.WriteLine("");

                                //Beder brugeren om at indtaste deres tal indtil array er fyldt
                                for (gennemsnitIndex = 0; gennemsnitIndex < antalGennemsnitTal; gennemsnitIndex++)
                                {
                                    Console.Write("Indtast dit tal: ");
                                    gennemsnitTal = Convert.ToDouble(Console.ReadLine());
                                    gennemsnitSum = gennemsnitSum + gennemsnitTal;
                                }

                                //Finder gennemsnit
                                gennemsnitSum = gennemsnitSum / antalGennemsnitTal;

                                //Udskriver til skærm
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nDit gennemsnit er: {gennemsnitSum:N2}");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            }
                        //Udregner hvor bruger indtaster 2 tal som udregner og udskriver: Sum, forskel, produkt og kvotient
                        case ("2"):
                            {
                                //Clearer skærmen for tekst og farver og sikrer sig at man har valgt en godkendt mulighed
                                Console.Clear();
                                validUdregner = true;

                                //Header
                                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Arimetisk udregning mellem to tal\n");
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Gray;

                                //Beder brugeren om at indtaste to tal og aflæser input
                                Console.Write("Indtast dit første tal: ");
                                arimUdregnerTal1 = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Indtast dit andet tal:  ");
                                arimUdregnerTal2 = Convert.ToDouble(Console.ReadLine());

                                //Udregner sum
                                sumUdregnerTotal = arimUdregnerTal1 + arimUdregnerTal2;
                                //Udregner forskel
                                forskelUdregnerTotal = arimUdregnerTal1 - arimUdregnerTal2;
                                //Udregner produkt
                                produktUdregnerTotal = arimUdregnerTal1 * arimUdregnerTal2;
                                //Udregner kvovient
                                kvotientUdregnerTotal = arimUdregnerTal1 / arimUdregnerTal2;

                                //Udskriver svar til skærm
                                Console.Write("\n+");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{sumUdregnerTotal,10:N2}");
                                Console.ForegroundColor = ConsoleColor.Gray;

                                Console.Write("-");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"{forskelUdregnerTotal,10:N2}");
                                Console.ForegroundColor = ConsoleColor.Gray;

                                Console.Write("\n*");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{produktUdregnerTotal,10:N2}");
                                Console.ForegroundColor = ConsoleColor.Gray;

                                Console.Write("/");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"{kvotientUdregnerTotal,10:N2}\n");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            }
                        //Bruger indtaster et tal i henholdsvis timer og minutter og
                        //programmet udskriver hvad der er indtastet samt hvad det er i minutter. 
                        case ("3"):
                            {
                                //Clearer skærmen for tekst og farver og sikrer sig at man har valgt en godkendt mulighed
                                Console.Clear();
                                validUdregner = true;

                                //Header
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Time til minutter udregner\n");
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Gray;

                                //Beder brugeren om at indtaste antal timer og minutter og aflæser input
                                Console.Write("Hvor mange timer har du? Indtast et helt tal:     ");
                                antalTimer = int.Parse(Console.ReadLine());
                                Console.Write("Hvor mange minutter har du? Indtast et helt tal:  ");
                                antalMinutter = int.Parse(Console.ReadLine());

                                //Udregner timer til minutter og udregner totaltid
                                tidSum = (antalTimer * 60) + antalMinutter;

                                //Udskriver til skærm
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nDu har {tidSum} minutter");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            }
                        //Rabat udregner
                        case ("4"):
                            {
                                //Clearer skærmen for tekst og farver og sikrer sig at man har valgt en godkendt mulighed
                                Console.Clear();
                                validUdregner = true;

                                //Header
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("Rabat udregner\n");
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Gray;

                                //Beder brugeren om at indtaste et tal og hvor meget rabat de vil udregne på det
                                Console.Write("Indtast et tal du vil udregne rabat på: ");
                                originalRabatTal = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Indtast hvor meget rabat dit tal har:   ");
                                rabatProcent = Convert.ToDouble(Console.ReadLine());

                                //Udregner rabat
                                rabatMængde = (originalRabatTal / 100) * rabatProcent;
                                rabatTotal = originalRabatTal - rabatMængde;

                                //Udskriver til skærm
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nDet giver {rabatTotal:N2}, hvilket sparer dig {rabatMængde:N2} i rabat");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            }
                        //Sikrer at man kan prøve igen hvis man indtaster et tal der ikke er godkendt
                        default:
                            {
                                //Sætter denne bool til false så løkken kører igen
                                validUdregner = false;
                                //Giver brugeren besked hvis input ikke er godkendt og afventer tastetryk
                                Console.WriteLine("\nDette er ikke en mulighed, indtast venligt et tal fra listen");
                                Console.Write("Tryk på en tast for at gå videre");
                                Console.ReadKey();
                                break;
                            }
                    }
                }
                while (validUdregner == false);

                //Spørger om man vil prøve igen og aflæser input
                Console.WriteLine("\nVil du køre programmet igen?");
                gentagSvar = Console.ReadLine();
            }
            while (gentagSvar.ToLower() == "ja");
        }
    }
}