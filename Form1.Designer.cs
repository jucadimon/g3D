namespace graficador3D
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.xi = new System.Windows.Forms.TextBox();
            this.yi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zi = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.zf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.xf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Graficador 3D";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(15, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 356);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "graficar 3D";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "x";
            // 
            // xi
            // 
            this.xi.Location = new System.Drawing.Point(30, 416);
            this.xi.Name = "xi";
            this.xi.Size = new System.Drawing.Size(42, 20);
            this.xi.TabIndex = 4;
            // 
            // yi
            // 
            this.yi.Location = new System.Drawing.Point(109, 416);
            this.yi.Name = "yi";
            this.yi.Size = new System.Drawing.Size(42, 20);
            this.yi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "y";
            // 
            // zi
            // 
            this.zi.Location = new System.Drawing.Point(190, 416);
            this.zi.Name = "zi";
            this.zi.Size = new System.Drawing.Size(42, 20);
            this.zi.TabIndex = 8;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(172, 419);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(12, 13);
            this.label100.TabIndex = 7;
            this.label100.Text = "z";
            // 
            // zf
            // 
            this.zf.Location = new System.Drawing.Point(190, 457);
            this.zf.Name = "zf";
            this.zf.Size = new System.Drawing.Size(42, 20);
            this.zf.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "z";
            // 
            // yf
            // 
            this.yf.Location = new System.Drawing.Point(109, 457);
            this.yf.Name = "yf";
            this.yf.Size = new System.Drawing.Size(42, 20);
            this.yf.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "y";
            // 
            // xf
            // 
            this.xf.Location = new System.Drawing.Point(30, 457);
            this.xf.Name = "xf";
            this.xf.Size = new System.Drawing.Size(42, 20);
            this.xf.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "linea";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "graficar linea";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "dibujar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(671, 484);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.zi);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.yi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xi;
        private System.Windows.Forms.TextBox yi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox zi;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox zf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox xf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

