// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

//
//
// This file was generated, please do not edit it directly.
//
// Please see MilCodeGen.html for more information.
//

using MS.Internal;
using MS.Utility;
using System.Collections;
using System.Windows.Media.Animation;
using System.Windows.Media.Composition;
using System.Windows.Media.Imaging;

namespace System.Windows.Media.Effects
{
    public sealed partial class OuterGlowBitmapEffect : BitmapEffect
    {
        //------------------------------------------------------
        //
        //  Public Methods
        //
        //------------------------------------------------------

        #region Public Methods

        /// <summary>
        ///     Shadows inherited Clone() with a strongly typed
        ///     version for convenience.
        /// </summary>
        public new OuterGlowBitmapEffect Clone()
        {
            return (OuterGlowBitmapEffect)base.Clone();
        }

        /// <summary>
        ///     Shadows inherited CloneCurrentValue() with a strongly typed
        ///     version for convenience.
        /// </summary>
        public new OuterGlowBitmapEffect CloneCurrentValue()
        {
            return (OuterGlowBitmapEffect)base.CloneCurrentValue();
        }




        #endregion Public Methods

        //------------------------------------------------------
        //
        //  Public Properties
        //
        //------------------------------------------------------

        private static void GlowColorPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            OuterGlowBitmapEffect target = ((OuterGlowBitmapEffect) d);


            target.PropertyChanged(GlowColorProperty);
        }
        private static void GlowSizePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            OuterGlowBitmapEffect target = ((OuterGlowBitmapEffect) d);


            target.PropertyChanged(GlowSizeProperty);
        }
        private static void NoisePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            OuterGlowBitmapEffect target = ((OuterGlowBitmapEffect) d);


            target.PropertyChanged(NoiseProperty);
        }
        private static void OpacityPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            OuterGlowBitmapEffect target = ((OuterGlowBitmapEffect) d);


            target.PropertyChanged(OpacityProperty);
        }


        #region Public Properties

        /// <summary>
        ///     GlowColor - Color.  Default value is Colors.Gold.
        /// </summary>
        public Color GlowColor
        {
            get
            {
                return (Color) GetValue(GlowColorProperty);
            }
            set
            {
                SetValueInternal(GlowColorProperty, value);
            }
        }

        /// <summary>
        ///     GlowSize - double.  Default value is 5.0.
        /// </summary>
        public double GlowSize
        {
            get
            {
                return (double) GetValue(GlowSizeProperty);
            }
            set
            {
                SetValueInternal(GlowSizeProperty, value);
            }
        }

        /// <summary>
        ///     Noise - double.  Default value is 0.0.
        /// </summary>
        public double Noise
        {
            get
            {
                return (double) GetValue(NoiseProperty);
            }
            set
            {
                SetValueInternal(NoiseProperty, value);
            }
        }

        /// <summary>
        ///     Opacity - double.  Default value is 1.0.
        /// </summary>
        public double Opacity
        {
            get
            {
                return (double) GetValue(OpacityProperty);
            }
            set
            {
                SetValueInternal(OpacityProperty, value);
            }
        }

        #endregion Public Properties

        //------------------------------------------------------
        //
        //  Protected Methods
        //
        //------------------------------------------------------

        #region Protected Methods

        /// <summary>
        /// Implementation of <see cref="System.Windows.Freezable.CreateInstanceCore">Freezable.CreateInstanceCore</see>.
        /// </summary>
        /// <returns>The new Freezable.</returns>
        protected override Freezable CreateInstanceCore()
        {
            return new OuterGlowBitmapEffect();
        }



        #endregion ProtectedMethods

        //------------------------------------------------------
        //
        //  Internal Methods
        //
        //------------------------------------------------------

        #region Internal Methods









        #endregion Internal Methods

        //------------------------------------------------------
        //
        //  Internal Properties
        //
        //------------------------------------------------------

        #region Internal Properties





        #endregion Internal Properties

        //------------------------------------------------------
        //
        //  Dependency Properties
        //
        //------------------------------------------------------

        #region Dependency Properties

        /// <summary>
        ///     The DependencyProperty for the OuterGlowBitmapEffect.GlowColor property.
        /// </summary>
        public static readonly DependencyProperty GlowColorProperty;
        /// <summary>
        ///     The DependencyProperty for the OuterGlowBitmapEffect.GlowSize property.
        /// </summary>
        public static readonly DependencyProperty GlowSizeProperty;
        /// <summary>
        ///     The DependencyProperty for the OuterGlowBitmapEffect.Noise property.
        /// </summary>
        public static readonly DependencyProperty NoiseProperty;
        /// <summary>
        ///     The DependencyProperty for the OuterGlowBitmapEffect.Opacity property.
        /// </summary>
        public static readonly DependencyProperty OpacityProperty;

        #endregion Dependency Properties

        //------------------------------------------------------
        //
        //  Internal Fields
        //
        //------------------------------------------------------

        #region Internal Fields





        internal static Color s_GlowColor = Colors.Gold;
        internal const double c_GlowSize = 5.0;
        internal const double c_Noise = 0.0;
        internal const double c_Opacity = 1.0;

        #endregion Internal Fields



        #region Constructors

        //------------------------------------------------------
        //
        //  Constructors
        //
        //------------------------------------------------------

        static OuterGlowBitmapEffect()
        {
            // We check our static default fields which are of type Freezable
            // to make sure that they are not mutable, otherwise we will throw
            // if these get touched by more than one thread in the lifetime
            // of your app.


            // Initializations
            Type typeofThis = typeof(OuterGlowBitmapEffect);
            GlowColorProperty =
                  RegisterProperty("GlowColor",
                                   typeof(Color),
                                   typeofThis,
                                   Colors.Gold,
                                   new PropertyChangedCallback(GlowColorPropertyChanged),
                                   null,
                                   /* isIndependentlyAnimated  = */ true,
                                   /* coerceValueCallback */ null);
            GlowSizeProperty =
                  RegisterProperty("GlowSize",
                                   typeof(double),
                                   typeofThis,
                                   5.0,
                                   new PropertyChangedCallback(GlowSizePropertyChanged),
                                   null,
                                   /* isIndependentlyAnimated  = */ true,
                                   /* coerceValueCallback */ null);
            NoiseProperty =
                  RegisterProperty("Noise",
                                   typeof(double),
                                   typeofThis,
                                   0.0,
                                   new PropertyChangedCallback(NoisePropertyChanged),
                                   null,
                                   /* isIndependentlyAnimated  = */ true,
                                   /* coerceValueCallback */ null);
            OpacityProperty =
                  RegisterProperty("Opacity",
                                   typeof(double),
                                   typeofThis,
                                   1.0,
                                   new PropertyChangedCallback(OpacityPropertyChanged),
                                   null,
                                   /* isIndependentlyAnimated  = */ true,
                                   /* coerceValueCallback */ null);
        }



        #endregion Constructors
    }
}
