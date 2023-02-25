// See https://aka.ms/new-console-template for more information



using hw1passwordGenerator.Console;

Console.WriteLine("How long do you want your password to be?");
int passwordLength =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Do you want to include lowercase characters? (y / n)");
var lowerChar = Console.ReadLine();
bool isLowerChar = false;

Console.WriteLine("Do you want to include uppercase characters? (y / n)");
var upperChar = Console.ReadLine();
bool isUpperChar = false;

Console.WriteLine("Do you want to include numbers? (y / n)");
var numChar = Console.ReadLine();
bool isNumChar = false;

Console.WriteLine("Do you want to include special characters? (y / n)");
var specialChar = Console.ReadLine();
bool isSpecialChar = false;


isLowerChar = lowerChar == "y" || lowerChar == "Y";

isUpperChar = upperChar == "y" || upperChar == "Y";

isNumChar = numChar == "y" || numChar == "Y";

isSpecialChar = specialChar == "y" || specialChar == "Y";

if (!isLowerChar && !isUpperChar && !isNumChar && !isSpecialChar || passwordLength == 0)
{
    Console.WriteLine("I can't generate a password with no characters:(.");
}
else
{
    Console.WriteLine(Generator.GeneratePassword(isUpperChar, isLowerChar, isNumChar, isSpecialChar, passwordLength));
}




