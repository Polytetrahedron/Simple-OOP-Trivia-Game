using System;

namespace Trivia
{
    public class Seasonal : Quiz

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
                        switch (getQNum()){
                        case 1:
                        
                            Console.WriteLine("Which season would you be seeing a lot of chocolate eggs around?  \n" +
                                              "a) Winter \n" +
                                              "b) Spring \n" +
                                              "c) Autumn \n" +
                                              "d) Summer  ");

                            checkAnswer();

                            break;
                    
                      
                        case 2:

                            Console.WriteLine("Which of these isn’t a Chinese New Year? \n" +
                                              "a) Year of the Dog  \n" +
                                              "b) Year of the Snake \n" +
                                              "c) Year of the Dragon \n" +
                                              "d) Year of the Crocodile ");
                           
                            checkAnswer();

                            break;
                            
                        case 3:

                            Console.WriteLine("Finish the sentence “ ???? for apples”? \n" +
                                              "a) Bobbing \n" +
                                              "b) Fighting \n" +
                                              "c) Hunting \n" +
                                              "d) Dancing");
                        
                            checkAnswer();

                            break;
                    
                       case 4:

                            Console.WriteLine("Which name isn’t a name of Santa’s reindeer? \n" +
                                             "a) Prancer \n" +
                                             "b) Cupid  \n" +
                                             "c) Donner \n" +
                                             "d) Kebab ");
                        
                           checkAnswer();

                           break;
                           
                       case 5:

                           Console.WriteLine("On which date does Valentine’s Day take place? \n" +
                                             "a) January 21st \n" +
                                             "b) March 16th \n" +
                                             "c) February 14th \n" +
                                             "d) April 3rd");
                        
                           checkAnswer();

                           break;
                           
                       case 6:
                           Console.WriteLine("What is another name for Bonfire Night? \n" +
                                             "a) Guy Fawkes Night  \n" +
                                             "b) Night of the fires   \n" +
                                             "c) House of Lords night  \n" +
                                             "d) Set things on fire night");
                         
                           checkAnswer();

                           break;
                           
                       case 7:

                           Console.WriteLine("What type of holiday is a Hanukkah? \n" +
                                              "a) Scottish    \n" +
                                              "b) Jewish \n" +
                                              "c) Greek   \n" +
                                              "d) Hindu	");
                        
                            checkAnswer();

                            break;
                             
                       case 8:

                            Console.WriteLine("When is New Year’s Day?  \n" +
                                               "a) January 1st   \n" +
                                               "b) January 2nd  \n" +
                                               "c) December 30th  \n" +
                                               "d) December 31st ");
                             checkAnswer();
                             
                             break;
                       
                       case 9:
                             Console.WriteLine("What isn’t another name for Mardi Gras? \n" +
                                             "a) Fat Tuesday  \n" +
                                             "b) Shrove Tuesday \n" +
                                             "c) Roast Tuesday  \n" +
                                             "d) Pancake Tuesday");
                           checkAnswer();
                             
                           break;
                           
                       case 10:

                           Console.WriteLine("Why do people celebrate Day of the Dead? \n" +
                                             "a) Celebrate creativity of the mind  \n" +
                                             "b) Celebrate scientific discoveries \n" +
                                             "c) Celebrate wonderful food     \n" +
                                             "d) Celebrate Life and Death");
                           checkAnswer();
                             
                           break;

                       case 11:

                           Console.WriteLine("In which country did Halloween originate? \n" +
                                             "a) India \n" +
                                             "b) China \n" +
                                             "c) Ireland \n" +
                                             "d) Russia \n");
                           checkAnswer();

                           break;

                       case 12:

                           Console.WriteLine("Kings cakes are a popular Mardi Gras tradition. What is hidden in the cake? \n" +
                                             "a) Silver Dollar \n" +
                                             "b) Plastic Baby \n" +
                                             "c) Treasure Hunt Map \n" +
                                             "d) Nothing \n");
                           checkAnswer();

                           break;

                       case 13:

                           Console.WriteLine("Before becoming tied up with Christmas what was Yule? \n" +
                                             "a) Buso Festival \n" +
                                             "b) A Pagan midwinter festival \n" +
                                             "c) La Tomatina \n" +
                                             "d) Krampusnacht \n");
                           checkAnswer();

                           break;

                       case 14:

                           Console.WriteLine("In the Philippines what date is the date that Mother’s Day is celebrated? \n" +
                                             "a) 5th October \n" +
                                             "b) 10th October \n" +
                                             "c) 12th May \n" +
                                             "d) 18th October \n");
                           checkAnswer();

                           break;

                       case 15:

                           Console.WriteLine("From an Old English word what does Spring mean (specifically)? \n" +
                                             "a) To rise \n" +
                                             "b) Searing horizon \n" +
                                             "c) Stillness of day \n" +
                                             "d) Tranquility of the sun \n");
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

            if (   num == 1 || num == 7 || num == 13 || num == 12)
            {
                if (answer.Equals("b"))
                {
                    addScore();
                    addTracker();
                    addToUsed(num);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!: "+ answer);
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
            else if ( num == 3 || num == 6 || num == 8 || num == 14)
            {
                if (answer.Equals("a"))
                {
                    addScore();
                    addTracker();
                    addToUsed(num);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!: "+ answer);
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
            else if ( num == 2 || num == 4 || num == 10)
            {
                if (answer.Equals("d"))
                {
                    addScore();
                    addTracker();
                    addToUsed(num);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!: "+ answer);
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
            else if ( num == 5|| num == 9 || num == 11 || num == 15)
            {
                if (answer.Equals("c"))
                {
                    addScore();
                    addTracker();
                    addToUsed(num);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!: "+ answer);
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