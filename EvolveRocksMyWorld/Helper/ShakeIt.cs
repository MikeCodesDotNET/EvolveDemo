using System;
using MonoMac.CoreAnimation;
using System.Drawing;
using MonoMac.CoreGraphics;

namespace EvolveRocksMyWorld
{
    public class ShakeIt
    {
        static public CAKeyFrameAnimation ShakeAnimation(RectangleF frame)
        {
            const int numberOfShakes = 3;
            const float durationOfShakes = 0.5f;
            const float vigourOfShake = 0.02f;
            var shakeAnimation = new CAKeyFrameAnimation();

            var shakePath = new CGPath();
            shakePath.MoveToPoint(frame.GetMinX(), frame.GetMinY());
            int index;
            for (index = 0; index < numberOfShakes; index++)
            {
                shakePath.CGPathAddLineToPoint(frame.GetMinX() - frame.Size.Width * vigourOfShake, frame.GetMinY());
                shakePath.CGPathAddLineToPoint(frame.GetMinX() + frame.Size.Width * vigourOfShake, frame.GetMinY());
            }
            shakePath.CloseSubpath();
            shakeAnimation.Path = shakePath;
            shakeAnimation.Duration = durationOfShakes;
            return shakeAnimation;
        }
    }
}

