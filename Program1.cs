using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Play game");
            Console.WriteLine("2. Exit");
            Console.Write("Please Select Menu :");
            ///สร้างลูป
            int select = 0;
            while (select == 0)
            {
                /////รับค่าจากคีบอร็ดถ้า1 = play game , 2 = exit
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    Console.WriteLine("Playgame");
                    Console.Write("Input letter alphabet :");
                    ///คำที่ใช้ในการRandom
                    string[] listwords = new string[3];
                    listwords[0] = "tennis";
                    listwords[1] = "football";
                    listwords[2] = "badminton";

                    ////random และใช้if else เพราะจะให้ใบ้จำนวน - ก่อน
                    Random randGen = new Random();
                    int resultRandom = randGen.Next(0, 2);
                    if (resultRandom == 0) {
                        Console.WriteLine("------");
                    } else if (resultRandom == 1) {
                        Console.WriteLine("--------");
                    } else if (resultRandom == 2) {
                        Console.WriteLine("---------");
                    
                    }
                    ///เวลาrandomเสร็จคำที่เลือกมา
                    string Word = listwords[resultRandom];
                    char[] guess = new char[Word.Length];

                    for (int i = 0; i < Word.Length; i++)
                        guess[i] = '-';

                    while (true)
                    {
                        int a = 0;
                        char playerGuess = char.Parse(Console.ReadLine());
                        for (int j = 0; j < Word.Length; j++)
                        {
                            if (playerGuess == Word[j])
                                guess[j] = playerGuess;
                            Console.WriteLine(guess);
                            while (a == 0)
                                
                                {
                                if (j == 0)
                                {
                                    a = a + 0;
                                    Console.WriteLine("correct Score: {0}", +a);
                                    break;
                                }
                                else if (j == 1)
                                {
                                    a = a + 1;
                                    Console.WriteLine("Incorrect Score: {0}", +a);
                                    break;
                                }

                                }
                        }

                    }
                        
                       
                        
                        
                  
                }
                else if (num == 2)
                {
                    Console.WriteLine("exit");
                    break;
                }


            }

        }
    }
}
