using System;

namespace Trivia
{
    public class Disney : Quiz
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
                        Console.WriteLine("You have scored " + getScore() + "/"+ getMax());
                        threshold();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                      
                        return 0;
                    }
                    else
                    {
                        switch (getQNum()){
                        case 1:
                        
                            Console.WriteLine("In the Lion King, where does Mufasa and his family live? \n" +
                                              "a) Elephant Graveyard \n" +
                                              "b) The Gorge \n" +
                                              "c) Water Hole \n" +
                                              "d) Pride Rock ");                                                   

                            checkAnswer();

                            break;
                    
                      
                        case 2:

                            Console.WriteLine("In Bambi, What word does the Owl use to describe falling in love? \n" +
                                              "a) Magical  \n" +
                                              "b) Indefinable \n" +
                                              "c) Twitterpatted \n" +                                              
                                              "d) Infatuation  ");
                           
                            checkAnswer();

                            break;
                            
                        case 3:

                            Console.WriteLine("Which actor supplied the voice of Mushu in Mulan? \n" +
                                              "a) Jimmy Fallon \n" +
                                              "b) Seth MacFarlane  \n" +
                                              "c) David Spade \n" +
                                              "d) Eddie Murphy ");                                          
                        
                            checkAnswer();

                            break;
                    
                       case 4:
                           
                           Console.WriteLine("During the battle with Aladdin, what type of animal does Jafar transform himself into? \n" +
                                             "a) Tiger \n" +
                                             "b) Cobra \n" +                                                
                                             "c) Elephant \n" +
                                             "d) Boar ");
                        
                           checkAnswer();

                           break;
                           
                       case 5:
                           
                           Console.WriteLine("What time does the Royal Ball start in Cinderella? \n" +
                                             "a) 8pm  \n" +                         
                                             "b) 7pm  \n" +
                                             "c) 7:30pm  \n" +
                                             "d) 8:30pm ");
                        
                           checkAnswer();

                           break;
                           
                       case 6:
                           Console.WriteLine("Which princess has a racoon for a sidekick? \n" +
                                             "a) Mulan \n" +
                                             "b) Tiana \n" +
                                             "c) Jasmine \n" +
                                             "d) Pocahontas ");                     
                         
                           checkAnswer();

                           break;
                           
                       case 7:
                            
                            Console.WriteLine("What Country is Belle from Beuty and the Beast? \n" +
                                              "a) Germany \n" +
                                              "b) France \n" +                      
                                              "c) Spain \n" +
                                              "d) Italy ");
                        
                            checkAnswer();

                            break;
                             
                       case 8:
                             
                             Console.WriteLine("What is the name of the boy who owns Buzz Lightyear in Toy Story? \n" +
                                               "a) Brad \n" +
                                               "b) Josh \n" +
                                               "c) Andy \n" +                       
                                               "d) Jack ");
                             checkAnswer();
                             
                             break;
                       
                       case 9:
                           Console.WriteLine("What is the name of the Penguin toy in Toy Story 2? \n" +
                                             "a) Skipper \n" +
                                             "b) Mumble \n" +
                                             "c) Wheezy \n" +                   
                                             "d) Pingu ");
                           checkAnswer();
                             
                           break;
                           
                       case 10: 
                           
                           Console.WriteLine("What was the first debut episode of Mickey Mouse? \n" +
                                             "a) Steamboat Willie \n" +             
                                             "b) The Go-Getters \n" +
                                             "c) Tapped Out  \n" +
                                             "d) Yodelberg ");
                           checkAnswer();
                             
                           break;

                            case 11:

                           Console.WriteLine("Who is princess Aurora's Prince? \n" +
                                             "a) Prince Stephen \n" +
                                             "b) Prince Hubert \n" +
                                             "c) Prince Philip \n" +
                                             "d) Prince Edward");

                           checkAnswer();

                           break;

                            case 12:

                           Console.WriteLine("In Monsters Inc, What is Boo's real name? \n" +
                                             "a) Rose \n" +
                                             "b) Mary \n" +
                                             "c) Ruth \n" +
                                             "d) Betty \n");

                           checkAnswer();

                           break;

                            case 13:

                           Console.WriteLine("What are the names of the 2 eels who are Ursula's sidekicks? \n" +
                                             "a) Bill & Ben \n" +
                                             "b) Tom & Jerry \n" +
                                             "c) Bert & Ernie \n" +
                                             "d) Flotsam & Jetsam");

                           checkAnswer();

                           break;

                            case 14:

                           Console.WriteLine("Which Disney movie soundtrack featured Mel Gibson? \n" +
                                             "a) Pocahontas \n" +
                                             "b) Dumbo \n" +
                                             "c) Pete's Dragon \n" +
                                             "d) Bambi");

                           checkAnswer();

                           break;

                            case 15:

                                Console.WriteLine("What are the names of the 3 witches in Hocus Pocus? \n" +
                                                  "a) Jessica, Kathy & Bette \n" +
                                                  "b) Endora, Madame Mim & Marnie Stonebrook \n" +
                                                  "c) Winifred, Mary & Sarah \n" +
                                                  "d) Prue, Piper & Phoebe");

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

            if ( num == 5 || num == 10 || num == 14 )
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
            else if (num == 4 || num == 7 || num == 12 )
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
            else if (num == 2 || num == 9 || num == 8 || num == 11 || num == 15 )
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
            else if (num == 1 || num == 3 || num == 6 || num == 13 )
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