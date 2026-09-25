using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            }

            LogSorted(numbers);
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    }
                }
            }

            LogSorted(numbers);
            return numbers;
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }

            LogSorted(numbers);
            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                (numbers[i], numbers[maxIndex]) = (numbers[maxIndex], numbers[i]);
            }

            LogSorted(numbers);
            return numbers;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    }
                }
            }

            LogSorted(numbers);
            return numbers;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] < key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }

            LogSorted(numbers);
            return numbers;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            int[] sorted = (int[])numbers.Clone();
            System.Array.Sort(sorted);
            System.Array.Reverse(sorted);

            int largest = sorted[0];
            for (int i = 1; i < sorted.Length; i++)
            {
                if (sorted[i] < largest)
                {
                    Debug.Log(sorted[i]);
                    return sorted[i];
                }
            }

            Debug.Log(largest);
            return largest;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Debug.Log("The longest consecutive sequence is: 0");
                return 0;
            }

            int[] sorted = (int[])numbers.Clone();
            System.Array.Sort(sorted);

            int longest = 1;
            int current = 1;

            for (int i = 1; i < sorted.Length; i++)
            {
                if (sorted[i] == sorted[i - 1])
                {
                    continue;
                }
                else if (sorted[i] == sorted[i - 1] + 1)
                {
                    current++;
                }
                else
                {
                    current = 1;
                }

                if (current > longest)
                {
                    longest = current;
                }
            }

            Debug.Log($"The longest consecutive sequence is: {longest}");
            return longest;
        }

        #endregion

        private static void LogSorted(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Debug.Log(number);
            }
        }
    }
}