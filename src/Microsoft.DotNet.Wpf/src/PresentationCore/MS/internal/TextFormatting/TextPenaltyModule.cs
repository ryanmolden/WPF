// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Windows.Media.TextFormatting;

namespace MS.Internal.TextFormatting
{
    /// <summary>
    /// Critical handle wrapper of unmanaged text penalty module. This class
    /// is used exclusively by Framework thru friend-access. It provides direct
    /// access to the underlying dangerous handle to the unmanaged resource whose
    /// lifetime is bound to the the underlying LS context.
    /// </summary>
    internal sealed class TextPenaltyModule : IDisposable
    {
        private IntPtr  _ploPenaltyModule;  // Pointer to LS penalty module
        private bool    _isDisposed;


        /// <summary>
        /// This constructor is called by PInvoke when returning the critical handle
        /// </summary>
        internal TextPenaltyModule(IntPtr ploc)
        {
            IntPtr ploPenaltyModule;
            LsErr lserr = UnsafeNativeMethods.LoAcquirePenaltyModule(ploc, out ploPenaltyModule);
            if (lserr != LsErr.None)
            {
                TextFormatterContext.ThrowExceptionFromLsError(SR.Format(SR.AcquirePenaltyModuleFailure, lserr), lserr);
            }

            _ploPenaltyModule = ploPenaltyModule;
        }


        /// <summary>
        /// Finalize penalty module
        /// </summary>
        ~TextPenaltyModule()
        {
            Dispose(false);
        }


        /// <summary>
        /// Explicitly clean up penalty module
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        private void Dispose(bool disposing)
        {
            if (_ploPenaltyModule != IntPtr.Zero)
            {
                UnsafeNativeMethods.LoDisposePenaltyModule(_ploPenaltyModule);
                _ploPenaltyModule = IntPtr.Zero;
                _isDisposed = true;
                GC.KeepAlive(this);
            }
        }


        /// <summary>
        /// This method should only be called by Framework to authorize direct access to
        /// unsafe LS penalty module for exclusive use of PTS during optimal paragraph 
        /// penalty calculation.
        /// </summary>
        internal IntPtr DangerousGetHandle()
        {
            if (_isDisposed)
            {
                throw new ObjectDisposedException(SR.TextPenaltyModuleHasBeenDisposed);
            }

            IntPtr penaltyModuleInternalHandle;
            LsErr lserr = UnsafeNativeMethods.LoGetPenaltyModuleInternalHandle(_ploPenaltyModule, out penaltyModuleInternalHandle);

            if (lserr != LsErr.None)
                TextFormatterContext.ThrowExceptionFromLsError(SR.Format(SR.GetPenaltyModuleHandleFailure, lserr), lserr);

            GC.KeepAlive(this);
            return penaltyModuleInternalHandle;
        }
    }
}

