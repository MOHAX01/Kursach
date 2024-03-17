using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor
{
    public class Button: Control
    {
        private StringFormat SF=new StringFormat();
        private bool MouseEntered=false;

        Animation CurtainButtonAnim = new Animation();
        
        public Button() 
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(100,30);
            BackColor = Color.DarkOrange;
            ForeColor= Color.Black;
            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width -1, Height -1);
            Rectangle rectCurtain = new Rectangle(0, 0, (int)CurtainButtonAnim.Value, Height - 1);

            graph.DrawRectangle(new Pen(BackColor), rect);
            graph.FillRectangle(new SolidBrush(BackColor), rect);

            if (MouseEntered)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(90, Color.White)), rect);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(90, Color.White)), rect);
            }
            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);
        }

        private void ButtonCurtainAction()
        {
            if (MouseEntered)
            {
                CurtainButtonAnim = new Animation("ButtonCurtain_" + Handle, Invalidate, CurtainButtonAnim.Value, Width - 1);
            }
            else
            {
                CurtainButtonAnim = new Animation("ButtonCurtain_" + Handle, Invalidate, CurtainButtonAnim.Value, 0);
            }

            Animator.Request(CurtainButtonAnim, true);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            MouseEntered = true;

            //ButtonCurtainAction();

            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            MouseEntered = false;

            //ButtonCurtainAction();

            Invalidate();
        }


    }
}
