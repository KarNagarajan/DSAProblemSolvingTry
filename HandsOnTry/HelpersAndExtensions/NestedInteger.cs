using System.Collections.Generic;

namespace HandsOnTry.HelpersAndExtensions
{
    interface NestedInteger
    {
         bool IsInteger();

         int GetInteger();

         IList<NestedInteger> GetList();
    }
}