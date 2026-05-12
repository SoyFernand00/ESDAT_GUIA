using Practica_para_T1;
int op = 0; 
Lista lista = new Lista();
while (op != 9)
{
    Console.WriteLine("Bienvenido a la practica de T1");
    Console.WriteLine("Opciones:");
    Console.WriteLine("1. Insertar al inicio");
    Console.WriteLine("2. Insertar al final");
    Console.WriteLine("3. Eliminar al inicio");
    Console.WriteLine("4. Eliminar al final");
    Console.WriteLine("5. Mostrar la lista");
    Console.WriteLine("6. Mostrar la lista al reves");
    Console.WriteLine("7. Eliminar un valor");
    Console.WriteLine("8. Mezclar con otra lista");
    Console.WriteLine("9. Salir");
    Console.WriteLine("Ingrese una opción:");
    int ops = int.Parse(Console.ReadLine());

    switch (ops)
    {
        case 1:
            Console.WriteLine("Ingrese el valor a insertar al inicio:");
            string valorIni = Console.ReadLine();
            lista.insertarini(valorIni);
            Console.Clear();
            break;

        case 2:
            Console.WriteLine("Ingrese el valor a insertar al final:");
            string valorFin = Console.ReadLine();
            lista.insertarfinal(valorFin);
            break;

        case 3:
            lista.eliminarini();
            break;

        case 4:
            lista.eliminarfinal();
            break;

        case 5:
            Console.Clear();
            Console.WriteLine("La lista es:");
            lista.mostrar();
            break;

        case 6:
            lista.mostrarinverso();
            break;

        case 7:
            Console.WriteLine("Ingrese el valor a eliminar:");
            string valorEliminar = Console.ReadLine();
            lista.eliminar(valorEliminar);
            break;

        case 8:
            Lista otraLista = new Lista();

            Console.WriteLine("Ingrese valores para la segunda lista:");
            string valores2 = Console.ReadLine();

            foreach (string valor in valores2.Split(','))
            {
                otraLista.insertarfinal(valor.Trim());
            }

            lista.mezclar(otraLista);
            break;
        case 9:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opción no válida, por favor intente de nuevo.");
            break;
    }
}