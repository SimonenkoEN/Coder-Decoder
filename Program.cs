string[] arrMorse = { "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." };
string[] arrSymbol = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

Console.WriteLine(MorseDecoder("-----   .---- ..---   ...-- ....- .....   -.... --... ---.. ----."));

string MorseDecoder(string morseString)
{
    string decodeString = string.Empty;
    string[] morseWordArray = morseString.Split("   ");
    for (int i = 0; i < morseWordArray.Length; i++)
    {
        decodeString += GetWord(morseWordArray[i]) + " ";
    }
    return decodeString;
}

string GetWord(string morseWord)
{
    string outWord = string.Empty;
    string[] MorseSymbolArray = morseWord.Split(" ");
    for (int i = 0; i < MorseSymbolArray.Length; i++)
    {
        outWord += GetSymbol(MorseSymbolArray[i]);
    }
    return outWord;
}

string GetSymbol(string outMorseSymbol)
{
    int index;
    string outSymbol = string.Empty;

    for (int i = 0; i < arrMorse.Length; i++)
    {
        if (arrMorse[i] == outMorseSymbol)
        {
            index = i;
            outSymbol += arrSymbol[index];
            break;
        }
    }
    return outSymbol;
}
