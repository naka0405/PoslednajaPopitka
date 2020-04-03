using System;
using System.Collections.Generic;

namespace Poslednjaja_popytka
{
    public class Program
    {
       

        public static void Main(string[] args)
        {
            var numberOfAttempts = 100;

            var fruitBasket = new FruitBasket();
            fruitBasket.PrintInfo();


            var playerList = new List<BasePlayer>()
            {
                new UsualPlayer(),
                new NotepadPlayer(),
                new UberPlayer(),
                new CheaterPlayer(),
                new UberCheaterPlayer()
            };


            bool notGuess = true;

            for (int i = 0; notGuess==true && i < numberOfAttempts - playerList.Count - 1 ; i += playerList.Count)
            {
                for (int j = 0; j < playerList.Count; j++)
                {
                    int startRandom = (j + i) * 3;
                    playerList[j].Guess = playerList[j].GuessNumber(startRandom);
                    var currentPlayer = new ProcessGuessing(playerList[j], playerList[j].Guess);
                    ProcessGuessing.allPlayersAndGuessings.Add(currentPlayer);
                    bool win = playerList[j].CheckGuessedNumbers(playerList[j].Guess);
                    Console.WriteLine(win);
                    int num = j + i+1;
                    playerList[j].PrintInfo(playerList[j].Guess,num);

                    if (win != false)
                    {
                        //Console.WriteLine(playerList[j].ToString(), playerList[j].Guess);
                        playerList[j].PrintInfo1();
                        notGuess = false;
                        break;
                    }                  

                }
                Console.WriteLine("======================================");
            }

            if(notGuess==true)
            {
                //Console.WriteLine($"The winner: {SearchWinner()}");
                SearchWinner();
                
            }
            


            //Console.ReadKey();
        }
        public static void SearchWinner()
        {
            //ProcessGuessing searchWinner = allPlayersAndGuessings[0];         

            //int min = Math.Abs(FruitBasket.Weight - allPlayersAndGuessings[0].Weight);
            bool IsGuessed = false;
            for (int r=1; r<5;r++)
            {

            
            for (int i = 0; IsGuessed==false && i < ProcessGuessing.allPlayersAndGuessings.Count; i++)//min>1 &&
                {
                    //if (min > Math.Abs(FruitBasket.Weight - allPlayersAndGuessings[i].Weight))
                    //{
                    //    min = Math.Abs(FruitBasket.Weight - allPlayersAndGuessings[i].Weight);
                    //    searchWinner = allPlayersAndGuessings[i]; 
                    //}
                    //if (min == 1)
                    //{
                    //    
                    //    break;
                    //}
                    int nearBasketWidth1 = FruitBasket.Weight + r;
                    int nearBasketWidth2 = FruitBasket.Weight - r;
                    if (nearBasketWidth1==ProcessGuessing.allPlayersAndGuessings[i].Weight||nearBasketWidth2== ProcessGuessing.allPlayersAndGuessings[i].Weight )
                    {
                        ProcessGuessing.allPlayersAndGuessings[i].PrintInfo2();                       
                        IsGuessed = true;
                        break;
                    }
            }
            }
            
          
        }
    }
}
