// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

//
//
// This file was generated, please do not edit it directly.
//
// Please see MilCodeGen.html for more information.
//

using MS.Internal;
using System.Runtime.InteropServices;
using System.Windows.Threading;
using System.Windows.Media.Animation;
using System.Windows.Media.Composition;
using System.Windows.Media.Effects;

namespace System.Windows.Media
{
    /// <summary>
    ///     DrawingContext
    /// </summary>
    public abstract partial class DrawingContext : DispatcherObject, IDisposable
    {
        /// <summary>
        ///     DrawLine - 
        ///     Draws a line with the specified pen.
        ///     Note that this API does not accept a Brush, as there is no area to fill.
        /// </summary>
        /// <param name="pen"> The Pen with which to stroke the line. </param>
        /// <param name="point0"> The start Point for the line. </param>
        /// <param name="point1"> The end Point for the line. </param>
        public abstract void DrawLine(
            Pen pen,
            Point point0,
            Point point1);

        /// <summary>
        ///     DrawLine - 
        ///     Draws a line with the specified pen.
        ///     Note that this API does not accept a Brush, as there is no area to fill.
        /// </summary>
        /// <param name="pen"> The Pen with which to stroke the line. </param>
        /// <param name="point0"> The start Point for the line. </param>
        /// <param name="point0Animations"> Optional AnimationClock for point0. </param>
        /// <param name="point1"> The end Point for the line. </param>
        /// <param name="point1Animations"> Optional AnimationClock for point1. </param>
        public abstract void DrawLine(
            Pen pen,
            Point point0,
            AnimationClock point0Animations,
            Point point1,
            AnimationClock point1Animations);

        /// <summary>
        ///     DrawRectangle - 
        ///     Draw a rectangle with the provided Brush and/or Pen.
        ///     If both the Brush and Pen are null this call is a no-op.
        /// </summary>
        /// <param name="brush">
        ///     The Brush with which to fill the rectangle.
        ///     This is optional, and can be null, in which case no fill is performed.
        /// </param>
        /// <param name="pen">
        ///     The Pen with which to stroke the rectangle.
        ///     This is optional, and can be null, in which case no stroke is performed.
        /// </param>
        /// <param name="rectangle"> The Rect to fill and/or stroke. </param>
        public abstract void DrawRectangle(
            Brush brush,
            Pen pen,
            Rect rectangle);

        /// <summary>
        ///     DrawRectangle - 
        ///     Draw a rectangle with the provided Brush and/or Pen.
        ///     If both the Brush and Pen are null this call is a no-op.
        /// </summary>
        /// <param name="brush">
        ///     The Brush with which to fill the rectangle.
        ///     This is optional, and can be null, in which case no fill is performed.
        /// </param>
        /// <param name="pen">
        ///     The Pen with which to stroke the rectangle.
        ///     This is optional, and can be null, in which case no stroke is performed.
        /// </param>
        /// <param name="rectangle"> The Rect to fill and/or stroke. </param>
        /// <param name="rectangleAnimations"> Optional AnimationClock for rectangle. </param>
        public abstract void DrawRectangle(
            Brush brush,
            Pen pen,
            Rect rectangle,
            AnimationClock rectangleAnimations);

        /// <summary>
        ///     DrawRoundedRectangle - 
        ///     Draw a rounded rectangle with the provided Brush and/or Pen.
        ///     If both the Brush and Pen are null this call is a no-op.
        /// </summary>
        /// <param name="brush">
        ///     The Brush with which to fill the rectangle.
        ///     This is optional, and can be null, in which case no fill is performed.
        /// </param>
        /// <param name="pen">
        ///     The Pen with which to stroke the rectangle.
        ///     This is optional, and can be null, in which case no stroke is performed.
        /// </param>
        /// <param name="rectangle"> The Rect to fill and/or stroke. </param>
        /// <param name="radiusX">
        ///     The radius in the X dimension of the rounded corners of this
        ///     rounded Rect.  This value will be clamped to the range [0..rectangle.Width/2]
        /// </param>
        /// <param name="radiusY">
        ///     The radius in the Y dimension of the rounded corners of this
        ///     rounded Rect.  This value will be clamped to the range [0..rectangle.Height/2].
        /// </param>
        public abstract void DrawRoundedRectangle(
            Brush brush,
            Pen pen,
            Rect rectangle,
            Double radiusX,
            Double radiusY);

        /// <summary>
        ///     DrawRoundedRectangle - 
        ///     Draw a rounded rectangle with the provided Brush and/or Pen.
        ///     If both the Brush and Pen are null this call is a no-op.
        /// </summary>
        /// <param name="brush">
        ///     The Brush with which to fill the rectangle.
        ///     This is optional, and can be null, in which case no fill is performed.
        /// </param>
        /// <param name="pen">
        ///     The Pen with which to stroke the rectangle.
        ///     This is optional, and can be null, in which case no stroke is performed.
        /// </param>
        /// <param name="rectangle"> The Rect to fill and/or stroke. </param>
        /// <param name="rectangleAnimations"> Optional AnimationClock for rectangle. </param>
        /// <param name="radiusX">
        ///     The radius in the X dimension of the rounded corners of this
        ///     rounded Rect.  This value will be clamped to the range [0..rectangle.Width/2]
        /// </param>
        /// <param name="radiusXAnimations"> Optional AnimationClock for radiusX. </param>
        /// <param name="radiusY">
        ///     The radius in the Y dimension of the rounded corners of this
        ///     rounded Rect.  This value will be clamped to the range [0..rectangle.Height/2].
        /// </param>
        /// <param name="radiusYAnimations"> Optional AnimationClock for radiusY. </param>
        public abstract void DrawRoundedRectangle(
            Brush brush,
            Pen pen,
            Rect rectangle,
            AnimationClock rectangleAnimations,
            Double radiusX,
            AnimationClock radiusXAnimations,
            Double radiusY,
            AnimationClock radiusYAnimations);

        /// <summary>
        ///     DrawEllipse - 
        ///     Draw an ellipse with the provided Brush and/or Pen.
        ///     If both the Brush and Pen are null this call is a no-op.
        /// </summary>
        /// <param name="brush">
        ///     The Brush with which to fill the ellipse.
        ///     This is optional, and can be null, in which case no fill is performed.
        /// </param>
        /// <param name="pen">
        ///     The Pen with which to stroke the ellipse.
        ///     This is optional, and can be null, in which case no stroke is performed.
        /// </param>
        /// <param name="center">
        ///     The center of the ellipse to fill and/or stroke.
        /// </param>
        /// <param name="radiusX">
        ///     The radius in the X dimension of the ellipse.
        ///     The absolute value of the radius provided will be used.
        /// </param>
        /// <param name="radiusY">
        ///     The radius in the Y dimension of the ellipse.
        ///     The absolute value of the radius provided will be used.
        /// </param>
        public abstract void DrawEllipse(
            Brush brush,
            Pen pen,
            Point center,
            Double radiusX,
            Double radiusY);

        /// <summary>
        ///     DrawEllipse - 
        ///     Draw an ellipse with the provided Brush and/or Pen.
        ///     If both the Brush and Pen are null this call is a no-op.
        /// </summary>
        /// <param name="brush">
        ///     The Brush with which to fill the ellipse.
        ///     This is optional, and can be null, in which case no fill is performed.
        /// </param>
        /// <param name="pen">
        ///     The Pen with which to stroke the ellipse.
        ///     This is optional, and can be null, in which case no stroke is performed.
        /// </param>
        /// <param name="center">
        ///     The center of the ellipse to fill and/or stroke.
        /// </param>
        /// <param name="centerAnimations"> Optional AnimationClock for center. </param>
        /// <param name="radiusX">
        ///     The radius in the X dimension of the ellipse.
        ///     The absolute value of the radius provided will be used.
        /// </param>
        /// <param name="radiusXAnimations"> Optional AnimationClock for radiusX. </param>
        /// <param name="radiusY">
        ///     The radius in the Y dimension of the ellipse.
        ///     The absolute value of the radius provided will be used.
        /// </param>
        /// <param name="radiusYAnimations"> Optional AnimationClock for radiusY. </param>
        public abstract void DrawEllipse(
            Brush brush,
            Pen pen,
            Point center,
            AnimationClock centerAnimations,
            Double radiusX,
            AnimationClock radiusXAnimations,
            Double radiusY,
            AnimationClock radiusYAnimations);

        /// <summary>
        ///     DrawGeometry - 
        ///     Draw a Geometry with the provided Brush and/or Pen.
        ///     If both the Brush and Pen are null this call is a no-op.
        /// </summary>
        /// <param name="brush">
        ///     The Brush with which to fill the Geometry.
        ///     This is optional, and can be null, in which case no fill is performed.
        /// </param>
        /// <param name="pen">
        ///     The Pen with which to stroke the Geometry.
        ///     This is optional, and can be null, in which case no stroke is performed.
        /// </param>
        /// <param name="geometry"> The Geometry to fill and/or stroke. </param>
        public abstract void DrawGeometry(
            Brush brush,
            Pen pen,
            Geometry geometry);

        /// <summary>
        ///     DrawImage - 
        ///     Draw an Image into the region specified by the Rect.
        ///     The Image will potentially be stretched and distorted to fit the Rect.
        ///     For more fine grained control, consider filling a Rect with an ImageBrush via 
        ///     DrawRectangle.
        /// </summary>
        /// <param name="imageSource"> The ImageSource to draw. </param>
        /// <param name="rectangle">
        ///     The Rect into which the ImageSource will be fit.
        /// </param>
        public abstract void DrawImage(
            ImageSource imageSource,
            Rect rectangle);

        /// <summary>
        ///     DrawImage - 
        ///     Draw an Image into the region specified by the Rect.
        ///     The Image will potentially be stretched and distorted to fit the Rect.
        ///     For more fine grained control, consider filling a Rect with an ImageBrush via 
        ///     DrawRectangle.
        /// </summary>
        /// <param name="imageSource"> The ImageSource to draw. </param>
        /// <param name="rectangle">
        ///     The Rect into which the ImageSource will be fit.
        /// </param>
        /// <param name="rectangleAnimations"> Optional AnimationClock for rectangle. </param>
        public abstract void DrawImage(
            ImageSource imageSource,
            Rect rectangle,
            AnimationClock rectangleAnimations);

        /// <summary>
        ///     DrawGlyphRun - 
        ///     Draw a GlyphRun
        /// </summary>
        /// <param name="foregroundBrush">
        ///     Foreground brush to draw the GlyphRun with.
        /// </param>
        /// <param name="glyphRun"> The GlyphRun to draw.  </param>
        public abstract void DrawGlyphRun(
            Brush foregroundBrush,
            GlyphRun glyphRun);

        /// <summary>
        ///     DrawDrawing - 
        ///     Draw a Drawing by appending a sub-Drawing to the current Drawing.
        /// </summary>
        /// <param name="drawing"> The drawing to draw. </param>
        public abstract void DrawDrawing(
            Drawing drawing);

        /// <summary>
        ///     DrawVideo - 
        ///     Draw a Video into the region specified by the Rect.
        ///     The Video will potentially be stretched and distorted to fit the Rect.
        ///     For more fine grained control, consider filling a Rect with an VideoBrush via 
        ///     DrawRectangle.
        /// </summary>
        /// <param name="player"> The MediaPlayer to draw. </param>
        /// <param name="rectangle"> The Rect into which the media will be fit. </param>
        public abstract void DrawVideo(
            MediaPlayer player,
            Rect rectangle);

        /// <summary>
        ///     DrawVideo - 
        ///     Draw a Video into the region specified by the Rect.
        ///     The Video will potentially be stretched and distorted to fit the Rect.
        ///     For more fine grained control, consider filling a Rect with an VideoBrush via 
        ///     DrawRectangle.
        /// </summary>
        /// <param name="player"> The MediaPlayer to draw. </param>
        /// <param name="rectangle"> The Rect into which the media will be fit. </param>
        /// <param name="rectangleAnimations"> Optional AnimationClock for rectangle. </param>
        public abstract void DrawVideo(
            MediaPlayer player,
            Rect rectangle,
            AnimationClock rectangleAnimations);

        /// <summary>
        ///     PushClip - 
        ///     Push a clip region, which will apply to all drawing primitives until the 
        ///     corresponding Pop call.
        /// </summary>
        /// <param name="clipGeometry"> The Geometry to which we will clip. </param>
        public abstract void PushClip(
            Geometry clipGeometry);

        /// <summary>
        ///     PushOpacityMask - 
        ///     Push an opacity mask which will blend the composite of all drawing primitives added 
        ///     until the corresponding Pop call.
        /// </summary>
        /// <param name="opacityMask"> The opacity mask </param>
        public abstract void PushOpacityMask(
            Brush opacityMask);

        /// <summary>
        ///     PushOpacity - 
        ///     Push an opacity which will blend the composite of all drawing primitives added 
        ///     until the corresponding Pop call.
        /// </summary>
        /// <param name="opacity">
        ///     The opacity with which to blend - 0 is transparent, 1 is opaque.
        /// </param>
        public abstract void PushOpacity(
            Double opacity);

        /// <summary>
        ///     PushOpacity - 
        ///     Push an opacity which will blend the composite of all drawing primitives added 
        ///     until the corresponding Pop call.
        /// </summary>
        /// <param name="opacity">
        ///     The opacity with which to blend - 0 is transparent, 1 is opaque.
        /// </param>
        /// <param name="opacityAnimations"> Optional AnimationClock for opacity. </param>
        public abstract void PushOpacity(
            Double opacity,
            AnimationClock opacityAnimations);

        /// <summary>
        ///     PushTransform - 
        ///     Push a Transform which will apply to all drawing operations until the corresponding 
        ///     Pop.
        /// </summary>
        /// <param name="transform"> The Transform to push. </param>
        public abstract void PushTransform(
            Transform transform);

        /// <summary>
        ///     PushGuidelineSet - 
        ///     Push a set of guidelines which will apply to all drawing operations until the 
        ///     corresponding Pop.
        /// </summary>
        /// <param name="guidelines"> The GuidelineSet to push. </param>
        public abstract void PushGuidelineSet(
            GuidelineSet guidelines);

        /// <summary>
        ///     PushGuidelineY1 - 
        ///     Explicitly push one horizontal guideline.
        /// </summary>
        /// <param name="coordinate"> The coordinate of leading guideline. </param>
        internal abstract void PushGuidelineY1(
            Double coordinate);

        /// <summary>
        ///     PushGuidelineY2 - 
        ///     Explicitly push a pair of horizontal guidelines.
        /// </summary>
        /// <param name="leadingCoordinate">
        ///     The coordinate of leading guideline.
        /// </param>
        /// <param name="offsetToDrivenCoordinate">
        ///     The offset from leading guideline to driven guideline.
        /// </param>
        internal abstract void PushGuidelineY2(
            Double leadingCoordinate,
            Double offsetToDrivenCoordinate);

        /// <summary>
        ///     PushEffect - 
        ///     Push a BitmapEffect which will apply to all drawing operations until the 
        ///     corresponding Pop.
        /// </summary>
        /// <param name="effect"> The BitmapEffect to push. </param>
        /// <param name="effectInput"> The BitmapEffectInput. </param>
        [Obsolete(MS.Internal.Media.VisualTreeUtils.BitmapEffectObsoleteMessage)]
        public abstract void PushEffect(
            BitmapEffect effect,
            BitmapEffectInput effectInput);

        /// <summary>
        /// Pop
        /// </summary>
        public abstract void Pop(
            );

    }
}
