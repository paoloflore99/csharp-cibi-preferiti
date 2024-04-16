namespace CibiPreferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] CibiPreferiti = { "carbonara", "amatriciana" , "pasta" , "pesce" , "torta"};

            for(int i =0;  i < CibiPreferiti.Length; i++)
            {
                Console.WriteLine(CibiPreferiti[i]);
            }
        }
    }
}
