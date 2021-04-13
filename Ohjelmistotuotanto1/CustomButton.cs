using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmistotuotanto1
{
    class CustomButton : Control
    {

        private SolidBrush Brush, textBrush;
        private Rectangle rectangle;
        private StringFormat stringFormat = new StringFormat();
        private float borderThickness { get; set; } = 6;
        private bool isHovering;

        public CustomButton()
        {
          
            textBrush = new SolidBrush(ColorTranslator.FromHtml("#000000"));
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            DoubleBuffered = true;
            MouseEnter += (sender, e) =>
            {
                isHovering = true;
                borderThickness = 8;
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                isHovering = false;
                borderThickness = 6;
                Invalidate();
            };

            this.Paint += CustomButton_Paint;
        }

        private void CustomButton_Paint(object sender, PaintEventArgs e)
        {

            rectangle = new Rectangle(0, 0, Width, Height);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush = new SolidBrush(ColorTranslator.FromHtml("#000000"));

            // Napin ulkoreunat, värinä musta
            e.Graphics.FillEllipse(Brush, 0, 0, Height, Height);
            e.Graphics.FillEllipse(Brush, Width - Height, 0, Height, Height);
            e.Graphics.FillRectangle(Brush, Height / 2, 0, Width - Height, Height);

            Brush.Dispose();
            Brush = new SolidBrush(isHovering ? ColorTranslator.FromHtml("#ffddd2") : ColorTranslator.FromHtml("#fff"));

            //Napin sisäosa, värinä valkoinen
            e.Graphics.FillEllipse(Brush, borderThickness / 2, borderThickness / 2, Height - borderThickness,
               Height - borderThickness);

            e.Graphics.FillEllipse(Brush, (Width - Height) + borderThickness / 2, borderThickness / 2,
                Height - borderThickness, Height - borderThickness);

            e.Graphics.FillRectangle(Brush, Height / 2 + (borderThickness / 2), borderThickness / 2,
                Width - Height - borderThickness, Height - borderThickness);

            Brush.Dispose();

            e.Graphics.DrawString(this.Text, this.Font, textBrush, rectangle ,stringFormat);
        }
    }
}
