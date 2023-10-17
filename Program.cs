namespace Systen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo da extensão de um método de DateTime.
            DateTime dt = new DateTime(2023, 10, 16, 8, 0, 15);
            Console.WriteLine(dt.ElapsedTime());

            // Exemplo de extensão de um método utilizando string
            // vamos recortar uma string conforme qtd. de caracteres passada por parâmetro.
            string s = "Olá amigos, hoje o dia está maravilhoso!!!";
            Console.WriteLine(s.CutString(15));
        }
    }
}