using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Alight.Mew.Sparschwein.Test
{

    class Program
    {
        public static List<moneyBox> moneyBoxes = new List<moneyBox>();

        /*public moneyBox this[int index]
        {
            get
            {
                return moneyBoxes[index];
            }
            set
            {
                moneyBoxes[index] = value;
            }
        }*/

        public static void AddmoneyBox()
        {
            Console.Clear();
            moneyBox myMoneyBox = new moneyBox();
            Console.WriteLine("Nennen Sie den Namen Ihres neuen Sparschweins:");
            myMoneyBox.Name = Console.ReadLine();
            moneyBoxes.Add(myMoneyBox);
        }   

        
        
        public static void DepositMoney(int index)
        {
            Console.Clear();
            Console.WriteLine("Bitte geben Sie an wie viele einzelne Cent und Euro Stücke sie einzahlen möchten:");
            Console.WriteLine("\n");
            Console.WriteLine("Wie viele ein Cent Münzen möchten Sie einzahlen?");
            moneyBoxes[index].OneCent += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie viele zwei Cent Münzen möchten Sie einzahlen?");
            moneyBoxes[index].TwoCent += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie viele fünf Cent Münzen möchten Sie einzahlen?");
            moneyBoxes[index].FiveCent += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie viele zehn Cent Münzen möchten Sie einzahlen?");
            moneyBoxes[index].TenCent += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie viele zwanzig Cent Münzen möchten Sie einzahlen?");
            moneyBoxes[index].TwentyCent += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie viele fünfzig Cent Münzen möchten Sie einzahlen?");
            moneyBoxes[index].FifftyCent += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie viele ein Euro Münzen möchten Sie einzahlen?");
            moneyBoxes[index].OneEuro += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie viele zwei Euro Münzen möchten Sie einzahlen?");
            moneyBoxes[index].TwoEuro += Convert.ToInt32(Console.ReadLine());
             
            
        }

        public static void WithdrawMoney(int index)
        {
            Console.Clear();

            int withdrawTwoEuro, withdrawOneEuro, withdrawOneCent, withdrawTwoCent, withdrawFiveCent, withdrawTenCent, withdrawTwentyCent, withdrawFifftyCent;

            Console.WriteLine("Bitte geben Sie an wie viel Euro und wie viel Cent Sie abheben möchten.");
            Console.WriteLine("\n");
            Console.WriteLine("Abzuhebender Euro-Betrag:");
            int withdrawEuro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Abzuhebender Cent-Betrag:");
            int withdrawCent = Convert.ToInt32(Console.ReadLine());
            int withdraw = withdrawCent + (withdrawEuro * 100);

            if (withdraw != 0)
            {
                if (moneyBoxes[index].TwoEuro >= (withdraw / 200))
                {
                    withdrawTwoEuro = withdraw / 200; 
                    withdraw = withdraw % 200;
                    moneyBoxes[index].TwoEuro -= withdrawTwoEuro;
                }

                if (moneyBoxes[index].OneEuro >= (withdraw / 100))
                {
                    withdrawOneEuro = withdraw / 100;
                    withdraw = withdraw % 100;
                    moneyBoxes[index].OneEuro -= withdrawOneEuro;
                }

                if (moneyBoxes[index].FifftyCent >= (withdraw / 50))
                {
                    withdrawFifftyCent = withdraw / 50;
                    withdraw = withdraw % 50;
                    moneyBoxes[index].FifftyCent -= withdrawFifftyCent;
                }

                if (moneyBoxes[index].TwentyCent >= (withdraw / 20))
                {
                    withdrawTwentyCent = withdraw / 20;
                    withdraw = withdraw % 20;
                    moneyBoxes[index].TwentyCent -= withdrawTwentyCent;
                }

                if (moneyBoxes[index].TenCent >= (withdraw / 10))
                {
                    withdrawTenCent = withdraw / 10;
                    withdraw = withdraw % 10;
                    moneyBoxes[index].TenCent -= withdrawTenCent;
                }

                if (moneyBoxes[index].FiveCent >= (withdraw / 5))
                {
                    withdrawFiveCent = withdraw / 5;
                    withdraw = withdraw % 5;
                    moneyBoxes[index].FiveCent -= withdrawFiveCent;
                }
                
                if (moneyBoxes[index].TwoCent >= (withdraw / 2))
                {
                    withdrawTwoCent = withdraw / 2;
                    withdraw = withdraw % 2;
                    moneyBoxes[index].TwoCent -= withdrawTwoCent;
                }

                if (moneyBoxes[index].OneCent >= (withdraw / 1))
                {
                    withdrawOneCent = withdraw / 1;
                    withdraw = withdraw % 1;
                    moneyBoxes[index].OneCent -= withdrawOneCent;
                }

                else
                {
                    Console.WriteLine("Die von Ihnen gewünschte Auszahlung ist nicht möglich, da Sie zu wenig Geld in Ihrem Sparschwein haben.");
                    Console.WriteLine("Bitte drücken Sie eine beliebige Taste um ins Hauptmenü zurück zu gelangen.");
                    Console.ReadKey();
                    return;
                }

                return;
            }

            else
            {
                Console.WriteLine("Sie haben keinen Auszahlungsbetrag angegeben.");
                Console.WriteLine("Bitte drücken Sie eine beliebige Taste um ins Hauptmenü zurück zu gelangen.");
                return;
            }
        }

        public static void PrintMoneyBoxesContent (int index)
        {
            

            Console.Clear();
            Console.WriteLine("Sparschwein von:");
            Console.WriteLine(moneyBoxes[index].Name);
            Console.WriteLine("Ein Cent Münzen:");
            Console.WriteLine(moneyBoxes[index].OneCent);
            Console.WriteLine("Zwei Cent Münzen:");
            Console.WriteLine(moneyBoxes[index].TwoCent);
            Console.WriteLine("Fünf Cent Münzen:");
            Console.WriteLine(moneyBoxes[index].FiveCent);
            Console.WriteLine("Zehn Cent Münzen:");
            Console.WriteLine(moneyBoxes[index].TenCent);
            Console.WriteLine("Zwanzig Cent Münzen:");
            Console.WriteLine(moneyBoxes[index].TwentyCent);
            Console.WriteLine("Fünfzig Cent Münzen:");
            Console.WriteLine(moneyBoxes[index].FifftyCent);
            Console.WriteLine("ein Euro Münzen:");
            Console.WriteLine(moneyBoxes[index].OneEuro);
            Console.WriteLine("Zwei Euro Münzen:"); 
            Console.WriteLine(moneyBoxes[index].TwoEuro);
            Console.WriteLine("************************");

            moneyBoxes[index].SumEuro = moneyBoxes[index].OneEuro + moneyBoxes[index].TwoEuro * 2;
            moneyBoxes[index].SumCent = moneyBoxes[index].OneCent + moneyBoxes[index].TwoCent * 2 + moneyBoxes[index].FiveCent * 5 + moneyBoxes[index].TenCent * 10 + moneyBoxes[index].TwentyCent * 20 + moneyBoxes[index].FifftyCent * 50;

            moneyBoxes[index].SumEuro += moneyBoxes[index].SumCent / 100;
            moneyBoxes[index].SumCent = moneyBoxes[index].SumCent % 100;

            Console.WriteLine("Der Inhalt Ihres Sparschweins beträgt: " + moneyBoxes[index].SumEuro + "," + moneyBoxes[index].SumCent + " EUR");

            Console.WriteLine("Bitte drücken Sie eine beliebige Taste um ins Hauptmenü zurück zu gelangen.");
            Console.ReadKey();
            return;
        }

        public static void PrintMoneyBoxesIndex (moneyBox myMoneyBox)
        {
            Console.Clear();

            

            if (moneyBoxes.Count == 1)
            {
                Console.WriteLine("Sparschwein mit dem Index 0: " + moneyBoxes[0].Name);
            }
            else if (moneyBoxes.Count == 2)
            {
                Console.WriteLine("Sparschwein mit dem Index 0: " + moneyBoxes[0].Name);
                Console.WriteLine("Sparschwein mit dem Index 1: " + moneyBoxes[1].Name);
            }
            else
            {
                Console.WriteLine("Sparschwein mit dem Index 0: " + moneyBoxes[0].Name);
                Console.WriteLine("Sparschwein mit dem Index 1: " + moneyBoxes[1].Name);
                Console.WriteLine("Sparschwein mit dem Index 2: " + moneyBoxes[2].Name);
            }
        }
        
        public static void ListOfMoneyBoxes()
        {

            string resultFromJson = File.ReadAllText(@"PiggyBank.json");
            moneyBoxes = JsonConvert.DeserializeObject<List<moneyBox>>(resultFromJson);


            if (moneyBoxes.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Es ist noch kein Sparschwein vorhanden. Bitte legen Sie zuerst ein neues Sparschwein an.");
                Console.WriteLine("Drücken Sie eine beliebige Taste um ins Hauptmenü zurück zu gelangen.");
                Console.ReadKey();
                return;
            }

            else
            {
                

                foreach (var myMoneyBox in moneyBoxes)
                {
                    PrintMoneyBoxesIndex(myMoneyBox);
                }

            }
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("\n");
            Console.WriteLine("Bitte geben Sie den Index Ihres Sparschweins ein um Ein- und Auszuahlungen vorzunehmen:");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte bestätigen Sie Ihre Eingabe mit Enter.");

            string command = "";
            while (command != "return")
            {
                Console.Clear();
                Console.WriteLine("WILLKOMMEN ZU IHREM PERSÖNLICHEN DIGITALEN SPARSCHWEIN");
                Console.WriteLine("******************************************************");
                Console.WriteLine("\n");
                Console.WriteLine("Zahlen Sie Geld in Ihr Sparschwein ein:                                            (+)");
                Console.WriteLine("Heben Sie Geld von Ihrem Sparschwein ab:                                           (-)");
                Console.WriteLine("Inhalt Ihres Sparschweins:                                                         (i)");
                Console.WriteLine("\n");
                Console.WriteLine("Um ins Hauptmenü zurück zu gelangen geben Sie bitte 'return' ein.");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "+":
                        DepositMoney(index);
                        break;
                    case "-":
                        WithdrawMoney(index);
                        break;
                    case "i":
                        PrintMoneyBoxesContent(index);
                        break;
                }
            }
        } 

                
        
        static void Main(string[] args)
        {
            string command = "";
            while(command != "exit")
            {
                Console.Clear();
                Console.WriteLine("WILLKOMMEN ZUM DIGITALEN SPARSCHWEIN");
                Console.WriteLine("************************************");
                Console.WriteLine("\n");
                Console.WriteLine("Erstellen Sie ein neues Sparschwein und nehmen Sie Einzahlungen oder Auszahlungen vor:");
                Console.WriteLine("\n");
                Console.WriteLine("Erstellen eines neuen Sparschweins:                                                (e)");
                Console.WriteLine("______________________________________________________________________________________");
                Console.WriteLine("Vorhandene Sparschweine mit der Möglichkeit Ein- oder Auszahlungen vorzunehmen:    (s)");
                Console.WriteLine("______________________________________________________________________________________");
                Console.WriteLine("\n");
                Console.WriteLine("Um das Programm zu schließen geben Sie bitte 'exit' ein.");
                command = Console.ReadLine().ToLower();
                switch(command)
                {
                    case "e":
                        AddmoneyBox();
                        break;
                    case "s":
                        ListOfMoneyBoxes();
                        break;
                }

                string ResultToJson = JsonConvert.SerializeObject(moneyBoxes);
                File.WriteAllText(@"PiggyBank.json", ResultToJson);
            }
        }
    }
}
