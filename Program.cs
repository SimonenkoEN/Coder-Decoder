// Метод принимает на вход строку в коде Морзе м декодирует ее
string Decoder(string inString) 
{
    string[] arrMorse = {"-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----."};
    string[] arrNumber = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
    int index;
    string outString = string.Empty;
    string[] inArr = inString.Split("   ");
    for (int i = 0; i < inArr.Length ; i++)
    {
        string[] tmpArr = inArr[i].Split(" ");
        for(int j = 0; j < tmpArr.Length; j++)
        {
            for (int k = 0; k < arrMorse.Length; k++)
            {
                if(tmpArr[j] == arrMorse[k]) 
                {
                    index = k;
                    outString += arrNumber[index];
                    break;
                }                
            }           
        }
        outString += " ";        
    }
    return outString;
}
Console.WriteLine(Decoder(".- ----- .---- ..--- ...-- ....-   ---   ..... -.... --... ---.. ----. -.-"));