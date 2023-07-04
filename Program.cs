internal class Program
{
    private static void Main(string[] args)
    {
        List<string> personList = new List<string>
        { "Ali","Veli","Hasan","Hüseyin","Ayşe","Muhammed"};

        Predicate<string> predicate = FindPerson;
        //FindAll liste içinde çoklu arama yapar.bir şart ifadesi olmalı yani bool
        //predicate delegeler geriye bool döner.
        IEnumerable<string> person = personList.FindAll(predicate);
        foreach (var word in person)
            Console.WriteLine(word);
        
    }
    private static bool FindPerson(string name)
    {
        return name.Length > 4;
    }
}