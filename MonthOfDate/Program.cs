using System.Globalization;

Console.Write("Escriba la cantidad de fechas aleatorias a agregar: ");
var isIntValue = int.TryParse(Console.ReadLine(), out int count);

if (!isIntValue)
{
    throw new Exception("No se escribió la cantidad de fechas.");
}

for (int i = 0; i < count; i++)
{
    var gen = new Random();
    DateTime today = DateTime.Now;

    int r = gen.Next(1, 1000);
    DateTime randomDate = today.AddDays(r);

    string date = randomDate.ToString("dd/MM/yyyy");
    string month = randomDate.ToString("MMMM", CultureInfo.CreateSpecificCulture("es")).ToUpper();

    Console.WriteLine(date + " => " + month);
}