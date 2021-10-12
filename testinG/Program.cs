using System;

namespace testinG
{
    class Program
    {
        static void Main(string[] args)
        {

            Pineapple apple1 = new Apple(25, 3.4, 10);
            Pineapple lemon1 = new Lemon(30, 5.5, 20);
            Pineapple pine1 = new Pineapple(10, 2, 3);
            basketlist<Pineapple> basket1 = new basketlist<Pineapple>();
            basket1.Add(apple1);
            basket1.Add(lemon1);

            basket1.Add(pine1);
            
            foreach (var item in basket1.GetArray())
            {

                if (item is Apple)
                {
                    Console.WriteLine($"Apple nutrition : Calories: {item.calories}kkal Protein : {item.proteins}gr  Carbs : {item.carbs}gr");
                }
               
                else
                {
                    if(item is Lemon)
                    {
                        Console.WriteLine($"Lemon nutrition : Calories: {item.calories}kkal Protein : {item.proteins}gr  Carbs : {item.carbs}gr");
                    }
                    else
                    {

                        if (item is Pineapple)
                        {
                            Console.WriteLine($"Pineapple nutrition : Calories: {item.calories}kkal Protein : {item.proteins}gr  Carbs : {item.carbs}gr");
                        }

                    }
                }
                
            }
            
        }
    }


    
}
