using System;

namespace Assesment_Test
{
    class Program
    {
        static void Promotion(int customer, int price_person, string coupon){

            int total;         //Total bill
            double discount;    //Discount

            total = customer * price_person;

            if(coupon == "STARCARD" && customer==4){
                total = (customer - 1) * price_person;
                Console.WriteLine(total);
                Console.WriteLine("You apply the rule 3");
            
            }else if(total >= 2500){
                discount = total * 0.25;
                total = total - (int)discount;
                Console.WriteLine(total);
                Console.WriteLine("You apply the rule 4");
                
            }else if(coupon == "DIS10"|| total >= 2000){
                discount = total * 0.1;
                total = total - (int)discount;
                Console.WriteLine(total);
                Console.WriteLine("You apply the rule 1");
                
            }else if(coupon == "STARCARD" && customer==2){
                discount = total * 0.3;
                total = total - (int)discount;
                Console.WriteLine(total);
                Console.WriteLine("You apply the rule 2");
                
            }else if(coupon == "NONE"){
                Console.WriteLine(total);
                
            }

        }
        static void Main(string[] args)
        {
            int customer;      //Number of customers
            int price_person;   //Price per Person
            string coupon;      //Coupon

            Console.WriteLine("Number of customesr: ");
            customer = Convert.ToInt32(Console.ReadLine()); //Input the number of customers
            Console.WriteLine("Price per person: ");
            price_person = Convert.ToInt32(Console.ReadLine()); //Input price per person 
            Console.WriteLine("coupon code: ");
            coupon = Console.ReadLine(); //Input Coupon

            Promotion(customer, price_person, coupon);

        }
    }
}
