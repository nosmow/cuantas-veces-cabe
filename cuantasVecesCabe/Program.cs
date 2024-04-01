using cuantasVecesCabe;

try
{
    Operacion op = new Operacion();

    Console.WriteLine("Por favor ingrese el primer número mayor a 1000 y el segundo menor a 100");

    op.setNum1();
    op.setNum2();
    Console.WriteLine("\nCabe: " + op.Calculo() + " veces");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
