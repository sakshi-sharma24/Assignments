using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class StandInLine
    {
        int[] Reconstruct(int[] left)
        {
            int[] final = left;
            int index = left.Length - 1;
            List<int> queue = new List<int>();
            while(index>=0)
            {
                int value_at_index = index + 1;
                queue.Insert(left[index],value_at_index);
                index--;

            }

            return queue.ToArray();
 }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            StandInLine standInLine = new StandInLine();
            do
            {
                int[] left = Array.ConvertAll<string, int>(input.Split(','), delegate (string s) { return Int32.Parse(s); });
                Console.WriteLine(string.Join(",", Array.ConvertAll<int, string>(standInLine.Reconstruct(left), delegate (int s) { return s.ToString(); })));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}
