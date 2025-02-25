namespace System.Windows.Xps.Serialization
{
    internal static class ReachStringHelper
    {
        public static string Concat(string valueAsString, int index)
        {
#if NET
            var substring = index > 0 ? valueAsString.AsSpan(index + 1) : valueAsString;
#else
            var substring = index > 0 ? valueAsString.Substring(index + 1) : valueAsString;
#endif

            return string.Concat(XpsSerializationManager.TypeOfString, substring, "}");
        }
    }
}
