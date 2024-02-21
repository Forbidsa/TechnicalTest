Console.Write("Escriba la cantidad de datos que desee en el arreglo: ");
var isIntValue = int.TryParse(Console.ReadLine(), out int count);

if (!isIntValue)
{
    throw new Exception("No se escribió la cantidad de datos para el arreglo.");
}

string[] values = new string[count];

for (int i = 0; i < count; i++)
{
    Console.Write("Value[" + i + "]: ");
    var value = Console.ReadLine();

    if (!string.IsNullOrEmpty(value))
    {
        values[i] = value;
    }
    else
    {
        Console.Write("No se agregó algún valor. \n");
    }
}

values = values.Where(v => v != null).ToArray();

var stringValues = "Resultado = ";

if (values.Length == 0)
{
    stringValues = "No se agregaron valores al arreglo.";
}

for (int i = 0; i < values.Length; i++)
{
    stringValues =
        i == 0 && i == values.Length - 1 ? stringValues += "'" + values[i] + "'" :
        i == 0 ? stringValues += "'" + values[i] :
        i == values.Length - 1 ? stringValues += ", " + values[i] + "'" :
        stringValues += ", " + values[i];
}

Console.WriteLine(stringValues);