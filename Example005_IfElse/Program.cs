Console.Write("Please enter Username: ");
string username = Console.ReadLine();

if(username.ToLower() == "anthony")
{
    Console.WriteLine("Hey, wazzup Anthony");
}
else 
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}