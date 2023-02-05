namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task
            //int Pul = 859;
            //int BesYuz = Pul / 500;
            //Pul -= BesYuz * 500;
            //int ikiYuz = Pul / 200;
            //Pul -= ikiYuz * 200;
            //int yuz = Pul / 100;
            //Pul -= yuz * 100;
            //int Elli =Pul / 50;
            //Pul -=  Elli * 50;
            //int Iyirmi = Pul / 20;
            //Pul -= Iyirmi * 20;
            //int On = Pul / 10;
            //Pul -= On * 10;
            //int bes = Pul / 5;
            //Pul -= bes * 5;


            //Console.WriteLine($"Besyuz={BesYuz},Ikiyuz={ikiYuz},yuz={yuz},elli={Elli},iyirmi={Iyirmi},on={On},bes={bes},bir={Pul}");
            #endregion
            Console.Write("Massivin uzunlugunu daxil edin:");
            int n = int.Parse(Console.ReadLine());
            double[] realNumber= new double[n];
            for (int i = 0;i<realNumber.Length; i++)
            {
                Console.Write($"realNumber[{i}]");
                realNumber[i] = double.Parse(Console.ReadLine());
            }
      
            
            int minIndex = 0, maxIndex = 0;

            for(int i =0; i<realNumber.Length; i++)
            {
                if (realNumber[i] < realNumber[minIndex])
                minIndex = i;
                if (realNumber[i] > realNumber[maxIndex])
                minIndex = i;
            }

            double tmp = realNumber[minIndex];
            realNumber[minIndex] = realNumber[maxIndex];
            realNumber[minIndex] = realNumber[maxIndex];
            realNumber[maxIndex ] = tmp;

            foreach (var item in realNumber) 
            {
                Console.Write(item + " ");
            }
        }
    }
}
