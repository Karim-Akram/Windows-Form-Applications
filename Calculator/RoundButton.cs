using System.Drawing.Drawing2D;


namespace Calculator
{


    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath P = new GraphicsPath();
            P.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(P);
            base.OnPaint(pevent);
        }
    }
}