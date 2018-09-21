using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    public static class MyExtensions
    {
        public static ICollection<Element> getElementCollection(this ICollection<Element> elements)
        {
            return (ICollection<Element>)elements
                .Where(e => e.age > 20)
                .GroupBy(e => e.num)
                .ToDictionary(grp => grp.Key, grp => grp.First())
                .Select(d => d.Value)
                .ToList();
        }
    }
}
