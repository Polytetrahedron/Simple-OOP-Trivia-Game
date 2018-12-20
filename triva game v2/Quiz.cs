using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;

namespace Trivia
{
    public abstract class Quiz
    {
        private int qNum = 0;
        private String answer;
        private int score = 0;
        private int tracker = 0; // used to track current q's
        private bool winCon = false; //might need?
        private ArrayList used = new ArrayList(); //to track used q's
        private int maxtrack = 6;



        public int Randomizer()
        {
            Random rand = new Random();

            int boom = rand.Next(0,16);

            return boom;
        }

        //----------------------------------------------------------------

        public bool qCheck(int num)
        {
            for (int i = 0; i < used.Count; i++)
            {
                if (used[i].Equals(num))
                {
                    return true;
                }
            }
            
            return false;
        }

        public void threshold()
        {
            if (score > 0 && score < maxtrack * 0.3)
            {
                Console.WriteLine("Are you failing on purpose?");
            }
            else if (score == 3)
            {
                Console.WriteLine("You've done well, try getting a better score next time!");
            }
            else if (score == 4)
            {
                Console.WriteLine("You've done well, try getting a better score next time!");
            }
            else if (score  == 5  )
            {
                Console.WriteLine("Nearly there but can you get them all correct?");
            }
            else if (score == 6)
            {
                Console.WriteLine("You got a perfect score, Congratulations!");
            }

        }

        // must have in order to be a quiz they are methods that must be implemented
        public abstract int questionPool();

        public abstract void anCheck(int num, String answer);

        public abstract void checkAnswer();

        //-----------------------------------

        public int getQNum()
        {
            return qNum;
        }

        public void setQNum(int qNum)
        {
            this.qNum = qNum;
        }

        //-----------------------------------

        public String getAnswer()
        {
            return answer.ToLower();
        }

        public void setAnswer(String answer)
        {
            this.answer = answer;
        }

        //-----------------------------------

        public int getScore()
        {
            return score;
        }

        public void addScore()
        {
            score++;
        }

        //-----------------------------------

        public int getTracker()
        {
            return tracker;
        }

        public void addTracker()
        {
            tracker++;
        }

        //-----------------------------------

        public bool getWinCon()
        {
            return winCon;
        }

        public void setWinCon(bool winCon)
        {
            this.winCon = winCon;
        }


        public void addToUsed(int num)
        {
            used.Add(num);
        }

        
        public int getMax()
        {
            return maxtrack;
        }
        
        
    }
}