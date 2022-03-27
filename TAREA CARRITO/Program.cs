using TAREA_CARRITO.Clases;

Carro miCarrito = new Carro("MERCEDES", 2022, "azul");
Carro Pedricarrito = new Carro("Honda", 2022, "Rojo");
if (miCarrito.Modelo > Pedricarrito.Modelo)
{
    Console.WriteLine("El carro del Porofesor Ruldyn es mas reciente");
}
else
{
    Console.WriteLine("El carro de Pedri es modelo mas reciente");
}


Console.WriteLine($"Pedri la marca es {Pedricarrito.Marca}");
Console.WriteLine($"Pedri el modelo de su carro es {Pedricarrito.Modelo}");
Console.WriteLine($"Pedri el color de su carro es {Pedricarrito.Color}");


Console.WriteLine(Pedricarrito.GetVelocidadActual());
Pedricarrito.EncenderMotor();

for (int i = 0; i < 5; i++)
{
    Pedricarrito.acelerar();
}

Pedricarrito.acelerar(180);
Pedricarrito.acelerar(80);
Pedricarrito.acelerar(99);
Pedricarrito.Desacelerar(40);
Pedricarrito.Frenar();
Pedricarrito.Bocinar();
Pedricarrito.ApagarMotor();

