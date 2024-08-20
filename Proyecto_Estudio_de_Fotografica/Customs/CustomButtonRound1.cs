using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Proyecto_Estudio_de_Fotografica.Customs

{
    public class CustomButtonRound1 : Button
    {
        //Campos
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        //Propiedades
        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                if (value <= this.Height)
                    borderRadius = value;
                else borderRadius = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public Color BackGroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Category("RJ Code Advance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }


        } 
        //Constructor
        public CustomButtonRound1()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size= new Size(150,40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize!);
        }
        
      

        //Metodos
        private GraphicsPath GetFigurePath(RectangleF rect, float radious)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radious, radious, 180, 90);
            path.AddArc(rect.Width-radious, rect.Y, radious, radious, 270, 90);
            path.AddArc(rect.Width-radious, rect.Height-radious, radious, radious, 0, 90);
            path.AddArc(rect.X, rect.Height - radious, radious, radious, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs prevent)
        {
            base.OnPaint(prevent);
            prevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1,1, this.Width-0.8F, this.Height-1);

            if(borderRadius > 2)//Boton redondo
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent!.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    prevent.Graphics.DrawPath(penSurface, pathSurface);
                    if (borderSize >= 1)
                        prevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Boton normal
            {
                this.Region = new Region(rectSurface);
                if(borderSize >= 1)
                {
                    using(Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        prevent.Graphics.DrawRectangle(penBorder,0,0,this.Width-1, this.Height-1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent!.BackColorChanged += new EventHandler(Container_BackColorChanged!);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();

        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                BorderRadius = this.Height;
        }

    }
}
