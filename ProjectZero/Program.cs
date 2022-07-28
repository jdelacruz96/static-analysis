﻿using System;

namespace ProjectZero{

    class Program{

        static async Task Main(string[] args) 
        {   
            DotNetEnv.Env.Load(); //Loading env file
            NewsDriver nd = new NewsDriver();

            var key = Environment.GetEnvironmentVariable("SECRET_KEY")!;//loading key
            
            char choice = ' ';

            do{
                Console.Clear();

                Generic.printMenu();//print menu
                choice = Generic.getChar();//gets character from user

                switch(choice){
                    case '1':
                        NewsDriver.getTopNews((string) key);
                        break;
                    case '2':
                        NewsDriver.searchNews((string) key);
                        break;
                    case '3':
                        await nd.detailedSearch();
                        break;
                    case 'X':
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nPlease enter a valid choice.\nPress enter to continue...");
                        Console.ReadLine();
                        break;
                }

            }while(choice != 'X');



            return;

        }//end Main

    }// end Program

}// end namepsace