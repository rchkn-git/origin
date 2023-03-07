// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя");
string name = Console.ReadLine();
if (name.ToLower() == "аня")
{
    Console.WriteLine("УРААОАОАОА!!!! ПРЕВЕД АНЯ!");
}
else
{
    Console.WriteLine("Привет, " + name + "!");
}