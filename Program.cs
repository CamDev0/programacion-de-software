

namespace ejercicioPOO
{
    class Principal
    {
        public static void Main(string[] args)
        {
            string Nombre, Apellido, Direccion, NIT;
            double Saldo;
            int num;

            Console.WriteLine("Ingrese el Nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el Apellido: ");
            Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la Dirección: ");
            Direccion = Console.ReadLine();

            Console.WriteLine("Ingrese el NIT: ");
            NIT = Console.ReadLine();

            Console.WriteLine("Ingrese el saldo inicial de su cuenta: ");
            Saldo = Double.Parse(Console.ReadLine());

            CuentaBancaria lector = new CuentaBancaria(Nombre, Apellido, Direccion, NIT, Saldo);
            
            Console.Write("\n ********************\n\n");
            
            do
            {

            Console.WriteLine("1.Deposito" + "\n" + 
                              "2.Retiro" + "\n" +
                              "3.Consultar Saldo" + "\n" + 
                              "4.Consultar Datos" +"\n" + 
                              "5. Salir" + "\n");
            num = Int32.Parse(Console.ReadLine());
                
                switch (num)
                {

                 case 1: Console.Write("*** DEPOSITO ***\n\n");
                        Console.WriteLine("Ingrese el saldo a depositar: ");
                        double newSaldo = Double.Parse(Console.ReadLine());
                        lector.Deposito(newSaldo);
                        break;

                case 2:
                        Console.Write("*** RETIRO *** \n\n");
                        Console.WriteLine("Ingrese el saldo a retirar: ");
                        double newSaldoR = Double.Parse(Console.ReadLine());
                        lector.Retiro(newSaldoR);
                        break;

                case 3:
                        Console.Write("*** CONSULTA DE SALDO ***\n\n");
                        lector.ConsultaSaldo();
                        break;

                case 4:
                        Console.Write("*** CONSULTA DE DATOS ***\n\n ");
                        lector.ToString();
                        break;

                }

            } while (num != 5);
            
            
        }
    }
}