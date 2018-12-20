using System;

namespace Trivia
{
    public class Music : Quiz
    {
        
         public override int questionPool()
        {
            
            while (getWinCon() == false)
            {
                
                setQNum(Randomizer());
                bool chkq = qCheck(getQNum());
                    
                if (chkq == false)
                {

                    if (getTracker() == getMax())
                    {

                        setWinCon(true);
                        Console.WriteLine("You have scored " + getScore() + "/" + getMax());
                        threshold();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        
                        return 0;
                    }
                    else
                    {
                        switch (getQNum())
                        {
                            case 1:

                                Console.WriteLine("Who wrote the songs Viva La Vida and Somthing Just Like This? \n" +
                                                  "a) Coldplay \n" +
                                                  "b) The Beatles \n" +
                                                  "c) Nickelback \n" +
                                                  "d) The Red Hot Chili Peppers  ");

                                checkAnswer();

                                break;


                            case 2:

                                Console.WriteLine("Who had the most songs in the UK top 40 charts at the same time? \n" +
                                                  "a) Taylor Swift  \n" +
                                                  "b) Dua Lipa \n" +
                                                  "c) Ed Sheeran\n" +
                                                  "d) Miley Cyrus ");

                                checkAnswer();

                                break;

                            case 3:

                                Console.WriteLine("Who wrote the the songs Havanna and Crying in the Club? \n" +
                                                  "a) Ellie Goulding \n" +
                                                  "b) Ariana Grande  \n" +
                                                  "c) sia \n" +
                                                  "d) Camilla Cabello");

                                checkAnswer();

                                break;

                            case 4:

                                Console.WriteLine("Who was the winner of the 2017 Eurovision Song contest? \n" +
                                                  "a) Bulgaria \n" +
                                                  "b) Romania \n" +
                                                  "c) Portugal \n" +
                                                  "d) Italy ");

                                checkAnswer();

                                break;

                            case 5:

                                Console.WriteLine("Which artist had the most sales in 2017? \n" +
                                                  "a) Rag and bone man \n" +
                                                  "b) Ed Sheeran \n" +
                                                  "c) Kendrick Lamar \n" +
                                                  "d) P!nk");

                                checkAnswer();

                                break;

                            case 6:
                                Console.WriteLine("Which country singer wrote the the songs Friends in low Places and The Dance? \n" +
                                                  "a) Johnny Cash \n" +
                                                  "b) Conway Twitty \n" +
                                                  "c) Garth Brooks\n" +
                                                  "d) Dolly Parton");

                                checkAnswer();

                                break;

                            case 7:

                                Console.WriteLine("What is Freddie Mercury's birth name?\n" +
                                                  "a) Ethel Coleslaw \n" +
                                                  "b) Benidict Pinglewidth \n" +
                                                  "c) Farrokh Bulsara \n" +
                                                  "d) Rick Harrison");

                                checkAnswer();

                                break;

                            case 8:

                                Console.WriteLine("How many key do the majority of pianos have  \n" +
                                                  "a) 22 \n" +
                                                  "b) 88 \n" +
                                                  "c) 99 \n" +
                                                  "d) 49 ");
                                checkAnswer();

                                break;

                            case 9:
                                Console.WriteLine("Why was Beethoven so impressive? \n" +
                                                  "a) He fought 50 bears at once and won \n" +
                                                  "b) He could kill people with his minds  \n" +
                                                  "c) He could play the piano even though he was blind) \n" +
                                                  "d) He made his his best music when he became deaf ");
                                checkAnswer();

                                break;

                            case 10:

                                Console.WriteLine("What is Steve Aoki's signature move done at preformances? \n" +
                                                  "a) Crowd Surf \n" +
                                                  "b) T-shirt Cannon \n" +
                                                  "c) Cake Throw \n" +
                                                  "d) Confetti cannon ");
                                checkAnswer();

                                break;

                            case 11:

                                Console.WriteLine("which US rapper did Ed Sheeran provide guest vocals for to briefly score a UK number one in January 2018? \n" +
                                                  "a) Lee Chong Wei \n" +
                                                  "b) Lin Dan \n" +
                                                  "c) Rudy Hartono \n" +
                                                  "d) Peter Hoeg Gade \n");
                                checkAnswer();

                                break;

                            case 12:

                                Console.WriteLine("Which female vocalist performed 'The Star-Spangled Banner' at the 2018 NFL Super Bowl? \n" +
                                                  "a) Sergio Ramos \n" +
                                                  "b) Gerard Pique \n" +
                                                  "c) Andres Iniesta \n" +
                                                  "d) Sergio Roberto \n");
                                checkAnswer();

                                break;

                            case 13:

                                Console.WriteLine("Which rapper topped the UK charts in 2010 with Pass Out? \n" +
                                                  "a) Phil Taylor \n" +
                                                  "b) Gary Anderson \n" +
                                                  "c) Michael Smith \n" +
                                                  "d) Michael Van Gerwen \n");
                                checkAnswer();

                                break;

                            case 14:

                                Console.WriteLine("Calvin Harris And Dua Lipa collaborated on what song? \n" +
                                                  "a) Unai Emery \n" +
                                                  "b) Marcos Alonso \n" +
                                                  "c) Arsene Wenger \n" +
                                                  "d) Antioni Conte \n");
                                checkAnswer();

                                break;

                            case 15:

                                Console.WriteLine("Who was the youngest Beatle member? \n" +
                                                  "a) Harry Kane \n" +
                                                  "b) Marcus Rashford \n" +
                                                  "c) Jesse Lingard \n" +
                                                  "d) Jordan Pickford \n");
                                checkAnswer();

                                break;


                        }


                    }

                }

            }
            return 0;
        }

         //--------------------------------------------------------------

         public override void anCheck(int num, String answer)
         {

             if ( num == 5 || num == 8 )
             {
                 if (answer.Equals("b"))
                 {
                     addScore();
                     addTracker();
                     addToUsed(num);
                     Console.ForegroundColor = ConsoleColor.Green;
                     Console.WriteLine("Correct!: " + answer);
                     Console.ResetColor();
                     Console.WriteLine(" \n" +
                                       " ");
                 }
                 else
                 {
                     addTracker();
                     addToUsed(num);
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("Wrong answer!");
                     Console.ResetColor();
                     Console.WriteLine(" \n" +
                                       " ");
                 }
             }
             else if ( num == 1 )
             {
                 if (answer.Equals("a"))
                 {
                     addScore();
                     addTracker();
                     addToUsed(num);
                     Console.ForegroundColor = ConsoleColor.Green;
                     Console.WriteLine("Correct!: " + answer);
                     Console.ResetColor();
                     Console.WriteLine(" \n" +
                                       " ");
                 }
                 else
                 {
                     addTracker();
                     addToUsed(num);
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("Wrong answer!");
                     Console.ResetColor();
                     Console.WriteLine(" \n" +
                                       " ");
                 }
             }
             else if (num == 2 || num == 8 || num == 4 || num == 6 || num == 7 || num == 10)
             {
                 if (answer.Equals("c"))
                 {
                     addScore();
                     addTracker();
                     addToUsed(num);
                     Console.ForegroundColor = ConsoleColor.Green;
                     Console.WriteLine("Correct!: " + answer);
                     Console.ResetColor();
                     Console.WriteLine(" \n" +
                                       " ");
                 }
                 else
                 {
                     addTracker();
                     addToUsed(num);
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("Wrong answer!");
                     Console.ResetColor();
                     Console.WriteLine(" \n" +
                                       " ");
                 }
             }
             else if ( num == 3 || num == 9 )
             {
                 if (answer.Equals("d"))
                 {
                     addScore();
                     addTracker();
                     addToUsed(num);
                     Console.ForegroundColor = ConsoleColor.Green;
                     Console.WriteLine("Correct!: " + answer);
                     Console.ResetColor();
                     Console.WriteLine(" \n" +
                                       " ");
                 }
                 else
                 {
                     addTracker();
                     addToUsed(num);
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("Wrong answer!");
                     Console.ResetColor();
                     Console.WriteLine(" \n" +
                                       " ");
                 }
             }

         }

         public override void checkAnswer()
         {
             int flag = 0;

             while (flag != 1)
             {
                 setAnswer(Console.ReadLine());

                 if (getAnswer() == "a" || getAnswer() == "b" || getAnswer() == "c" || getAnswer() == "d")
                 {
                     anCheck(getQNum(), getAnswer());
                     flag = 1;
                     setAnswer(null);
                 }
                 else
                 {
                     Console.WriteLine("Please enter a valid option");
                     setAnswer(null);
                 }
             }

             questionPool();
         }
    }
}