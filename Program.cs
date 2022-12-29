using System;
class HelloWorld {
  static void Main() {
      string[] tables = new string[10] { "", "", "", "", "", "", "", "", "", ""};
        while (true) 
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a el Sistema de Reservas de Restaurantes 'Ce' \n Inserte su primer nombre: ");
            string userName = Console.ReadLine();
            
            Console.Clear();
            bool isInList = Array.IndexOf(tables, userName) > -1;
            if (isInList)
            {
                for (int i = 0 ; i < tables.Length; i++)
                {
                    string name;
        
                    if (tables[i] == "")
                    {
                        name = "Libre";
                    }
                    else 
                    {
                        name = tables[i];
                    }
                    Console.WriteLine($"{i+1}.- {name}");
                }
                Console.WriteLine("Ya tiene una mesa reservada!, presione cualquier tecla para crear otra reserva...");
                Console.ReadKey();
            }
            else 
            {
                bool invalidNum = true;
                while (invalidNum)
                {
                    Console.WriteLine($"Bienvenido {userName}!\nEstas son las mesas: ");
                    for (int i = 0 ; i < tables.Length; i++)
                    {
                        string name;
            
                        if (tables[i] == "")
                        {
                            name = "Libre";
                        }
                        else 
                        {
                            name = tables[i];
                        }
                        Console.WriteLine($"{i+1}.- {name}");
                    }
                    Console.WriteLine("Si desea reservar alguna mesa seleccione el número de la mesa que desee reservar:");
                    string tableToReserve = Console.ReadLine();
                    int number;
                    bool isNumber = int.TryParse(tableToReserve, out number);
                    if (isNumber)
                    {
                        int numTableToReserve = Convert.ToInt32(tableToReserve);
                        bool isInRange =  numTableToReserve < 11 && numTableToReserve > 0;
                        if (isInRange)
                        {
                            tables[numTableToReserve - 1] = userName;
                            invalidNum = false;
                            Console.Clear();
                            for (int i = 0 ; i < tables.Length; i++)
                            {
                                string name;
                    
                                if (tables[i] == "")
                                {
                                    name = "Libre";
                                }
                                else 
                                {
                                    name = tables[i];
                                }
                                Console.WriteLine($"{i+1}.- {name}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Numero inválido");
                        }
                        
                    }
                    else 
                    {
                        Console.WriteLine("Numero inválido");
                    }
                }
                Console.WriteLine("Desea hacer otra reserva? S/N");
                string answer = Console.ReadLine();
                if (answer == "S")
                {
                    invalidNum = true;
                    continue;
                }
                else if (answer == "N")
                {
                    break;
                }
            }
        }
        Console.Clear();
        Console.WriteLine("Esta es la reserva final:");
        for (int i = 0 ; i < tables.Length; i++)
        {
            string name;

            if (tables[i] == "")
            {
                name = "Libre";
            }
            else 
            {
                name = tables[i];
            }
            Console.WriteLine($"{i+1}.- {name}");
        }
  }
}