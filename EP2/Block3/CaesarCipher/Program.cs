/*
 * CaeserEncrypt only works if the resulting character is still a letter.
 * For example, 'z' + 1 would not be a letter in ASCII so the encryption does not entirely the original CaesarCipher algorithm.
 * The same applies to decryption, 'a' - 1 would not be a letter in ASCII. 
 */

string CaesarEncrypt(string message, int key)
{
    var cipher = "";
    foreach (var digit in message)
    {
        if (char.IsLetter(digit)) cipher += (char)(digit + key);
        else cipher += digit;
    }
    return cipher;
}

string CaesarDecrypt(string cipher, int key)
{
    var message = "";
    foreach (var digit in cipher)
    {
        if (char.IsLetter(digit)) message += (char)(digit - key);
        else message += digit;
    }
    return message;
}


//============================================================================================
//==================================== CaesarEncrypt Beispiele ===============================
//============================================================================================
Console.WriteLine("CaesarEncrypt Beispiele:");
Console.WriteLine(CaesarEncrypt("abc", 1)); // -> bcd (Versatz um 1)
Console.WriteLine(CaesarEncrypt("Hallo, EP2!", 3)); // -> Kdoor, HS2! (Versatz um 3; Ziffern und Sonderzeichen unverändert)
Console.WriteLine();

//============================================================================================
//==================================== CaesarDecrypt Beispiele ===============================
//============================================================================================
Console.WriteLine("CaesarDecrypt Beispiele:");
Console.WriteLine(CaesarDecrypt("bcd", 1)); // -> abc (Rückversatz um 1)
Console.WriteLine(CaesarDecrypt("Kdoor, HS2!", 3)); // -> Hallo, EP2! (Rückversatz um 3; Ziffern und Sonderzeichen unverändert)
Console.WriteLine();
    
//============================================================================================
//========================================= Test Code ========================================
//============================================================================================
Console.WriteLine(CaesarEncrypt("Hallo, EP2!", 3)); // should print: Kdoor, HS2!
Console.WriteLine(CaesarDecrypt("Ykixkz skyygmk", 6)); // should print: Secret message
Console.WriteLine(CaesarDecrypt(CaesarEncrypt("Good job!", 11), 11)); // Should print: Good job!