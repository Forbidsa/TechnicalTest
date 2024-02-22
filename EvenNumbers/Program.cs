Console.Write("Escriba la cantidad de datos que desee en el arreglo: ");
var isIntValue = int.TryParse(Console.ReadLine(), out int count);

if (!isIntValue)
{
    throw new Exception("No se escribió la cantidad de datos para el arreglo.");
}

int?[] values = new int?[count];

Console.WriteLine("Ingrese valores enteros.");

for (int i = 0; i < count; i++)
{
    Console.Write("Value[" + i + "]: ");

    var line = Console.ReadLine();
    bool result = line.Any(l => !char.IsLetter(l));

    if (!string.IsNullOrEmpty(line) && result)
    {
        _ = int.TryParse(line, out int value);
        values[i] = value;
    }
    else
    {
        Console.Write("No se agregó algún valor. \n");
    }
}

values = values.Where(v => v != null).ToArray();
values = values.OrderBy(v => v).ToArray();
values = values.Where(v => v % 2 == 0).ToArray();

if (values.Length == 0)
{
    Console.WriteLine("\nNo se agregaron valores al arreglo.");
}
else
{
    Console.WriteLine("\nValores Ordenados");

    int position = 0;
    foreach (int value in values)
    {
        Console.WriteLine("Value[" + position + "]: " + value);

        position++;
    }
}