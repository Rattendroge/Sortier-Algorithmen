using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortier_Algorithmen
{
    internal static class Sorters
    {
        private static void SortType(int _input, int[] _array)
        {
            int tempNum;
            switch (_input)
            {
                case 1://aufsteigend von klein zu groß
                    break;

                case 2://absteigend von groß zu klein
                    for (int i = 0; i < _array.Length / 2; i++)//bis zur hälfte des arrays
                    {
                        tempNum = _array[i];//zwei zahlen tauschen; erste und letzte zahl tauschen dann zweite und vorletzte usw.
                        _array[i] = _array[_array.Length - i -1];
                        _array[_array.Length - i - 1] = tempNum;
                    }
                    break;

                case 3://zickzack
                    int[] tempArray = new int[_array.Length];
                    int j = 0;
                    for (int i = _array.Length - 1; i >= _array.Length / 2; i--)//nimmt die größten zahlen (bis zur halben größe des arrays, da nach der hälfte die kleinsten zahlen kommen) und setzt sie von index 0 angefangen jede zweite stelle
                    {
                        tempArray[j] = _array[i];
                        j += 2;
                    }

                    j = 1;

                    for(int i = 0; i < _array.Length / 2; i++)//nimmt die kleinsten zahlen und setzt sie von index 1 angefangen in jede zweite stelle
                    {
                        tempArray[j] = _array[i];
                        j += 2;
                    }
                    for (int i = 0; i < _array.Length; i++)//setzt die zahlen ins richtige array
                    {
                        _array[i] = tempArray[i];
                    }
                    break;
            }
        }
        #region Bubblesort
        public static void Bubblesort(int[] _array)
        {
            int tempNum;//speichert nur kurz eine zahl zum tauschen zweier zahlen im array
            for (int i = _array.Length - 1; i > 0; i--)//größte zahl immer am ende deshalb wir der index bis wohin verglichen wird (i) immer kleiner
            {
                for(int j = 0; j < i; j++)//geht immer den unsortierten part des arrays durch
                {
                    if (_array[j] > _array[j + 1])//wenn die als nächstes kommende zahl kleiner ist werden die beiden getauscht
                    {
                        tempNum = _array[j];//zwei zahlen tauschen
                        _array[j] = _array[j + 1];
                        _array[j + 1] = tempNum;
                    }
                }
            }
        }

        public static void Bubblesort(int[] _array, int _input) // mit input für anderes ausgeben der sortierten reihe; 1=aufsteigend von klein zu groß, 2=absteigend von groß zu klein, 3=zickzack
        {
            int tempNum;//speichert nur kurz eine zahl zum tauschen zweier zahlen im array
            for (int i = _array.Length - 1; i > 0; i--)//größte zahl immer am ende deshalb wir der index bis wohin verglichen wird (i) immer kleiner
            {
                for (int j = 0; j < i; j++)//geht immer den unsortierten part des arrays durch
                {
                    if (_array[j] > _array[j + 1])//wenn die als nächstes kommende zahl kleiner ist werden die beiden getauscht
                    {
                        tempNum = _array[j];//zwei zahlen tauschen
                        _array[j] = _array[j + 1];
                        _array[j + 1] = tempNum;
                    }
                }
            }
            Program.PrintArray(_array);
            SortType(_input, _array);
        }
        #endregion

        #region Selectionsort
        public static void Selectionsort(int[] _array)
        {
            int minIndex;//für den index der kleinsten noch nicht sortierten zahl im array
            int tempNum;//speichert nur kurz eine zahl zum tauschen zweier zahlen im array
            for(int i = 0; i < _array.Length - 1; i++)//index ab wo sortiert werden muss alles kleiner als i ist dann schon sortiert
            {
                minIndex = i;//setzt den minIndex immer auf die erste zahl die noch nicht sortiert ist
                for (int j = i;j < _array.Length; j++)//geht immer den unsortierten part des arrays durch
                {
                    if (_array[minIndex] > _array[j])//checkt ob eine zahl kleiner ist als die bisherige und setzt dessen index auf den minIndex
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)//wenn minIndex = i ist brauch nicht getauscht werden da die zahl dann schon an der richtigen stelle ist
                {
                    tempNum = _array[i];//zwei zahlen tauschen
                    _array[i] = _array[minIndex];
                    _array[minIndex] = tempNum;
                }
            }
        }

        public static void Selectionsort(int[] _array,int _input) // mit input für anderes ausgeben der sortierten reihe; 1=aufsteigend von klein zu groß, 2=absteigend von groß zu klein, 3=zickzack
        {
            int minIndex;//für den index der kleinsten noch nicht sortierten zahl im array
            int tempNum;//speichert nur kurz eine zahl zum tauschen zweier zahlen im array
            for (int i = 0; i < _array.Length - 1; i++)//index ab wo sortiert werden muss alles kleiner als i ist dann schon sortiert
            {
                minIndex = i;//setzt den minIndex immer auf die erste zahl die noch nicht sortiert ist
                for (int j = i; j < _array.Length; j++)//geht immer den unsortierten part des arrays durch
                {
                    if (_array[minIndex] > _array[j])//checkt ob eine zahl kleiner ist als die bisherige und setzt dessen index auf den minIndex
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)//wenn minIndex = i ist brauch nicht getauscht werden da die zahl dann schon an der richtigen stelle ist
                {
                    tempNum = _array[i];//zwei zahlen tauschen
                    _array[i] = _array[minIndex];
                    _array[minIndex] = tempNum;
                }
            }
            SortType(_input, _array);
        }
        #endregion

        #region Insertionsort
        public static void Insertionsort(int[] _array)
        {
            int tempNum;
            for(int i = 0; i < _array.Length - 1; i++ )//start index von dem angefangen wird zu checken
            {
                for(int j = i + 1; j > 0; j--)//fängt bei i + 1 an zu sortieren
                {
                    if (_array[j] < _array[j-1])//wenn die zahl kleiner als die davor ist wird getauscht
                    {
                        tempNum = _array[j];//zwei zahlen tauschen
                        _array[j] = _array[j-1];
                        _array[j-1] = tempNum;
                    }
                    else//wenn nicht getauscht werden musste müssen die folgenden zahlen nicht verglichen werden da sie bereits geordnet sind
                    {
                        break;
                    }
                }
            }
        }

        public static void Insertionsort(int[] _array, int _input)// mit input für anderes ausgeben der sortierten reihe; 1=aufsteigend von klein zu groß, 2=absteigend von groß zu klein, 3=zickzack
        {
            int tempNum;
            for (int i = 0; i < _array.Length - 1; i++)//start index von dem angefangen wird zu checken
            {
                for (int j = i + 1; j > 0; j--)//fängt bei i + 1 an zu sortieren
                {
                    if (_array[j] < _array[j - 1])//wenn die zahl kleiner als die davor ist wird getauscht
                    {
                        tempNum = _array[j];//zwei zahlen tauschen
                        _array[j] = _array[j - 1];
                        _array[j - 1] = tempNum;
                    }
                    else//wenn nicht getauscht werden musste müssen die folgenden zahlen nicht verglichen werden da sie bereits geordnet sind
                    {
                        break;
                    }
                }
            }
            SortType(_input, _array);
        }
        #endregion

        //public static void Quicksort(int[] _array)
        //{
        //    int tempNum;
        //    int pivotIndex;
        //    int[] tempArray = {_array[0], _array[(int)_array.Length / 2], _array[_array.Length]};
        //    Bubblesort(tempArray);
        //}
    }
}
