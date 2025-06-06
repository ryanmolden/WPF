// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

//

namespace System.Windows.Media
{
    /// <summary>
    /// Enum controls behavior when a positive hit occurs during hit testing.
    /// </summary>
    public enum HitTestResultBehavior 
    {
        /// <summary>
        /// Stop any further hit testing and return.
        /// </summary>
        Stop,
        
        /// <summary>
        /// Continue hit testing against next visual.
        /// </summary>
        Continue
    };
    
    /// <summary>
    /// Delegate for hit tester to control returning of hit information on visual.
    /// </summary>
    public delegate HitTestResultBehavior HitTestResultCallback(HitTestResult result);
}

