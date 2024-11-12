using System;

class Program
{

    interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    interface IOutput
    {
        void ShowEven();

        void ShowOdd();
    }

    interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }

    public class Array : ICalc, IOutput, ICalc2
    {
        public int[] elements;
        public int count;


        public int CountDistinct()
        {
            int distinctCount = 0;
            for (int i = 0; i < count; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < i; j++)
                {
                    if (elements[i] == elements[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    distinctCount++;
                }
            }
            return distinctCount;
        }

        public int EqualToValue(int valueToCompare)
        {
            int equalCount = 0;
            for (int i = 0; i < count; i++)
            {
                if (elements[i] == valueToCompare)
                {
                    equalCount++;
                }
            }
            return equalCount;
        }

        public Array(int capacity)
        {
            elements = new int[capacity];
            count = 0;
        }

        public void Add(int element)
        {
            if (count == elements.Length)
            {
                Resize();
            }
            elements[count] = element;
            count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Index out of bounds.");
                return;
            }

            for (int i = index; i < count - 1; i++)
            {
                elements[i] = elements[i + 1];
            }

            count--;
        }

        public int Get(int index)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Index out of bounds.");
                return -1;
            }
            return elements[index];
        }

        public int IndexOf(int element)
        {
            for (int i = 0; i < count; i++)
            {
                if (elements[i] == element)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();
        }

        private void Resize()
        {
            int[] newArray = new int[elements.Length * 2];
            for (int i = 0; i < elements.Length; i++)
            {
                newArray[i] = elements[i];
            }
            elements = newArray;
        }

        public int Less(int valueToCompare)
        {
            int lessCount = 0;
            for (int i = 0; i < count; i++)
            {
                if (elements[i] < valueToCompare)
                {
                    lessCount++;
                }
            }
            return lessCount;
        }

        public int Greater(int valueToCompare)
        {
            int greaterCount = 0;
            for (int i = 0; i < count; i++)
            {
                if (elements[i] > valueToCompare)
                {
                    greaterCount++;
                }
            }
            return greaterCount;
        }

        public void ShowEven()
        {
            
            for (int i = 0; i < count; i++)
            {
                if (elements[i] % 2 != 0)
                {
                    Console.WriteLine(elements[i]);
                }
            }
        }

        public void ShowOdd()
        {
            for (int i = 0; i < count; i++)
            {
                if (elements[i] % 2 == 0)
                {
                    Console.WriteLine(elements[i]);
                }
            }
        }
    }

    

    static void Main()
    {
     
    }
}
