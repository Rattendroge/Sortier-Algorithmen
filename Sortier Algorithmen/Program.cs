namespace Sortier_Algorithmen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenRndArrWithSize(out int[] array, 9, 100);
            PrintArray(array);
            Sorters.Bubblesort(array,3);
            PrintArray(array);
        }

        private static void GenRndArrWithSize(out int[] _array, int _arraySize, int _rndNumbersTo)
        {
            _array = new int[_arraySize];

            Random rnd = new Random();

            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = rnd.Next(_rndNumbersTo+1);
            }
        }

        public static void PrintArray(int[] array)//gibt ein komplettes array aus
        {
            string printableArray = "[";//klammer an anfang vom string fürs array
            for (int i = 0;i < array.Length;i++)
            {
                printableArray += array[i] + "," ;//fügt die zahl mit komma im anschluss zum string hinzu
            }
            printableArray = printableArray.Substring(0, printableArray.Length-1);//entfernt letztes komma
            printableArray += "]";//klammer an ende vom string

            Console.WriteLine(printableArray);
        }
    }
}
