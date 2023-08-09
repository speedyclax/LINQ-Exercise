namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Games = new List<string> { "Super Mario 3d Land", "Mario64", "Super Mario World", "Mario Odyssey" };

            var gamesOrder = Games.OrderBy(x => x.Length);

            foreach (var game in gamesOrder)
            {
                Console.WriteLine(game);
            }
        }
    }
}
