﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

//
// 
// Description: Contains base class for DrawingContext iterators
//

namespace System.Windows.Media
{
    /// <summary>
    /// DrawingContextWalker : The base class for DrawingContext iterators.
    /// This is *not* thread safe
    /// </summary>
    internal abstract partial class DrawingContextWalker : DrawingContext
    {
        /// <summary>
        /// Constructor for DrawingContextWalker
        /// </summary>
        protected DrawingContextWalker()
        {
            // Nothing to do here
        }       

        /// <summary>
        /// DrawingContextWalker implementations are never opened, so they shouldn't be closed.
        /// </summary>
        public sealed override void Close()
        {
            Debug.Assert(false);
        }

        #region Protected methods

        /// <summary>
        /// DrawingContextWalker implementations are never opened, so they shouldn't be disposed.
        /// </summary>
        protected override void DisposeCore()
        {
            Debug.Assert(false);
        }

        /// <summary>
        /// StopWalking - If this called, the current walk will stop.
        /// </summary>
        protected void StopWalking()
        {
            _stopWalking = true;
        }

        #endregion Protected methods

        #region Internal properties

        /// <summary>
        /// ShouldStopWalking Property - internal clients can consult this property to determine
        /// whether or not the implementer of this DrawingContextWalker has called StopWalking.
        /// This can also be set by internal callers.
        /// </summary>
        internal bool ShouldStopWalking
        {
            get
            {
                return _stopWalking;
            }
            set
            {
                _stopWalking = value;
            }
        }              

        #endregion Internal properties        

        #region Private Members

        private bool _stopWalking;
        #endregion Private Members
    }
}


