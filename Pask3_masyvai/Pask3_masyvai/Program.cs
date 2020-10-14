using System;

namespace Pask3_masyvai
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeriai = new int[] { 1, 10, 15, 30, 90 };
            int kiekis = 5;
            for (int i = 0; i < kiekis; i++)
            {
                if (numeriai[0] > numeriai[i + 1])
                {
                    Console.WriteLine(numeriai[i]);
                }
            }


  
            
        }
    }
}


//int[] manonumeriai = { 9, 6, 1, 88, 1, 1 };


//for (int i = 0; i < manonumeriai.Length; i++)
//{
//    bool isDuplicate = false;

//    for (int j = 0; j < i; j++)
//    {
//        if (manonumeriai[i] == manonumeriai[j])
//        {
//            isDuplicate = true;
//            break;
//        }
//    }

//    if (!isDuplicate)
//    {
//        Console.WriteLine(manonumeriai[i]);
//    }
//}
//Console.ReadLine();
/*
//Console.WriteLine("Irasyti skaiciu ir ataskymas bus ar jis fibonaci skaicius");

//int input = int.Parse(Console.ReadLine());
//int pirmasSk = 1;
//int antrasSk = 1;
//int suma;
//bool result = false;

//do
//{
//    suma = pirmasSk + antrasSk;
//    pirmasSk = antrasSk;
//    antrasSk = suma;

//    if (suma == input)
//    {
//        result = true;
//    }

//} while (suma <= input);
//Console.WriteLine(result);

//string[] names = new string[] { "Tomas", "Jonas", "Petras", "Augustas" };

//Array.Sort(names);

//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}


*/


//int[] manonumeriai = new int[] { 9, 6, 1, 88, 1, 1 };
//bool swapped = true;

//while (swapped)
//{
//    swapped = false;
//    for (int i = 1; i < manonumeriai.Length; i++)
//    {
//        if (manonumeriai[i - 1] > manonumeriai[i])
//        {
//            int temp = manonumeriai[i - 1];
//            manonumeriai[i -1] = manonumeriai[i];
//            manonumeriai[i] = temp;
//            swapped = true;
//        }
//    }
//}

//for (int i = 0; i < manonumeriai.Length; i++)
//{
//    Console.WriteLine(manonumeriai[i]);
//}


/*  for (int i = 0; i < manonumeriai.Length; i++)
            {
                for (int j = i + 1; j < manonumeriai.Length; j++)
                {
                    if (manonumeriai[i] > manonumeriai[j])
                    {
                        manonumeriai[i] = manonumeriai[i] + manonumeriai[j];
                        manonumeriai[j] = manonumeriai[i] - manonumeriai[j];
                        manonumeriai[i] = manonumeriai[i] - manonumeriai[j];
                    }
                }
            }
           */
