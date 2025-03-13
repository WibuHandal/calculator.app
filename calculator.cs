class calculator
{
static void Main(string[] args)
{
int a = 10;
int b = 6;

Console.Writeline("Hasil penambahan:{0} + {1} = {2}",a,b, penambahan(a,b));
Console.Writeline("Hasil penambahan:{0} - {1} = {2}",a,b, pengurangan(a,b));

Console.Writeline("\nTekan sembarang untuk keluar");
Console.Readkey();
}

static int Penambahan(int a, int b)
{
return a + b;	
}
static int Pengurangan(int a , int b)
{
	return a - b;
}
}