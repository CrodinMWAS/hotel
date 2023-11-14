namespace Hotellift
{
    internal class Program
    {
        static List<Lift> liftList = new List<Lift>();
        static void Main(string[] args)
        {
            StreamReader sr = new("lift.txt");
            while (!(sr.EndOfStream))
            {
                string[] line = sr.ReadLine().Split(" ");
                Lift newLift = new Lift(line[0], Convert.ToInt32(line[1]), Convert.ToInt32(line[2]), Convert.ToInt32(line[3]));
                liftList.Add(newLift);
            }

            Console.WriteLine($"3. feladat: {liftList.Count}");

            Console.WriteLine($"5. feladat: {liftList.Max(x => x.EndID)}");
            Console.WriteLine("6. feladat:");

            int searchedCards;
            int searchedEnd;

            try
            {
                Console.WriteLine("Kárya száma: ");
                searchedCards = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Célszint száma: ");
                searchedEnd = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Számot!");
                throw;
            }

            
            Console.WriteLine("7. feladat:");

            foreach (var item in liftList)
            {
                if (item.CardID == searchedCards && item.EndID == searchedEnd) {
                    Console.WriteLine("Utaztak");
                    break;
                }
            }

            //A 8. feladatot nemtudom megoldani.
        }
    }
}