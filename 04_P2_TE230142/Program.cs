Console.WriteLine("SISTEMA DE CONTROL DE CARGA DE BATERÍA");
Console.WriteLine();

ControlBateria bateria1 = new ControlBateria();// se crea una clase de control de batería y el objeto de la clase se llama bateria1

Console.Write("Ingrese el voltaje inicial de la batería (V): ");// se solicita al usuario que ingrese el voltaje inicial de la batería
bateria1.VoltajeActual = Convert.ToDouble(Console.ReadLine());// se convierte el valor ingresado por el usuario a un tipo de dato double y se asigna a la propiedad VoltajeActual del objeto bateria1

Console.Write("Ingrese el incremento de voltaje por ciclo (V): ");// se solicita al usuario que ingrese el incremento de voltaje por ciclo
bateria1.Incremento = Convert.ToDouble(Console.ReadLine());// se convierte el valor ingresado por el usuario a un tipo de dato double y se asigna a la propiedad Incremento del objeto bateria1

Console.WriteLine("\n--- INICIO DEL PROCESO DE CARGA ---");// se imprime un mensaje indicando el inicio del proceso de carga
while (bateria1.VoltajeActual < 12.6)// se inicia un bucle while que se ejecuta mientras el voltaje actual de la batería sea menor a 12.6 V
{
    bateria1.Ciclo++;// se incrementa el contador de ciclos en 1
    bateria1.VoltajeActual += bateria1.Incremento;// se incrementa el voltaje actual de la batería en el valor del incremento por ciclo

    if (bateria1.VoltajeActual > 12.6)// si el voltaje actual de la batería supera los 12.6 V, se ajusta a 12.6 V
    {
        bateria1.VoltajeActual = 12.6;// si el voltaje actual de la batería supera los 12.6 V, se ajusta a 12.6 V
    }
    Console.WriteLine($"Ciclo {bateria1.Ciclo}: Voltaje actual = {bateria1.VoltajeActual:F2} V");// se imprime el número de ciclo y el voltaje actual de la batería con dos decimales
}

Console.WriteLine("\n¡Carga completa! La batería ha alcanzado el límite objetivo de 12.6 V.");// se imprime un mensaje indicando que la carga de la batería ha finalizado y ha alcanzado el límite objetivo de 12.6 V

class ControlBateria// se define la clase ControlBateria
{
    public double VoltajeActual { get; set; }// se define la propiedad VoltajeActual de tipo double con métodos get y set
    public double Incremento { get; set; }// se define la propiedad Incremento de tipo double con métodos get y set
    public int Ciclo { get; set; } = 0;// se define la propiedad Ciclo de tipo int con métodos get y set, inicializada en 0
}