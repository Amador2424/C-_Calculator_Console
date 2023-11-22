// See https://aka.ms/new-console-template for more information

Int16 boucle = 1, choice, i, nb_values;
Double value, multiplication = 1, somme = 0, substraction = 0, division = 0, value_1, value_2;
String repeat = "";
do
{
    do
    {
        Console.WriteLine("\t\t\t\t\t\t\tNUMERIC CALCULATOR");
        Console.WriteLine("\t\t\t\t\t\tMain Menu Operators Choice");
        Console.WriteLine("\t\t\t\t\t\t__________________________");

        Console.WriteLine("\t1- ADDITION\n");
        Console.WriteLine("\t2- DIVISION\n");
        Console.WriteLine("\t3- MULTIPLICATION\n");
        Console.WriteLine("\t4- SUBSTRACTION\n");
        Console.WriteLine("\t5- QUIT\n");

        Console.Write("\tMake your choice (1 - 5) : ");
        choice = Convert.ToInt16(Console.ReadLine());
        Console.Clear();

    } while (choice < 1 || choice > 5);


    do
    {
        if (choice == 1)
        {
            Console.WriteLine("\t\t\t\t\t\tADDITION OPERATION");
            Console.WriteLine("\t\t\t\t\t\t__________________");
            do
            {
                Console.Write("Enter the number of values to add (2-20) : ");
                nb_values = Convert.ToInt16(Console.ReadLine());
            } while (nb_values < 2 || nb_values > 20);


            for (i = 1; i <= nb_values; i++)
            {
                Console.Write("Enter value " + i + " : ");
                value = Convert.ToInt16(Console.ReadLine());

                somme += value;
            }
            Console.WriteLine(" The Result is " + somme);
            Console.WriteLine("Do you want to do another addition (y/n) ? ");
            repeat = Console.ReadLine();
            repeat = repeat.ToLower();
            Console.Clear();
        }
    } while (repeat == "y" || repeat == "yes");


    do
    {
        if (choice == 2)
        {
            Console.WriteLine("\t\t\t\t\t\tDIVISION OPERATION");
            Console.WriteLine("\t\t\t\t\t\t__________________");
            Console.Write("Enter the value to divide : ");
            value_1 = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.Write("Enter the divider (not 0) : ");
                value_2 = Convert.ToDouble(Console.ReadLine());
            } while (value_2 == 0);

            division = value_1 / value_2;


            Console.WriteLine(" The Result is " + division);
            Console.Write("Do you want to do another division (y/n) ? ");
            repeat = Console.ReadLine();
            repeat = repeat.ToLower();
            Console.Clear();
        }
    } while (repeat == "y" || repeat == "yes");



    do
    {
        if (choice == 3)
        {
            do
            {
                Console.WriteLine("\t\t\t\t\t\tMULTIPLICATION OPERATION");
                Console.WriteLine("\t\t\t\t\t\t________________________");
                Console.Write("Enter the number of values to add (2-20) : ");
                nb_values = Convert.ToInt16(Console.ReadLine());
            } while (nb_values < 2 || nb_values > 20);

            for (i = 1; i <= nb_values; i++)
            {
                Console.Write("Enter value " + i + " : ");
                value = Convert.ToInt16(Console.ReadLine());
                multiplication = multiplication * value;
            }
            Console.WriteLine(" The result is " + multiplication);
            Console.WriteLine("Do you want to do another multiplication (y/n) ?");
            repeat = Console.ReadLine();
            repeat = repeat.ToLower();
            Console.Clear();



        }
    } while (repeat == "y" || repeat == "yes");


    do
    {
        if (choice == 4)

        {
            Console.WriteLine("\t\t\t\t\t\tSUBSTRACTION OPERATION");
            Console.WriteLine("\t\t\t\t\t\t______________________");

            Console.Write("Enter the first value : ");
            value_1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter value to substract : ");
            value_2 = Convert.ToDouble(Console.ReadLine());
            while (value_2 == 0) ;

            substraction = value_1 - value_2;


            Console.WriteLine(" The Result is " + substraction);
            Console.Write("Do you want to do another substraction (y/n) ? ");
            repeat = Console.ReadLine();
            repeat = repeat.ToLower();
            Console.Clear();
        }
    } while (repeat == "y" || repeat == "yes");


    if (choice == 5)
    {
        Console.Clear();
        Console.WriteLine("GOODBYE !");
        break;

    }




} while (boucle == 1);










