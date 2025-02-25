using System;

#if NETFX
namespace MS.Internal
{
    internal static class SortHelper
    {
        public static void Sort<T>(this Span<T> span, Comparison<T> comparison)
        {
            Array.Sort(span.ToArray(), comparison);
        }
    }
}
#endif
