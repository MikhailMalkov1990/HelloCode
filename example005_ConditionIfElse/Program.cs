Console.Write("write username: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("look, this is Masha");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username); 
}