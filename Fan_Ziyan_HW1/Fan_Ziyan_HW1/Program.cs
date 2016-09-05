using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Ziyan Fan
//Date: September 6, 2016
//Assignment: Homework 1
//Description: This program calculates the cost of football tickets for a customer


namespace Fan_Ziyan_HW1
{
    class Program
    {
        static void Main(string[] args)
        {

            //create named constants
            const int premium = 75;
            const int GA = 50;
            const decimal tax = 8.75m;
            
            //create variables
            int PNum;
            int GANum;
            int TotalTickets;
            int PremiumSub;
            int GASub;
            int Subtotal;
            decimal SalesTax;
            decimal GrandTotal;
            decimal PremiumPercentage;

              
            
            
                
            
            //get the number of premium and general admission tickets        
            do
            {   //Prmopts user to enter number of premium tickets
                Console.WriteLine("Please enter the number of premium tickets.");
                PNum = Console.ReadLine();
                //Prompts user to enter number of GA tickets
                Console.WriteLine("Please enter the number of GA tickets.");
                GANum = Console.ReadLine();

                Totaltickets = CheckTotal(Pnum, GANum);
            } while (TotalTickets == -1); //checks to see if we need to ask the user for a new input

            //calculate premium subtotal
            PremiumSub = PNum* premium;
            
            //calculate GA subtotal
            GASub = GANum* GA;

            //calculate subtotal
            Subtotal = PremiumSub + GASub;

            //calculate sales tax
            SalesTax = Subtotal* tax;

            //calculate grand total
            GrandTotal = Subtotal + SalesTax;

            //calculate premium percentage
            PremiumPercentage = (PNum/TotalTickets) *100;

            Console.WriteLine("Your total number of tickets is " + TotalTickets);
            Console.WriteLine("Your premium subtotal is " + Math.Round(PremiumSub,2));
            Console.WriteLine("Your general admission subtotal is " + Math.Round(GASub,2);
            Console.WriteLine("Your overall subtotal is " + Math.Round(Subtotal,2));
            Console.WriteLine("Your sales tax is " + Math.Round(SalesTax,2));
            Console.WriteLine("Your grand total is " + Math.Round(GrandTotal,2));
            Console.WriteLine("Your premiun percentage is " + Convert.ToInt32(PremiumPercentage) + "%");
            
            //keep console open
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();


            
            
            
                
               
        public static int CheckTotal(String Pnum, String GANum)
    {
        int CheckResult;

        try
        {
            CheckResult = Convert.ToInt16(Pnum);
            CheckResult = Convert.ToInt16(GANum);

        }
        catch
        {
            return -1;
        }

        if (Pnum + GANum == 0)
        {
            return -1;
        }


        return CheckResult;






    }
    }
        }    
    

