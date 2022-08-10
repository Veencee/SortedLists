namespace RegSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Dictionary<int, string> InecReg = new Dictionary<int, string>() 
            {
                {1,"John Mad"},
                {2,"Maths Lu"},
                {3,"Zui Zang "},
                {4,"John Bosco"},
                {5,"Van Damme"},
                {6,"James Bond"},
                {7,"Van Damme"},
                {8,"Rock Johnson"},
                {9,"Rambo Sly"},
                {10,"Osama Laden"},
                {11,"James Bond"},
                {12,"Zui Zang "},
                {13,"Van Damme"}
            };
            Console.WriteLine("                      Voters' Registeration ");
            Console.WriteLine("                     _______________________ ");

            //Go through all the elements in Dict
            foreach (KeyValuePair<int, string> dups in InecReg)
            {
                Console.WriteLine(dups.Key + "  " + dups.Value);
            }

            // to find dictionary duplicate values.  
            var duplicateValues = InecReg.GroupBy(x => x.Value).Where(x => x.Count() > 1);

            Console.WriteLine(" ");
            Console.WriteLine("                       The Duplicates are ");
            Console.WriteLine("                     _______________________ ");

            //loop dictionary duplicate values only            
            foreach (var names in duplicateValues)
            {
                Console.WriteLine(names.Key);
            }
        }
    }
}