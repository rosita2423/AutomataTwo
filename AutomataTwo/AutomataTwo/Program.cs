// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");

string word = "";
string alphabet = "01";
string currentState = "s0";
bool wordValidation = false;


Console.WriteLine("Insert the word for this automata.");

word = Console.ReadLine();
if (word == null)
{
    word = " ";
}

wordCheck(word);

for (int i = 0; i < word.Length; i++)
{
    if (currentState == "s0")
    {
        if (word[i] == '0')
        {
            currentState = "s0";
            wordValidation = false;
        }
        else if (word[i] == '1')
        {
            currentState = "s1";
            wordValidation = true;
        }


    }
    else if (currentState == "s1")
    {
        if (word[i] == '1')
        {
            currentState = "s1";
            wordValidation = true;
        }
        else if (word[i] == '0')
        {
            currentState = "s0";
            wordValidation = false;
        }

    }
}

if (wordValidation)
{
    Console.WriteLine("Your word is valid. Nice work :)");
}
else
{
    Console.WriteLine("Your word is not valid :(");
}


Console.WriteLine("Nice");

void wordCheck(string word)
{
    for (int i = 0; i < word.Length; i++)
    {
        if (!alphabet.Contains(word[i]))
        {
            Console.WriteLine("The word is invalid. It has one or more symbols that doesn't belong to the alphabet.");
            Environment.Exit(0);
        }

    }

}