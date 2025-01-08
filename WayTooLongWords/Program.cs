




using System.Text;

int n=int.Parse(Console.ReadLine());
var listofWord=new List<string>();

//var listeee = new StringBuilder();

for (int i = 0; i < n; i++)
{
    string text = Console.ReadLine();
    listofWord.Add(text);
   // listeee.Append(text);
}

foreach (string word in listofWord)
{
    if (word.Length > 10)
    {
        string avreationword = $"{word[0]}{word.Length - 2}{word[^1]}";
        Console.WriteLine(avreationword);

    }
    else
    {
        Console.WriteLine(word);
    }
}

