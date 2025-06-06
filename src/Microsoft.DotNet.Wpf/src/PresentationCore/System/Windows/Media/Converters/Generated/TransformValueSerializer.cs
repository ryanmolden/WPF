// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

//
//
// This file was generated, please do not edit it directly.
//
// Please see MilCodeGen.html for more information.
//

using MS.Internal;
using MS.Internal.KnownBoxes;
using MS.Internal.Collections;
using MS.Utility;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows.Media.Effects;
using System.Windows.Media.Animation;
using System.Windows.Media.Composition;
using System.Windows.Markup;
using System.Windows.Media.Converters;

namespace System.Windows.Media.Converters
{
    /// <summary>
    /// TransformValueSerializer - ValueSerializer class for converting instances of strings to and from Transform instances
    /// This is used by the MarkupWriter class.
    /// </summary>
    public class TransformValueSerializer : ValueSerializer 
    {
        /// <summary>
        /// Returns true.
        /// </summary>
        public override bool CanConvertFromString(string value, IValueSerializerContext context)
        {
            return true;
        }

        /// <summary>
        /// Returns true if the given value can be converted into a string
        /// </summary>
        public override bool CanConvertToString(object value, IValueSerializerContext context)
        {
            // When invoked by the serialization engine we can convert to string only for some instances
            if (!(value is Transform))
            {
                return false;
            }

            Transform instance  = (Transform) value;

            return instance.CanSerializeToString();
        }

        /// <summary>
        /// Converts a string into a Transform.
        /// </summary>
        public override object ConvertFromString(string value, IValueSerializerContext context)
        {
            if (value != null)
            {
                return Transform.Parse(value );
            }
            else
            {
                return base.ConvertFromString( value, context );
            }
        }

        /// <summary>
        /// Converts the value into a string.
        /// </summary>
        public override string ConvertToString(object value, IValueSerializerContext context)
        {
            if (value is Transform instance)
            {
                // When invoked by the serialization engine we can convert to string only for some instances
                if (!instance.CanSerializeToString())
                {
                    // Let base throw an exception.
                    return base.ConvertToString(value, context);
                }

                return instance.ConvertToString(null, System.Windows.Markup.TypeConverterHelper.InvariantEnglishUS);
            }

            return base.ConvertToString(value, context);
        }
    }
}
