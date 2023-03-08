using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Dibujo_Mouse
{
    public partial class Form1 : Form
    {

        Graphics papel;
        Bitmap btp;

        int x = 0;
        int y = 0;
        int R = 0;
        int G = 0;
        int B = 0;
        //Nuevas variables a usar
        int sx, sy, cx, cy;
        int opcion;

        int anchoPluma = 3;
        bool moviendo = false;

        Pen pen;
        SolidBrush brocha;

        bool pintar = false;
        bool borrar = false;

        Point px, py;

        public Form1()
        {
            InitializeComponent();
            pictureBoxPapel.BackColor = Color.White;
            btp = new Bitmap(pictureBoxPapel.Width, pictureBoxPapel.Height);
            //Asignar propiedad grafic al pictureBox
            papel = pictureBoxPapel.CreateGraphics();
            pictureBoxPapel.BackColor = Color.White;
            pen = new Pen(Color.Black, anchoPluma);
            //brocha para dibujar la elipse llena
            brocha = new SolidBrush(Color.Black);
            // Cuando se dibuje en el picture box se suavice el trazo
            papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            anchoPluma = trackBar1.Value;
            R = int.Parse(txtR.Text);
            G = int.Parse(txtG.Text);
            B = int.Parse(txtB.Text);
            pen = new Pen(Color.FromArgb(R, G, B), anchoPluma);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Crea un objeto Bitmap del tamaño del PictureBox
            pictureBoxPapel.Image = btp;
            papel = Graphics.FromImage(btp);
            pictureBoxPapel.BackgroundImage = btp;
            pictureBoxPapel.BackgroundImageLayout = ImageLayout.None;

        }

        //Evento cuando el mouse se mueve en el picture box
        private void pictureBoxPapel_MouseDown(object sender, MouseEventArgs e)
        {
            moviendo = true;
            py = e.Location;
            cx = e.X;
            cy = e.Y;
            //Cambiar cursor a una cruz
            pictureBoxPapel.Cursor = Cursors.Cross;
        }

        //Evento cuando el mouse esta levantado
        private void pictureBoxPapel_MouseUp(object sender, MouseEventArgs e)
        {
            moviendo = false;
            sx = x - cx;
            sy = y - cy;

            if (opcion == 1)
            {
                papel.DrawEllipse(pen, cx, cy, sx, sy);
            }
            if (opcion == 2)
            {
                papel.DrawRectangle(pen, cx, cy, sx, sy);
            }
            if (opcion == 3)
            {
                papel.DrawLine(pen, cx, cy, x, y);
            }
        }

        //Evento al dar click en pintar
        private void btnPintar_Click(object sender, EventArgs e)
        {
            opcion = 4;
        }

        //Evento al hacer click en el boton borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            opcion = 5;
        }
        //evento para pintar o borrar en el pictureBox
        private void pictureBoxPapel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moviendo)
            {
                //Pintar
                if (opcion == 4)
                {
                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                    papel.DrawLine(pen, new Point(x, y), e.Location);
                    x = e.X;
                    y = e.Y;

                }
                //Borrar
                if (opcion == 5)
                {
                    cambiarPincel(255, 255, 255);
                    papel.DrawLine(pen, new Point(x, y), e.Location);
                    x = e.X;
                    y = e.Y;
                }

                pictureBoxPapel.Refresh();
            }
            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;

        }
        //Cambiar el color del pincle con el RGB
        private void cambiarPincel(int R, int G, int B)
        {
            pen = new Pen(Color.FromArgb(R, G, B), trackBar1.Value);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        }
        //Cambiar el tamaño del pincel
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            anchoPluma = trackBar1.Value;
            lblTamaño.Text = trackBar1.Value.ToString();
        }
        //cambiar el color al que elija el usuario
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtR.Text = colorDialog1.Color.R.ToString();
                txtG.Text = colorDialog1.Color.G.ToString();
                txtB.Text = colorDialog1.Color.B.ToString();
            }
        }
        //Cambiar el color a negro
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtR.Text = 0.ToString();
            txtG.Text = 0.ToString();
            txtB.Text = 0.ToString();
        }

        //TODO: pasar las figuras a este programa
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Rectangulo
            if (rbRectangulo.Checked = rbRectangulo.Checked)
            {
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                papel.DrawRectangle(pen, 10, 10, 100, 50);
            }
            //Cuadrado
            if (rbCuadrado.Checked = rbCuadrado.Checked)
            {
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                papel.DrawRectangle(pen, 10, 70, 100, 100);
            }
            //Linea
            if (rbLinea.Checked = rbLinea.Checked)
            {
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                papel.DrawLine(pen, 120, 190, 0, 190);
            }
            //Elipse
            if (rbElipse.Checked = rbElipse.Checked)
            {
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                papel.DrawEllipse(pen, 10, 230, 100, 50);
            }
            //Elipse llena
            if (rbElipseFull.Checked = rbElipseFull.Checked)
            {
                papel.FillEllipse(brocha, 10, 300, 100, 50);
            }
            pictureBoxPapel.Refresh();
        }
        //boton para borrar todo del pictureBox
        private void btnBorrarAll_Click(object sender, EventArgs e)
        {
            papel.Clear(Color.White);
            pictureBoxPapel.Refresh();
        }

        //TODO: Boton para guardar el diujo en Imagen
        private void btnGuardarImg_Click(object sender, EventArgs e)
        {
            /* // Abre un cuadro de diálogo para que el usuario seleccione la ubicación donde se guardará la imagen
             SaveFileDialog sfd = new SaveFileDialog();
             sfd.Filter = "Imagen PNG (*.png)|*.png";
             if (sfd.ShowDialog() == DialogResult.OK)
             {
                 // Crea un objeto Bitmap del tamaño del PictureBox
                // Bitmap bmp = new Bitmap(pictureBoxPapel.Width, pictureBoxPapel.Height);

                 // Dibuja la imagen del PictureBox en el objeto Bitmap
                 pictureBoxPapel.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBoxPapel.Width, pictureBoxPapel.Height));

                 // Guarda el objeto Bitmap en el archivo seleccionado por el usuario
                 bmp.Save(sfd.FileName, ImageFormat.Jpeg);
             } */

            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Bitmap btm = btp.Clone(new Rectangle(0, 0, pictureBoxPapel.Width, pictureBoxPapel.Height), btp.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }

        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            opcion = 2;
        }

        private void btnElipse_Click(object sender, EventArgs e)
        {
            opcion = 1;
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            opcion = 3;
        }

        private void pictureBoxPapel_Paint(object sender, PaintEventArgs e)
        {
            Graphics papel = e.Graphics;
            if (moviendo)
            {
                if (opcion == 1)
                {
                    papel.DrawEllipse(pen, cx, cy, sx, sy);

                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                }
                if (opcion == 2)
                {
                    papel.DrawRectangle(pen, cx, cy, sx, sy);

                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                }
                if (opcion == 3)
                {
                    papel.DrawLine(pen, cx, cy, x, y);
                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                }
            }
        }
    }

}