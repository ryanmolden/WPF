using System.Runtime.CompilerServices;

#nullable enable

#if NETFX
// These are duplicated in multiple namespaces because it minimizes the changes required to clean up references to
// ArgumentNullException.ThrowIfNull which is a static helper that doesn't exist in NETFX

#if SYSTEM_XAML
namespace System.Windows.Markup
{
    internal class ArgumentNullException : System.ArgumentNullException
    {
        public ArgumentNullException(string? paramName)
            : base(paramName)
        {
        }

        public static void ThrowIfNull(object? value, [CallerArgumentExpression(nameof(value))] string? paramName = null)
        {
            if (value == null)
                throw new System.ArgumentNullException(paramName);
        }
    }
}
#endif

#if PRESENTATION_CORE || SYSTEM_XAML
namespace System.Xaml
{
    internal class ArgumentNullException : System.ArgumentNullException
    {
        public ArgumentNullException(string? paramName)
            : base(paramName)
        {
        }

        public ArgumentNullException(string? message, Exception innerException)
            : base(message, innerException)
        {
        }

        public static void ThrowIfNull(object? value, [CallerArgumentExpression(nameof(value))] string? paramName = null)
        {
            if (value == null)
                throw new System.ArgumentNullException(paramName);
        }
    }
}
#endif
#endif
