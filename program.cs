int[] pole1 = new int[5];
Console.WriteLine("Napiš hodnoty, které chceš dát do 1 pole");
pole1[0] = int.Parse(Console.ReadLine());
pole1[1] = int.Parse(Console.ReadLine());
pole1[2] = int.Parse(Console.ReadLine());
pole1[3] = int.Parse(Console.ReadLine());
pole1[4] = int.Parse(Console.ReadLine());
for (int i = 0; i < pole1.Length; i++)
{
    Console.WriteLine("Hodnota X na indexu Y v prvním poli je:" + pole1[i] + " ");
}
int[] pole2 = { 5, 12, 8, 15, 16 };
int[] pole3 = { 9, 4, 7, 22, 10 };
int vysledek = pole2[0] + pole2[1] + pole2[2] + pole2[4];
Console.WriteLine(vysledek);

int pom = pole3[4];
pole3[4] = pole3[3];
pole3[3] = pole3[2];
pole3[2] = pole3[1];
pole3[1] = pole3[0];
pole3[0] = pom;
