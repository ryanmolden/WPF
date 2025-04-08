using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WinRT.Interop;

#if NETFX
namespace System.Runtime.InteropServices
{
    internal abstract partial class ComWrappers
    {
        /// <summary>
        /// Interface type and pointer to targeted VTable.
        /// </summary>
        public struct ComInterfaceEntry
        {
            public Guid IID;
            public IntPtr Vtable;
        }
    }
}

namespace WinRT
{
    internal static partial class ComWrappersSupport
    {
        public static readonly ConditionalWeakTable<object, InspectableInfo> InspectableInfoTable = new ConditionalWeakTable<object, InspectableInfo>();

        public static unsafe InspectableInfo GetInspectableInfo(IntPtr pThis)
        {
            var _this = FindObject<object>(pThis);
            return InspectableInfoTable.GetValue(_this, o => PregenerateNativeTypeInformation(o).inspectableInfo);
        }

        public static object CreateRcwForComObject(IntPtr ptr)
        {
            return Marshal.GetObjectForIUnknown(ptr);
        }

        public static void RegisterObjectForInterface(object obj, IntPtr thisPtr) => TryRegisterObjectForInterface(obj, thisPtr);

        public static object TryRegisterObjectForInterface(object obj, IntPtr thisPtr) => Marshal.GetObjectForIUnknown(thisPtr);

        public static IObjectReference CreateCCWForObject(object obj)
        {
            IntPtr ccw = Marshal.GetIUnknownForObject(obj);
            return ObjectReference<IUnknownVftbl>.Attach(ref ccw);
        }

        public static unsafe T FindObject<T>(IntPtr ptr)
            where T : class => (T)Marshal.GetObjectForIUnknown(ptr);

        private static T FindDelegate<T>(IntPtr thisPtr)
            where T : class, System.Delegate => FindObject<T>(thisPtr);

        public static IUnknownVftbl IUnknownVftbl { get; private set; }

        public static IntPtr AllocateVtableMemory(Type vtableType, int size) => Marshal.AllocHGlobal(size);

        static unsafe partial void PlatformSpecificInitialize()
        {
            IntPtr pUnk = Marshal.GetIUnknownForObject(new object());

            IUnknownVftbl = new IUnknownVftbl
            {
                QueryInterface = Marshal.GetDelegateForFunctionPointer<IUnknownVftbl._QueryInterface>(new IntPtr((*(void***)pUnk)[0])),
                AddRef = Marshal.GetDelegateForFunctionPointer<IUnknownVftbl._AddRef>(new IntPtr((*(void***)pUnk)[1])),
                Release = Marshal.GetDelegateForFunctionPointer<IUnknownVftbl._Release>(new IntPtr((*(void***)pUnk)[2])),
            };

            Marshal.Release(pUnk);
        }
    }
}
#endif
