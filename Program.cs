#nullable disable

#pragma warning restore format

string[] arrSymbol = { " ", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                      "А", "Б", "В", "Г", "Д", "Е", "Ж", "З", "И", "Й",
                      "К", "Л",  "М", "Н", "О", "П", "Р", "С", "Т", "У",
                      "Ф", "Х",  "Ц", "Ч", "Ш","Щ", "Ъ",  "Ы", "Ь", "Э",
                      "Ю", "Я"};
string[] arrMorse = { " ", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.",
                      ".-", "-...", ".--", "--.", "-..", ".", "...-", "--..", "..", ".---",
                      "-.-", ".-..",  "--", "-.", "---", ".--.", ".-.", "...", "-", "..-",
                      "..-.", "....",  "-.-.", "---.", "----","--.-", ".--.-",  "-.--", "-..-", "..-..",
                      "..--", ".-.-"};

Console.Write("Выберите режим (0 - кодирование, 1 - декодирование): ");
string mode = Console.ReadLine();
string str = string.Empty;

switch(mode)
{
    case "0" :
        Console.WriteLine(MorseCoder("КОДЕР МОРЗЕ"));
        str = Console.ReadLine();
        Console.WriteLine(MorseCoder(str));
        break;
    case "1" :
        Console.WriteLine(MorseDecoder("-.. . -.- --- -.. . .-.   -- --- .-. --.. ."));
        str = Console.ReadLine();
        Console.WriteLine(MorseDecoder(str));
        break;
    default :
        return;
}

string MorseDecoder(string morseString)
{
    string decodeString = string.Empty;
    string[] morseWordsArray = morseString.Split("   ");
    for (int i = 0; i < morseWordsArray.Length; i++)
    {
        decodeString += GetWord(morseWordsArray[i]) + " ";
    }
    return decodeString;
}

string GetWord(string morseWord)
{
    string outWord = string.Empty;
    string[] morseSymbolsArray = morseWord.Split(" ");
    for (int i = 0; i < morseSymbolsArray.Length; i++)
    {
        outWord += GetSymbol(morseSymbolsArray[i]);
    }
    return outWord;
}

string GetSymbol(string morseSymbol)
{
    int index;
    string outSymbol = string.Empty;
    
    for (int i = 0; i < arrMorse.Length; i++)
    {
         if (arrMorse[i] == morseSymbol)
        {
            index = i;
            outSymbol = arrSymbol[index];
            break;
        } 
        else
        {
            outSymbol = "?";
        }        
    }    
    return outSymbol;
}

string MorseCoder(string symbolString)
{
    string codeString = string.Empty;
    char[] symbolArray = symbolString.ToCharArray();
    for (int i = 0; i < symbolArray.Length; i++)
    {
        codeString += GetMorseSymbol(symbolArray[i]);
    }
    return codeString;
}

string GetMorseSymbol(char symbol)
{
    int index;
    string outSymbol = string.Empty;
    string inSymbol = symbol.ToString();
    for (int i = 0; i < arrSymbol.Length; i++)
    {
         if (arrSymbol[i] == inSymbol)
        {
            index = i;
            outSymbol = arrMorse[index] + " ";
            break;
        } 
        else
        {
            outSymbol = "?";
        }        
    }    
    return outSymbol;
}
