namespace Dibujo_Mouse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBoxPapel = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtR = new TextBox();
            txtG = new TextBox();
            txtB = new TextBox();
            trackBar1 = new TrackBar();
            btnPintar = new Button();
            btnBorrar = new Button();
            lblTamaño = new Label();
            colorDialog1 = new ColorDialog();
            rbRectangulo = new RadioButton();
            rbCuadrado = new RadioButton();
            rbLinea = new RadioButton();
            rbElipse = new RadioButton();
            rbElipseFull = new RadioButton();
            btnMostrar = new Button();
            btnBorrarAll = new Button();
            btnGuardarImg = new Button();
            btnCuadrado = new Button();
            btnElipse = new Button();
            btnLinea = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPapel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPapel
            // 
            pictureBoxPapel.BackColor = Color.White;
            pictureBoxPapel.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxPapel.Location = new Point(251, 12);
            pictureBoxPapel.Name = "pictureBoxPapel";
            pictureBoxPapel.Size = new Size(552, 435);
            pictureBoxPapel.TabIndex = 0;
            pictureBoxPapel.TabStop = false;
            pictureBoxPapel.Paint += pictureBoxPapel_Paint;
            pictureBoxPapel.MouseDown += pictureBoxPapel_MouseDown;
            pictureBoxPapel.MouseMove += pictureBoxPapel_MouseMove;
            pictureBoxPapel.MouseUp += pictureBoxPapel_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(97, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 16);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 192, 128);
            pictureBox2.Location = new Point(178, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 16);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 83);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 3;
            label1.Text = "R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 116);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 4;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 143);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 5;
            label3.Text = "B";
            // 
            // txtR
            // 
            txtR.Location = new Point(98, 82);
            txtR.Name = "txtR";
            txtR.Size = new Size(100, 23);
            txtR.TabIndex = 6;
            txtR.Text = "0";
            // 
            // txtG
            // 
            txtG.Location = new Point(97, 116);
            txtG.Name = "txtG";
            txtG.Size = new Size(100, 23);
            txtG.TabIndex = 7;
            txtG.Text = "0";
            // 
            // txtB
            // 
            txtB.Location = new Point(99, 149);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 8;
            txtB.Text = "0";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(2, 34);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(171, 45);
            trackBar1.TabIndex = 9;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // btnPintar
            // 
            btnPintar.Location = new Point(12, 188);
            btnPintar.Name = "btnPintar";
            btnPintar.Size = new Size(75, 23);
            btnPintar.TabIndex = 11;
            btnPintar.Text = "Pintar";
            btnPintar.UseVisualStyleBackColor = true;
            btnPintar.Click += btnPintar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackgroundImage = (Image)resources.GetObject("btnBorrar.BackgroundImage");
            btnBorrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBorrar.Location = new Point(144, 188);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(55, 41);
            btnBorrar.TabIndex = 12;
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // lblTamaño
            // 
            lblTamaño.AutoSize = true;
            lblTamaño.Location = new Point(197, 45);
            lblTamaño.Name = "lblTamaño";
            lblTamaño.Size = new Size(0, 15);
            lblTamaño.TabIndex = 13;
            // 
            // rbRectangulo
            // 
            rbRectangulo.AutoSize = true;
            rbRectangulo.Location = new Point(12, 235);
            rbRectangulo.Name = "rbRectangulo";
            rbRectangulo.Size = new Size(85, 19);
            rbRectangulo.TabIndex = 14;
            rbRectangulo.TabStop = true;
            rbRectangulo.Text = "Rectangulo";
            rbRectangulo.UseVisualStyleBackColor = true;
            // 
            // rbCuadrado
            // 
            rbCuadrado.AutoSize = true;
            rbCuadrado.Location = new Point(12, 260);
            rbCuadrado.Name = "rbCuadrado";
            rbCuadrado.Size = new Size(77, 19);
            rbCuadrado.TabIndex = 15;
            rbCuadrado.TabStop = true;
            rbCuadrado.Text = "Cuadrado";
            rbCuadrado.UseVisualStyleBackColor = true;
            // 
            // rbLinea
            // 
            rbLinea.AutoSize = true;
            rbLinea.Location = new Point(12, 285);
            rbLinea.Name = "rbLinea";
            rbLinea.Size = new Size(53, 19);
            rbLinea.TabIndex = 16;
            rbLinea.TabStop = true;
            rbLinea.Text = "Linea";
            rbLinea.UseVisualStyleBackColor = true;
            // 
            // rbElipse
            // 
            rbElipse.AutoSize = true;
            rbElipse.Location = new Point(98, 235);
            rbElipse.Name = "rbElipse";
            rbElipse.Size = new Size(55, 19);
            rbElipse.TabIndex = 17;
            rbElipse.TabStop = true;
            rbElipse.Text = "Elipse";
            rbElipse.UseVisualStyleBackColor = true;
            // 
            // rbElipseFull
            // 
            rbElipseFull.AutoSize = true;
            rbElipseFull.Location = new Point(90, 260);
            rbElipseFull.Name = "rbElipseFull";
            rbElipseFull.Size = new Size(83, 19);
            rbElipseFull.TabIndex = 18;
            rbElipseFull.TabStop = true;
            rbElipseFull.Text = "Elipse llena";
            rbElipseFull.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(90, 285);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 19;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnBorrarAll
            // 
            btnBorrarAll.BackColor = Color.LightCoral;
            btnBorrarAll.BackgroundImage = (Image)resources.GetObject("btnBorrarAll.BackgroundImage");
            btnBorrarAll.BackgroundImageLayout = ImageLayout.Zoom;
            btnBorrarAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrarAll.ForeColor = SystemColors.ActiveCaptionText;
            btnBorrarAll.Location = new Point(820, 76);
            btnBorrarAll.Name = "btnBorrarAll";
            btnBorrarAll.Size = new Size(58, 55);
            btnBorrarAll.TabIndex = 20;
            btnBorrarAll.UseVisualStyleBackColor = false;
            btnBorrarAll.Click += btnBorrarAll_Click;
            // 
            // btnGuardarImg
            // 
            btnGuardarImg.BackgroundImage = (Image)resources.GetObject("btnGuardarImg.BackgroundImage");
            btnGuardarImg.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardarImg.Location = new Point(809, 12);
            btnGuardarImg.Name = "btnGuardarImg";
            btnGuardarImg.Size = new Size(71, 53);
            btnGuardarImg.TabIndex = 21;
            btnGuardarImg.UseVisualStyleBackColor = true;
            btnGuardarImg.Click += btnGuardarImg_Click;
            // 
            // btnCuadrado
            // 
            btnCuadrado.BackgroundImage = (Image)resources.GetObject("btnCuadrado.BackgroundImage");
            btnCuadrado.BackgroundImageLayout = ImageLayout.Zoom;
            btnCuadrado.Location = new Point(12, 329);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(59, 60);
            btnCuadrado.TabIndex = 22;
            btnCuadrado.UseVisualStyleBackColor = true;
            btnCuadrado.Click += btnCuadrado_Click;
            // 
            // btnElipse
            // 
            btnElipse.BackgroundImage = (Image)resources.GetObject("btnElipse.BackgroundImage");
            btnElipse.BackgroundImageLayout = ImageLayout.Zoom;
            btnElipse.Location = new Point(90, 329);
            btnElipse.Name = "btnElipse";
            btnElipse.Size = new Size(59, 60);
            btnElipse.TabIndex = 23;
            btnElipse.UseVisualStyleBackColor = true;
            btnElipse.Click += btnElipse_Click;
            // 
            // btnLinea
            // 
            btnLinea.BackgroundImage = (Image)resources.GetObject("btnLinea.BackgroundImage");
            btnLinea.BackgroundImageLayout = ImageLayout.Zoom;
            btnLinea.Location = new Point(178, 329);
            btnLinea.Name = "btnLinea";
            btnLinea.Size = new Size(59, 60);
            btnLinea.TabIndex = 24;
            btnLinea.UseVisualStyleBackColor = true;
            btnLinea.Click += btnLinea_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 453);
            Controls.Add(btnLinea);
            Controls.Add(btnElipse);
            Controls.Add(btnCuadrado);
            Controls.Add(btnGuardarImg);
            Controls.Add(btnBorrarAll);
            Controls.Add(btnMostrar);
            Controls.Add(rbElipseFull);
            Controls.Add(rbElipse);
            Controls.Add(rbLinea);
            Controls.Add(rbCuadrado);
            Controls.Add(rbRectangulo);
            Controls.Add(lblTamaño);
            Controls.Add(btnBorrar);
            Controls.Add(btnPintar);
            Controls.Add(trackBar1);
            Controls.Add(txtB);
            Controls.Add(txtG);
            Controls.Add(txtR);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxPapel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPapel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPapel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtR;
        private TextBox txtG;
        private TextBox txtB;
        private TrackBar trackBar1;
        private Button btnPintar;
        private Button btnBorrar;
        private Label lblTamaño;
        private ColorDialog colorDialog1;
        private RadioButton rbRectangulo;
        private RadioButton rbCuadrado;
        private RadioButton rbLinea;
        private RadioButton rbElipse;
        private RadioButton rbElipseFull;
        private Button btnMostrar;
        private Button btnBorrarAll;
        private Button btnGuardarImg;
        private Button btnCuadrado;
        private Button btnElipse;
        private Button btnLinea;
        private SaveFileDialog saveFileDialog1;
    }
}