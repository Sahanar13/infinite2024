using System;

namespace TicketConcession
{
    public class TicketConcession
    {
        public void CalculateConcession(int age)
        {
            const double TotalFare = 500.0;

            if (age <= 5)
            {
                Console.WriteLine("Little Champs - Free Ticket");
            }
            else if (age > 60)
            {
                double discountedFare = TotalFare * 0.7; 
                Console.WriteLine($"Senior Citizen - Fare: {discountedFare}");
            }
            else
            {
                Console.WriteLine($"Ticket Booked - Fare: {TotalFare}");
                Console.ReadKey();
            }
        }
    }
}