
// Carl Fransson .NET23

string name; // Saving name in string variable
int number = 15; // Saving the number in a int variable 
if (number > 10) // If number in int variable is bigger then 10. The program prints out "Talet är stort"
{
    Console.WriteLine("Talet är stort!");
}
else if (number > 10) // If the number is smaller then 10, the program prints out "Oj. Lågt tal"
{
    Console.WriteLine("Oj. Lågt tal!");
}
Console.WriteLine("Vad heter du?"); //The text inside "" gets printed out in the console 
name = Console.ReadLine(); // Users input saves in the name variable
Console.WriteLine("Hej " + name + "!"); // The program prints out "Hej" and the name that the user typed.
for (int i = 0; i <= number; i++) // Creates a loop that starts at 0 and keeps looping untill the number is equal to the number inside the number variable
{
    Console.WriteLine(i); // Prints out the loop in the console
}
Console.WriteLine("Välj valfribokstav för att avsluta programmet");
Console.ReadKey();// When the user types any key the program ends