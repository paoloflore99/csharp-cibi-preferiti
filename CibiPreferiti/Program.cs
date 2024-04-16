namespace CibiPreferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //qui stampo la classifica 
            for (int i = 1; i <= 5; i++)
            {
                //stampo la classifica
                Console.WriteLine(i);
            }


            //creazione array
            string[] CibiPreferiti = { "carbonara", "amatriciana" , "pasta" , "pesce" , "torta"};
            

            //ciclo l'array 
            for (int i =0;  i < CibiPreferiti.Length; i++)
            {
               // Console.WriteLine(CibiPreferiti[0]);

             //cosi facendo stampo semplicemente l'array 
             Console.WriteLine(CibiPreferiti[i]);
            }





            //metodo 2
            string[,] CibiPreferitiDue = { { "carbonara", "1" } , { "amatriciana", "2"} , { "pasta","3" }, { "pesce", "4"} , { "torta" , "5" } };
            
            for (int i =0;i < CibiPreferitiDue.Length;i++)
            {
                Console.WriteLine(CibiPreferitiDue[i]);
            }
        }
    }
}
