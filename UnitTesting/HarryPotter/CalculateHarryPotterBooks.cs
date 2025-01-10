using System;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HarryPotter
{
    public class CalculateHarryPotterBooks
    {
        static void Main(string[] args)
        {
            int[] books = new int[] { 2, 2, 2, 1, 1 };

            var totalCost = CalculateTotalPrice(books);
            Console.WriteLine($"The total cost of the basket is: {totalCost:F2} EUR");
        }

        public static double CalculateTotalPrice(int[] books)
        {
            if (books == null) throw new ArgumentNullException(nameof(books), "The book list can not be null");

            const double bookPrice = 8.0;
            double totalCost = 0.0;

            while (books.Sum() > 0)
            {
                int differentBooksCount = books.Count(b => b > 0);

                // Calculate discount
                double discount = GetDiscount(differentBooksCount);

                // Calculate price for this set
                totalCost += differentBooksCount * bookPrice * (1 - discount);

                // Decrement count of books
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i] > 0)
                    {
                        books[i]--;
                    }
                }
            }

            return totalCost;
        }

        private static double GetDiscount(int differentBooksCount)
        {
            switch (differentBooksCount)
            {
                case 2: return 0.05; // 5% discount
                case 3: return 0.10; // 10% discount
                case 4: return 0.20; // 20% discount
                case 5: return 0.25; // 25% discount
                default: return 0.00; // No discount
            }
        }
    }
}