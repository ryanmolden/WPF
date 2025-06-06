// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System.Windows.Markup;

[assembly: XmlnsDefinition(
    "http://schemas.microsoft.com/xps/2005/06/documentstructure",
    "System.Windows.Documents.DocumentStructures")]

namespace System.Windows.Documents.DocumentStructures
{
    /// <summary>
    ///
    /// </summary>
    public class BlockElement
    {
        internal FixedElement.ElementType ElementType
        {
            get { return _elementType;}
        }

        internal  FixedElement.ElementType _elementType;
    }

    /// <summary>
    ///
    /// </summary>
    public class StoryBreak : BlockElement
    {
    }

    /// <summary>
    ///
    /// </summary>
    public class NamedElement : BlockElement
    {
        /// <summary>
        ///
        /// </summary>
        public NamedElement()
        {
        }
        /// <summary>
        /// The element name
        /// </summary>
        public string NameReference
        {
            get
            {
                return _reference;
            }
            set
            {
                _reference = value;
            }
        }

        private string _reference;
    }
  }

