internal class Program
{
    public static void Main(string[] args)
    {
        string[] nameList = {"Nam","Thang","Kien","Binh","Bac","Lam","Huy","GiaLinh","Doquyen"};
        Console.WriteLine("Nhap ten ban: ");
        string name = Console.ReadLine();
        bool isTrue = false;
        for (int i = 0; i <= nameList.Length-1; i++)
        {
            if( nameList[i].Equals(name))
            {
                Console.WriteLine($"Co ten trong mang va vi tri {i+1}");
                isTrue=true;
                break;
            }
        }
        if(isTrue==false)
        {
            Console.WriteLine("Khong co ten");
        }
    }
}