Console.Write("И как же тебя зовут? ");
string username = Convert.ToString (Console.ReadLine());

if(username.ToLower() == "валера")
{
 Console.WriteLine("Йу-ху! Это же Валерончик!");
}
else
{
  Console.Write("А, это опять ты... Пфф... ");
  Console.WriteLine(username);
}