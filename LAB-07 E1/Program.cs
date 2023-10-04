Console.Write("Ingrese el valor de n: ");
int lim = int.Parse(Console.ReadLine());
float suma = 0.0f;
for(int i=1; i<=lim; i++)
{
    float r = (16.00f - i);
    float b = 3.00f * i;
    float f = r / b;
    Console.WriteLine("Resultado : " + f);
    suma +=f;
}
Console.WriteLine(suma);
Console.ReadKey();