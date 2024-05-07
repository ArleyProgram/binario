int[] Z = { 1, 0, 1, 1, 0 };
Array.Reverse(Z);
int a = 0;
for (int i = 0; i < Z.Length; i++)
{
	if (Z[i] == 1)
	{
		a = a + (int)Math.Pow(2, i);
	}
}
Console.WriteLine(a);
