public class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhập số lượng số nguyên tố: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        int n = 2;

        while (count < number)
        {

            bool soNguyenTo = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    soNguyenTo = false;
                    break;
                }
            }
            if (soNguyenTo)
            {
                Console.WriteLine(n);
                count += 1;
            }
            n += 1;
        }
        

        
    }
}