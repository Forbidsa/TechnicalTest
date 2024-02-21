Console.Write("Escriba la cantidad de datos que desee en el arreglo: ");
var isIntValue = int.TryParse(Console.ReadLine(), out int count);

if (!isIntValue)
{
    throw new Exception("No se escribió la cantidad de datos para el arreglo.");
}

int[] values = new int[count];

for (int i = 0; i < count; i++)
{
    Console.Write("Value[" + i + "]: ");
    _ = int.TryParse(Console.ReadLine(), out int value);
    values[i] = value;
}

values = values.OrderBy(v => v).ToArray();

Console.WriteLine("\nValores Ordenados");

int position = 0;
foreach (int value in values)
{
    Console.WriteLine("Value[" + position + "]: " + value);
    position++;
}