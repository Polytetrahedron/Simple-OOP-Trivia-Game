using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Microsoft.Win32;

namespace Trivia
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            // Declaring objects
            Biology skin;
            Music treble;
            Sports ball;
            Seasonal winter;
            Films movie;
            Disney kid;
            
            
            String input = null; // holding user input
            int flag = 0; // exit for loop
            
            while (flag != 1)
            {
                Console.WriteLine("Please select a quiz! \n" +
                                  "a) Biology \n" +
                                  "b) Sports \n" +
                                  "c) Music \n" +
                                  "d) Seasonal \n" +
                                  "e) Films \n" +
                                  "f) Disney \n" +
                                  "Type exit to stop playing");
                
                
                input = Console.ReadLine(); // capturing user input
                input = input.ToLower(); // Normalising user input
                
                
                if (input.Equals("a"))
                {
                     int confirm = confirmCheck("Biology");
                        
                      if (confirm == 1)
                     {
                         skin = new Biology();
                         flag = skin.questionPool();    
                         Console.WriteLine("");
                        
                     }
                }
                else if (input.Equals("b"))
                {
                    int confirm = confirmCheck("Sports");
                        
                    if (confirm == 1)
                    {
                         ball = new Sports();
                        flag = ball.questionPool(); 
                        Console.WriteLine("");
                        
                    }
                   
                }
                else if (input.Equals("c"))
                {
                    int confirm = confirmCheck("Music");
                        
                    if (confirm == 1)
                    {
                        treble = new Music();
                        flag =  treble.questionPool();   
                        Console.WriteLine("");
                        
                    }
                }
                else if (input.Equals("d"))
                {
                    int confirm = confirmCheck("Seasonal");
                        
                    if (confirm == 1)
                    {
                        winter = new Seasonal();
                        flag = winter.questionPool(); 
                        Console.WriteLine("");
                         
                    }
                }
                else if (input.Equals("e"))
                {
                    int confirm = confirmCheck("Films");
                        
                    if (confirm == 1)
                    {
                        movie = new Films();
                        flag =movie.questionPool();   
                        Console.WriteLine("");
                         
                    }
                }
                else if (input.Equals("f"))
                {
                    int confirm = confirmCheck("Disney");

                    if (confirm == 1)
                    {
                        kid = new Disney();
                        flag =  kid.questionPool();
                        Console.WriteLine("");
                       
                       
                    }      
                    
                }
                else if (input.Equals("exit"))
                {
                    System.Environment.Exit(1);
                }
                    
                else
                {
                    Console.WriteLine("Please enter a valid choice");
                }
            }
        }

       //----------------------------------------------------------------------------------------------
       
        private static int confirmCheck(String sub)
        {            
            int exit = 0;
            Console.WriteLine("Are you sure you want " + sub + "?" + " Enter Y/N");
                    
            while (exit != 1)
            {
                String input = Console.ReadLine();
                input = input.ToLower();
                        
                if (input == "y")
                {
                    return 1;
                }
                else if (input == "n")
                {
                    Console.WriteLine("Then choose a subject you are happy with");
                    Console.WriteLine(" ");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Please enter Valid option Y/N");
                }    
            }

            return 0;
        }
    }
}