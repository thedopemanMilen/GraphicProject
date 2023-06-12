using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Draw.src.Model
{
    public class CircleShape : Shape
    {
        public CircleShape()
        {
        }

        public CircleShape(RectangleF rect) : base(rect)
        {
        }

        

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                return true;
            else
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
        }


        public override void DrawSelf(Graphics grfx, int penSize)
        {
            
            

            // Create a pen with the desired color and pen size
            Pen pen = new Pen(Color.Black, penSize);

            base.DrawSelf(grfx, penSize);

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle);
            grfx.DrawEllipse(Pens.Black, Rectangle);
        }




    }
}
