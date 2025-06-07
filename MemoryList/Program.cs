using MemoryList.Models;

int count = 0;

List<Cliente> clientes = [
    new Cliente { ClienteID = 1, Nombre = "Diego" },
    new Cliente { ClienteID = 2, Nombre = "Javier" }
];

List<Producto> productos = [
    new Producto { ProductoID = 1, Nombre = "Teclado", Precio = 500 },
    new Producto { ProductoID = 2, Nombre = "Mouse", Precio = 300 }
];

List<Venta> ventas = [
    new Venta { VentaID = 1, ClienteID = 1, ProductoID = 1, Cantidad = 2 },
    new Venta { VentaID = 2, ClienteID = 2, ProductoID = 2, Cantidad = 1 },
    new Venta { VentaID = 3, ClienteID = 1, ProductoID = 2, Cantidad = 3 },
];

while (true)
{
    Console.Write("Escriba la cantidad a consultar de registros: ");
    bool isIntValue = int.TryParse(Console.ReadLine(), out count);

    if (!isIntValue || count == 0)
        Console.WriteLine("No se escribió la cantidad de datos para el arreglo. Vuelva a intentar");
    else
        break;
}

var info = (from ven in ventas
            join cli in clientes on ven.ClienteID equals cli.ClienteID
            join pro in productos on ven.ProductoID equals pro.ProductoID
            select new
            {
                Cliente = cli.Nombre,
                Producto = pro.Nombre,
                ven.Cantidad,
                pro.Precio,
                Total = pro.Precio * ven.Cantidad,
            }).Take(count).ToList();

for (int i = 0; i < info.Count; i++)
{
    var renglon = info[i];

    Console.WriteLine($"Cliente: {renglon.Cliente}, Producto: {renglon.Producto}, Cantidad: {renglon.Cantidad}, Precio: {renglon.Precio}, Total: {renglon.Total}");
}

Console.ReadKey();
//info.ForEach(i => Console.WriteLine($"Cliente: {i.Cliente}, Producto: {i.Producto}, Cantidad: {i.Cantidad}, Precio: {i.Precio}, Total: {i.Total}"));