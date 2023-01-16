
Console.WriteLine("Welcome to the  Almighty Pig Latin Translator 8000");

    bool runProgram = true;
    while (runProgram)

{
    Console.Write("Please enter a word: ");
    string word = (Console.ReadLine().ToLower());
        
    int VowelPosition = -1;
    foreach (char letter in word)
    {
        VowelPosition = VowelPosition + 1;
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            break;
        }
    }

    string PigLatinWord = "";
    string BeforeLetters = "";
    string AfterLetters = "";
    switch (VowelPosition)

    {
        case 0:
            PigLatinWord = word + "way";
            break;
        case 1:
            BeforeLetters = word.Substring(0, 1);
            AfterLetters = word.Substring(1);
            PigLatinWord = AfterLetters + BeforeLetters + "ay";
            break;
        case 2:
            BeforeLetters = word.Substring(0, 2);
            AfterLetters = word.Substring(2);
            PigLatinWord = AfterLetters + BeforeLetters + "ay";
            break;
        case 3:
            BeforeLetters = word.Substring(0, 3);
            AfterLetters = word.Substring(3);
            PigLatinWord = AfterLetters + BeforeLetters + "ay";
            break;
        case 4:
            BeforeLetters = word.Substring(0, 4);
            AfterLetters = word.Substring(4);
            PigLatinWord = AfterLetters + BeforeLetters + "ay";
            break;
        case 5:
            BeforeLetters = word.Substring(0, 5);
            AfterLetters = word.Substring(5);
            PigLatinWord = AfterLetters + BeforeLetters + "ay";
            break;
        case 6:
            BeforeLetters = word.Substring(0, 6);
            AfterLetters = word.Substring(6);
            PigLatinWord = AfterLetters + BeforeLetters + "ay";
            break;
        case 7:
            BeforeLetters = word.Substring(0, 7);
            AfterLetters = word.Substring(7);
            PigLatinWord = AfterLetters + BeforeLetters + "ay";
            break;
        default:
            PigLatinWord = "Please use a real word. Pig Latin Translator 8000 has no time for fake words";
            break;
    }

    Console.WriteLine("Translation: " + PigLatinWord);

    while (true)
    {
        Console.WriteLine("Would you like to translate another word? y/n");
        string choice = Console.ReadLine().Trim().ToLower();

        if (choice == "y")
        {
            runProgram = true;
            break;
        }
        else if (choice == "n")
        {
            runProgram = false;
            break;
        }
                        
    }
}

    














