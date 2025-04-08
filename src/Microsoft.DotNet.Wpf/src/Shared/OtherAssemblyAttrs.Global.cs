// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#if NETFX
#if SYSTEM_XAML
global using ArgumentNullException = System.Xaml.ArgumentNullException;
#endif

#if PRESENTATION_CORE || PRESENTATIONFRAMEWORK || WINDOWS_BASE
global using NativeMethods = MS.Win32.NativeMethods;
#endif

#if PRESENTATIONFRAMEWORK || WINDOWS_BASE
global using UnsafeNativeMethods = MS.Win32.UnsafeNativeMethods;
#endif

#if WINDOWS_BASE
global using FriendAccessAllowedAttribute = MS.Internal.WindowsBase.FriendAccessAllowedAttribute;
global using Signature = System.Security.Cryptography.Xml.Signature;
#endif

#if PRESENTATION_CORE
namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    internal sealed class ModuleInitializerAttribute : Attribute
    {
    }
}
#endif

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
