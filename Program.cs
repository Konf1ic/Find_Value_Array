internal class Program
{
    private static void Main(string[] args)
    {
        String[] myStudent = { "Mai", "An", "Hao", "Tam", "Ha" };
        Console.WriteLine("Nhap 1 ten tu ban phim");
        string name = Console.ReadLine();

        bool isHas = false;
        for (int i = 0; i < myStudent.Length; i++)
        {
            if (myStudent[i].Equals(name))
            {
                Console.WriteLine("Co sinh vien trong lop");
                isHas = true;
                break;
            }
        }
        if (!isHas)
        {
            Console.WriteLine("Ko co sinh vien trong lop!!");
        }
    }
}