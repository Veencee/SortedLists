namespace DictSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // Create list with non-unique values
          List<string> voters = new List<string>();
            voters.Add("John Mad");
            voters.Add("Maths Lu");
            voters.Add("Zui Zang ");
            voters.Add("John Bosco");
            voters.Add("Van Damme");
            voters.Add("James Bond");
            voters.Add("Van Damme");
            voters.Add("Rock Johnson");
            voters.Add("Rambo Sly");
            voters.Add("Osama Laden");
            voters.Add("James Bond");
            voters.Add("Zui Zang ");
            voters.Add("Van Damme");

            // Make new unique list without duplicates
            List<string> newList = voters.Distinct().ToList();


         Console.WriteLine("                                       Names of Voters Registered");
         Console.WriteLine("                                      ___________________________");
            foreach (string person in newList)
            {
                Console.WriteLine(person);

            }
                Console.ReadLine();
            
        }
    }
}