class Calculator
{
	static void Main(string[]args)
	{
	
	}
	
	static int Penambahan (int a, int b)
	{
		return a + b;
	}
	
	static int Pengurangan (int a, int b)
	{
		 return a - b;
	}
	
	int a = 15;
	int b = 10;
	
	Console.WriteLine("Hasil Penjumlahan : {0} + {1} = {2}", a, b, Penambahan(a, b));
	Console.WriteLine("Hasil Pengurangan : {0} - {1} = {2}", a, b, Pengurangan(a, b));
	
	Console.WriteLine("\nTekan Tombol Apa Saja Untuk Keluar");
}