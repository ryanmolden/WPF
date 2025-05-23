﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Windows.Automation.Provider;
using System.Windows.Controls;

namespace System.Windows.Automation.Peers
{
    ///
    public class ProgressBarAutomationPeer : RangeBaseAutomationPeer, IRangeValueProvider
    {
        ///
        public ProgressBarAutomationPeer(ProgressBar owner): base(owner)
        {
        }

        ///
        protected override string GetClassNameCore()
        {
            return "ProgressBar";
        }

        ///
        protected override AutomationControlType GetAutomationControlTypeCore()
        {
            return AutomationControlType.ProgressBar;
        }

        ///
        public override object GetPattern(PatternInterface patternInterface)
        {
            // Indeterminate ProgressBar should not support RangeValue pattern
            if (patternInterface == PatternInterface.RangeValue && ((ProgressBar)Owner).IsIndeterminate)
                return null;

            return base.GetPattern(patternInterface);
        }

        /// <summary>
        /// Request to set the value that this UI element is representing
        /// </summary>
        /// <param name="val">Value to set the UI to, as an object</param>
        /// <returns>true if the UI element was successfully set to the specified value</returns>
        //[CodeAnalysis("AptcaMethodsShouldOnlyCallAptcaMethods")] //Tracking Bug: 29647
        void IRangeValueProvider.SetValue(double val)
        {
            throw new InvalidOperationException(SR.ProgressBarReadOnly);
        }

        ///<summary>Indicates that the value can only be read, not modified.
        ///returns True if the control is read-only</summary>
        bool IRangeValueProvider.IsReadOnly
        {
            get
            {
                return true;
            }
        }

        ///<summary>Value of a Large Change</summary>
        double IRangeValueProvider.LargeChange
        {
            get
            {
                return double.NaN;
            }
        }

        ///<summary>Value of a Small Change</summary>
        double IRangeValueProvider.SmallChange
        {
            get
            {
                return double.NaN;
            }
        }
    }
}

