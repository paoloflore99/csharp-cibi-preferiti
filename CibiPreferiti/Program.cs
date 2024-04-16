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
                ;
            }


            //creazione array
            string[] CibiPreferiti = { "carbonara", "amatriciana" , "pasta" , "pesce" , "torta"};
            

            //ciclo l'array 
            for (int i =0;  i < CibiPreferiti.Length; i++)
            {
                // Console.WriteLine(CibiPreferiti[0]);

                //stampo la lunghezza
                //Console.WriteLine(CibiPreferiti[i].Length);
                Console.Write(i+1 + " ");

                //cosi facendo stampo semplicemente l'array 
                Console.WriteLine(CibiPreferiti[i]);
                

            }

            Console.WriteLine("il mio piatto preferito e la " + CibiPreferiti[0]);





            //metodo 2
            string[ , ] CibiPreferitiDue = { { "carbonara", "1" } , { "amatriciana", "2"} , { "pasta","3" }, { "pesce", "4"} , { "torta" , "5" } };
            
            for (int i =0;i < CibiPreferitiDue.Length;i++)
            {
                Console.WriteLine(CibiPreferitiDue[0,0]);
            }
        }
    }
}
