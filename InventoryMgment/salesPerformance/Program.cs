namespace salesPerformance
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            var sales = new List<salesPerson>
            {
                new salesPerson { Name="Jhon", Performance=400.0},
                new salesPerson { Name="Karl", Performance=380.0},
                new salesPerson { Name="Wiliam", Performance=425.0}
            };

          for(int i=0; i<=sales.Count-1; i++)
            {
                Console.WriteLine(sales[i].Name+ " - " + sales[i].Performance);
            }


        }

    }

}