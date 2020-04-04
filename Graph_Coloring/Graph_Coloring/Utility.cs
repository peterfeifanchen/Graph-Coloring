using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Graph_Coloring {
    class Utility {
        public static int[] Permutation(int n, Random rand) {
            int[] arr = IdentityPermutation(n);

            for (int i = 1; i < n; i++) {
                int j = rand.Next(0, i + 1);
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            return arr;

        }

        public static int[] InvertPermutation(int[] perm) {
            int n = perm.Length;
            int[] inv = new int[n];

            for (int i = 0; i < n; i++)
                inv[perm[i]] = i;

            return inv;

        }

        public static int[] IdentityPermutation(int n) {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = i;

            return arr;

        }

        public static string ArrayToString(int[] arr) {
            return ArrayToString(arr, false);
        }


        public static string ArrayToString(int[] arr, bool showLength) {
            StringBuilder sb = new StringBuilder();
            int n = arr.Length;

            if (showLength)
                sb.Append(n + ": ");

            sb.Append("[");
            for (int i = 0; i < n - 1; i++)
                sb.Append(arr[i] + ", ");
            sb.Append(arr[n - 1]);


            sb.Append("]");

            return sb.ToString();

        }

        public static int[] ArrayToCount(int[] arr) {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];

            int[] countArray = new int[max + 1];
            for (int i = 0; i < countArray.Length; i++)
                countArray[i] = 0;

            for (int i = 0; i < arr.Length; i++)
                countArray[arr[i]]++;

            return countArray;

        }

        public static string MatrixToString(int[][] arr) {
            int n = arr.Length;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++) {
                sb.Append(ArrayToString(arr[i]));
                sb.Append("\r\n");
            }



            return sb.ToString();
        }

        public static int[] InitIntArray(int n, int val) {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
                array[i] = val;
            return array;
        }

        public static int ArrayMax(int[] arr) {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];

            return max;

        }

        public static int CountIf(int[] arr, int val) {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == val)
                    count++;
            return count;
        }

        public static bool StringToFile(string[] strings) {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog()) {

                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    string filePath = saveFileDialog.FileName;
                    System.IO.File.WriteAllLines(filePath, strings);
                }
            }

            return true;
        }
    }
}
