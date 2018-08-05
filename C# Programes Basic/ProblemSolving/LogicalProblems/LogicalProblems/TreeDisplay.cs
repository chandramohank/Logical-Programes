using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class TreeDisplay
    {
        public int VLevel { get; set; }

        public int HLevel { get; set; }

        public static void Display(List<TreeDisplay> treeNodes)
        {
            var temp = treeNodes.GroupBy(x => x.VLevel).OrderBy(x => x.Key);

            foreach (var item in temp)
            {
                Console.WriteLine(item.Key);
                Console.Write(string.Join("\t", treeNodes.Where(x => x.VLevel == item.Key).Distinct().Select(x => x.HLevel).Distinct()));
                Console.WriteLine();
            }
        }
    }
}
