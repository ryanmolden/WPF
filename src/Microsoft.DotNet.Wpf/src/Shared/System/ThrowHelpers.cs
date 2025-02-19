using System.Runtime.CompilerServices;

#nullable enable

#if NETFX
namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    internal sealed class CallerArgumentExpressionAttribute : Attribute
    {
        public CallerArgumentExpressionAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }

        public string ParameterName { get; }
    }
}
#endif

namespace System
{
    internal static class ThrowHelpers
    {
        public static void ThrowIfNull(object? value, [CallerArgumentExpression(nameof(value))] string? paramName = null)
        {
            if (value == null)
                throw new ArgumentNullException(paramName);
        }
    }
}
