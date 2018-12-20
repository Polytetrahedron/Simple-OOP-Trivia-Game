using System;

namespace Trivia
{
    public class Films: Quiz

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

                                Console.WriteLine("What was the first movie given the title Blockbuster? \n" +
                                              "a) Rocky \n" +
                                              "b) Jaws \n" +
                                              "c) Carrie \n" +
                                              "d) King Kong  ");

                            checkAnswer();

                            break;
                    
                      
                        case 2:

                            Console.WriteLine("Charlie Chaplin insured which part of his body? \n" +
                                              "a) Head  \n" +
                                              "b) Hands \n" +
                                              "c) Feet\n" +
                                              "d) Legs ");
                           
                            checkAnswer();

                            break;
                            
                        case 3:

                            Console.WriteLine("What supercar has jumped from a building in Furious 7 / Fast & Furious 7? \n" +
                                              "a) Bugatti Chiron \n" +
                                              "b) Koenigsegg Agera R \n" +
                                              "c) Lykan Hypersport \n" +
                                              "d) Lamborghini Centenario");
                        
                            checkAnswer();

                            break;
                    
                       case 4:

                            Console.WriteLine("In Kingsman 2 what kind of car does the main character drive in the first chase scene? \n" +
                                             "a) A Taxi \n" +
                                             "b) A Audi \n" +
                                             "c) A Mini \n" +
                                             "d) A Ferrari ");
                        
                           checkAnswer();

                           break;
                           
                       case 5:

                           Console.WriteLine("What colour were the slippers in the original Wizard of Oz? \n" +
                                             "a) Gold \n" +
                                             "b) Ruby \n" +
                                             "c) Silver \n" +
                                             "d) Emerald");
                        
                           checkAnswer();

                           break;
                           
                       case 6:
                           Console.WriteLine("In the movie Star Wars, What is the Emperor's last name? \n" +
                                             "a) Palpatine \n" +
                                             "b) Sheev \n" +
                                             "c) Sidious\n" +
                                             "d) Vader");
                         
                           checkAnswer();

                           break;
                           
                       case 7:

                           Console.WriteLine("Bruce Willis played a time traveling criminal in what movie?\n" +
                                              "a) Timecop \n" +
                                              "b) Time Bandits \n" +
                                              "c) Back to the Future \n" +
                                              "d) Twelve Monkeys");
                        
                            checkAnswer();

                            break;
                             
                       case 8:

                            Console.WriteLine("What is Sean Connery’s real first name?  \n" +
                                               "a) Alexander \n" +
                                               "b) Thomas \n" +
                                               "c) Benjamine \n" +
                                               "d) Stephen");
                             checkAnswer();
                             
                             break;
                       
                       case 9:
                             Console.WriteLine("In Goldfinger who was the boss of the Cement Mixers? \n" +
                                             "a) Oddjob \n" +
                                             "b) Tilly Masterson\n" +
                                             "c) Pussy Galore \n" +
                                             "d) Felix Leiter");
                           checkAnswer();
                             
                           break;
                           
                       case 10:

                           Console.WriteLine("In the film Indiana Jones and The Last Crusade, What is the name Indy has to spell in the second trial? \n" +
                                             "a) Barry \n" +
                                             "b) Jehovah \n" +
                                             "c) Jesus \n" +
                                             "d) Romulus ");
                           checkAnswer();
                             
                           break;

                            case 11:

                           Console.WriteLine("In the Film Daddy's Home 2 Who plays Mark Wahlberg's Father? \n" +
                                             "a) Mel Gibson \n" +
                                             "b) John Cena \n" +
                                             "c) Will Ferrell \n" +
                                             "d) John Lithgow");

                           checkAnswer();

                           break;

                            case 12:

                           Console.WriteLine("What is the name of Iron Man's wife? \n" +
                                             "a) Pepper \n" +
                                             "b) Lydia \n" +
                                             "c) iris \n" +
                                            "d) Katlyn");

                           checkAnswer();

                           break;

                            case 13:

                           Console.WriteLine("In South Dakota what is illegal to show in movies? \n" +
                                             "a) Gang Wars \n" +
                                             "b) Police being assaulted \n" +
                                             "c) Car thefts \n" +
                                             "d) Robberies");

                           checkAnswer();

                           break;

                            case 14:

                           Console.WriteLine("Which James Bond actor once had a job polishing coffins? /n" +
                                             "a) Sean Connery \n" +
                                             "b) Daniel Craig \n" +
                                             "c) Pierce Brosnan \n" +
                                             "d) Roger Moore");

                           checkAnswer();

                           break;

                            case 15:

                           Console.WriteLine("In Star Wars who is the first character to speak? \n" +
                                             "a) R2-D2 \n" +
                                             "b) Anakin Skywalker \n" +
                                             "c) Chewbacca \n" +
                                             "d) C3PO");

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

            if (   num == 4 || num == 6 || num == 11 || num == 12 || num == 14)
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
            else if ( num == 1 || num == 8 || num == 10 || num == 14)
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
            else if ( num == 2 || num == 3|| num == 5 || num == 9)
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
            else if ( num == 7 || num == 15)
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