using System;

namespace Trivia
{
    public class Biology : Quiz
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

                                Console.WriteLine("Where is Chlorophyll found? \n" +
                                                  "a) Dubai \n" +
                                                  "b) Green Tea \n" +
                                                  "c) Chloroplasts \n" +
                                                  "d) Mitochondria");

                                checkAnswer();

                                break;


                            case 2:

                                Console.WriteLine("What is the Humans natural predator? \n" +
                                                  "a) Man \n" +
                                                  "b) The Panzer IV  \n" +
                                                  "c) The Serangeti Lion \n" +
                                                  "d) Our natural predispostion to suicide ");

                                checkAnswer();

                                break;

                            case 3:

                                Console.WriteLine("What is the powerhouse of the cell? \n" +
                                                  "a) Nucleus  \n" +
                                                  "b) Animal Magnetism \n" +
                                                  "c) Love \n" +
                                                  "d) Mitochondria");

                                checkAnswer();

                                break;

                            case 4:

                                Console.WriteLine("Where is the Femur located? \n" +
                                                  "a) In the head \n" +
                                                  "b) In the feet \n" +
                                                  "c) In the arms \n" +
                                                  "d) In the legs    ");

                                checkAnswer();

                                break;

                            case 5:

                                Console.WriteLine("Why does Lactic acid build up? \n" +
                                                  "a) Exercise \n" +
                                                  "b) Fear \n" +
                                                  "c) Infection \n" +
                                                  "d) Oxygen");

                                checkAnswer();

                                break;

                            case 6:
                                Console.WriteLine("Which of these is an example of a dominant Gene? \n" +
                                                  "a) Brown Eyes \n" +
                                                  "b) Blue Eyes \n" +
                                                  "c) Red Hair\n" +
                                                  "d) Albinism");

                                checkAnswer();

                                break;

                            case 7:

                                Console.WriteLine("How many ventricles does the human heart have? \n" +
                                                  "a) 17 \n" +
                                                  "b) Depends on the day \n" +
                                                  "c) 2 \n" +
                                                  "d) Is it a leap year?");

                                checkAnswer();

                                break;

                            case 8:

                                Console.WriteLine("How many pairs of chromosomes do Humans normally have? \n" +
                                                  "a) 9000 \n" +
                                                  "b) 46 \n" +
                                                  "c) 4 \n" +
                                                  "d) 15");
                                checkAnswer();

                                break;

                            case 9:
                                Console.WriteLine("What is Mitosis? \n" +
                                                  "a) A way for cells to reproduce \n" +
                                                  "b) A way for cells to have fun \n" +
                                                  "c) A way for for cells to attack \n" +
                                                  "d) A way for cells move around the body");
                                checkAnswer();

                                break;

                            case 10:

                                Console.WriteLine("Which gland in the human body regulates metabolism? \n" +
                                                  "a) Meibonamn \n" +
                                                  "b) Pyloric \n" +
                                                  "c) Thyroid Gland \n" +
                                                  "d) Mammary Gland ");
                                checkAnswer();

                                break;

                            case 11:
                                Console.WriteLine("What is the name of the process which moves food through the digestive tract? \n" +
                                    "a) Operation Winkle \n" +
                                    "b) Peristalsis \n" +
                                    "c) Thyroid Gland \n" +
                                    "d) Mammary Gland \n");

                                checkAnswer();

                                break;

                            case 12:
                                Console.WriteLine("What is a Mutation? \n" +
                                                  "a) A deliberate change to genetic material \n" +
                                                  "b) A random change to genetic material \n" +
                                                  "c) A comic book species \n" +
                                                  "d) A type of haemoglobin \n");

                                checkAnswer();

                                break;

                            case 13:
                                Console.WriteLine("What does DNA stand for? \n " +
                                                  "a) Do Not Adopt \n" +
                                                  "b) Deoxyribonucleic \n" +
                                                  "c) Do Not Abreviate \n" +
                                                  "d) Decemnovenarian \n");

                                checkAnswer();

                                break;

                            case 14:
                                Console.WriteLine("What determines skin colour? \n" +
                                                  "a) Flavoxanthin \n" +
                                                  "b) Melanin \n" +
                                                  "c) Carotene \n" +
                                                  "d) Xanthophyll \n");

                                checkAnswer();

                                break;

                            case 15:
                                Console.WriteLine("What does Norepinephrine increase in the Human Body? \n" +
                                                  "a) Respiration \n" +
                                                  "b) Urine Production \n" +
                                                  "c) Salivia Production \n" +
                                                  "d) Blood Pressure \n");

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

            if ( num == 8 || num == 11 || num == 12 || num == 13 || num == 14 )
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
            else if ( num == 2  || num == 6 || num == 9 || num == 5)
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
            else if (num == 1 || num == 7 || num == 10 )
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
            else if (num == 3 || num == 4 || num == 15 )
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
        
        //---------------------------------------------------------------------------------------
        
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
