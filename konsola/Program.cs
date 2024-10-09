namespace konsola
{
    internal class Program
    {
        static char CheckSex(string pesel)
        {
            if (int.Parse(pesel[9].ToString()) % 2 == 0)
                return 'K';
            return 'M';
        }

        static bool CheckChecksum(string pesel)
        {
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int S = 0;
            for (int i = 0; i < pesel.Length - 1; i++)
            {
                S += int.Parse(pesel[i].ToString()) * weights[i];
            }
            int M = S % 10;
            int R = 10 - M;
            if(M == 0)
                R = 0;
            if (int.Parse(pesel[10].ToString()) == R)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            string pesel = "55030101193";
            Console.WriteLine(CheckSex(pesel));
            Console.WriteLine(CheckChecksum(pesel));
        }

    }
}
