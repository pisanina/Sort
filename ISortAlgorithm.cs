using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
  public interface ISortAlgorithm
    {
      IComparable[] SortRun(IComparable[] ArrayToSort);
    }
}
