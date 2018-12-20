using System;

namespace Trivia
{
    public class Sports : Quiz
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

                                Console.WriteLine("Who is the current highest Premier League goalscorer this season? \n" +
                                                  "a) Harry Kane \n" +
                                                  "b) Sergio Aguero \n" +
                                                  "c) Romelu Lukaku \n" +
                                                  "d) Mohamed Salah  ");

                                checkAnswer();

                                break;


                            case 2:

                                Console.WriteLine("What nationality is Chelsea Winger Eden Hazard? \n" +
                                                  "a) Spanish \n" +
                                                  "b) German \n" +
                                                  "c) Belgian \n" +
                                                  "d) Swedish ");

                                checkAnswer();

                                break;

                            case 3:

                                Console.WriteLine("in the 2016 Rio Olympics how many medals did Great Britain win? \n" +
                                                  "a) 70 \n" +
                                                  "b) 56  \n" +
                                                  "c) 121 \n" +
                                                  "d) 67");

                                checkAnswer();

                                break;

                            case 4:

                                Console.WriteLine("Music Star Rod Stewart is a season ticket for which Scottish football club? \n" +
                                                  "a) The Rangers \n" +
                                                  "b) Celtic \n" +
                                                  "c) Aberdeen \n" +
                                                  "d) Hearts ");

                                checkAnswer();

                                break;

                            case 5:

                                Console.WriteLine("Kevin De Bruyne and Mohammed Salah played for which same Premier League at different times in their career? \n" +
                                                  "a) Chelsea \n" +
                                                  "b) Arsenal \n" +
                                                  "c) Manchester United \n" +
                                                  "d) Liverpool");

                                checkAnswer();

                                break;

                            case 6:
                                Console.WriteLine("Where is the home of Golf? \n" +
                                                  "a) St Andrews \n" +
                                                  "b) Pyongyang \n" +
                                                  "c) Mosul \n" +
                                                  "d) Villa Las Estrellas");

                                checkAnswer();

                                break;

                            case 7:

                                Console.WriteLine("Gianluigi Buffon hasn't won which trophy?\n" +
                                                  "a) Champions League \n" +
                                                  "b) World Cup \n" +
                                                  "c) League Cup  \n" +
                                                  "d) Fifa Best Goalkeeper ");

                                checkAnswer();

                                break;

                            case 8:

                                Console.WriteLine("Gianluigi Donnarumma was what age when he was called up for Italy national squad and missed his high school exams? \n" +
                                                  "a) 24 \n" +
                                                  "b) 18 \n" +
                                                  "c) 33 \n" +
                                                  "d) 27");
                                checkAnswer();

                                break;

                            case 9:
                                Console.WriteLine("Chelsea FC changed their kit sponsor to what brand? \n" +
                                                  "a) Nike \n" +
                                                  "b) New Balance \n" +
                                                  "c) Puma \n" +
                                                  "d) Adidas");
                                checkAnswer();

                                break;

                            case 10:

                                Console.WriteLine("Which one of these players won their first Wimbledon when they were 16 years old? \n" +
                                                  "a) Maria Sharapova \n" +
                                                  "b) Anna Kournikova \n" +
                                                  "c) Venus Williams \n" +
                                                  "d) Martina Hingis ");
                                checkAnswer();

                                break;

                            case 11:

                                Console.WriteLine("Who is the world’s best Badminton Player? \n" +
                                                  "a) Lee Chong Wei \n" +
                                                  "b) Lin Dan \n" +
                                                  "c) Rudy Hartono \n" +
                                                  "d) Peter Hoeg Gade \n");
                                checkAnswer();

                                break;

                            case 12:

                                Console.WriteLine("Which Spanish Football player recently left FC Barcelona after 16 years? \n" +
                                                  "a) Sergio Ramos \n" +
                                                  "b) Gerard Pique \n" +
                                                  "c) Andres Iniesta \n" +
                                                  "d) Sergio Roberto \n");
                                checkAnswer();

                                break;

                            case 13:

                                Console.WriteLine("Which Professional darts player has just won their fourth Darts Premier League? \n" +
                                                  "a) Phil Taylor \n" +
                                                  "b) Gary Anderson \n" +
                                                  "c) Michael Smith \n" +
                                                  "d) Michael Van Gerwen \n");
                                checkAnswer();

                                break;

                            case 14:

                                Console.WriteLine("Who was appointed as Arsenal Fc’s New Manager? \n" +
                                                  "a) Unai Emery \n" +
                                                  "b) Marcos Alonso \n" +
                                                  "c) Arsene Wenger \n" +
                                                  "d) Antioni Conte \n");
                                checkAnswer();

                                break;

                            case 15:

                                Console.WriteLine("Who Is England’s new captain for the 2018 World Cup? \n" +
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

           if ( num == 4 || num == 8 || num == 11)
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
           else if (num == 6  || num == 7 || num == 5 || num == 9 || num == 14 || num == 15) 
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
           else if (num == 2 || num == 12)
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
           else if (num == 10 || num == 1  || num == 3 || num == 13)
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