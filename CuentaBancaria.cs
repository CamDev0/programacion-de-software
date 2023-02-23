using System;

public class CuentaBancaria
{
	string Nombre, Apellido, Direccion, NIT;
	double Saldo;

	//constructor
	public CuentaBancaria(string NombrePA, string ApellidoPA, string DireccionPA, string NITPA, double saldoPA )
	{
		Nombre = NombrePA;
		Apellido = ApellidoPA;	
		Direccion= DireccionPA;	
		NIT = NITPA;
		Saldo = saldoPA;
	}

	public double Deposito(double moreMoney)
	{
		Saldo += moreMoney;
        Console.WriteLine("\nOperación realizada con éxito.\n");
        return Saldo;
	}

    public double Retiro (double lessMoney)
    {
		if (Saldo >= lessMoney)
		{
			Saldo -= lessMoney;
			Console.WriteLine("\nOperación realizada con éxito.\n");
			return Saldo;
		}
		else
		{
			Console.WriteLine("\nEl monto a retirar supera su ahorro, por favor verifique su saldo.\n");
			return Saldo;
		}

    }

    public void ConsultaSaldo()
    {
		Console.Write("Su saldo actual es de: " + Saldo + "\n\n");
    }

	public string ToString()
	{
		string datos = ("\nNombre: " + Nombre + "\nApellido: " + Apellido + "\nDirección: " + Direccion + "\nNIT: " + NIT + "\n" );
		Console.WriteLine(datos);
		return datos;
	}

}
