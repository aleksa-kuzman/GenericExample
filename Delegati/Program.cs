using System;
using System.Collections.Generic;

namespace Delegati
{
    public delegate int MyDelegate(int a, int b);

    internal class Program
    {
        private static void Main(string[] args)
        {
            //#region old

            //MyDelegate myDelegate = new MyDelegate(Add);

            //Console.WriteLine(MyFunction(myDelegate, 2, 3));

            //myDelegate = Subtract;

            //Console.WriteLine(MyFunction(myDelegate, 3, 2));

            //GenericClass<string> genericInstance = new GenericClass<string>();

            //genericInstance.SetGenericAttribute("Zdravo ja sam genericki atribut");
            //Console.WriteLine(genericInstance.Print());

            //GenericClass<int> genericInstance2 = new GenericClass<int>();
            //genericInstance2.SetGenericAttribute(33);

            //Console.WriteLine(genericInstance2.Print());

            //Auto a = new Auto("BMW", "NE znam", 1999);
            //Radnik r = new Radnik("Pera", "Peric", "Racunovodja");

            //GenericClass<Auto> generiAuto = new GenericClass<Auto>();
            //GenericClass<Radnik> genericRadnik = new GenericClass<Radnik>();

            //generiAuto.SetGenericAttribute(a);
            //genericRadnik.SetGenericAttribute(r);

            //Console.WriteLine(generiAuto.Print());
            //Console.WriteLine(genericRadnik.Print());

            //#endregion old

            Radnik r = new Radnik("Pera", "Peric", "Racunovodja");

            Radnik r1 = new Radnik("Aera", "Peric", "Biciklista");
            Radnik r2 = new Radnik("Dera", "Peric", "Fudbaler");

            Radnik r3 = new Radnik("Eera", "Peric", "Programer");

            Radnik r4 = new Radnik("Pera", "Jovanovic", "Racunovodja");

            HashSet<Radnik> radnici = new HashSet<Radnik>();

            radnici.Add(r);
            radnici.Add(r1);
            radnici.Add(r2);
            radnici.Add(r3);

            radnici.Add(r4);

            Radnik r5 = new Radnik("Pera", "Jovanovic", "Racunovodja");
            Radnik r6 = new Radnik("Dragan", "Dragic", "Profesor");

            HashSet<Radnik> drugiRadnici = new HashSet<Radnik>();

            drugiRadnici.Add(r5);
            drugiRadnici.Add(r6);

            radnici.IntersectWith(drugiRadnici);

            foreach (var item in radnici)
            {
                Console.WriteLine(item);
            }

            radnici.UnionWith(drugiRadnici);

            Console.WriteLine("Ovo dole je unija");

            foreach (var item in radnici)
            {
                Console.WriteLine(item);
            }
        }

        public static int MyFunction(MyDelegate function, int a, int b)
        {
            int result = function(a, b);

            return result;
        }

        public static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public static int Subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }
    }
}