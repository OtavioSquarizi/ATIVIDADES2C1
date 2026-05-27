namespace estruturas_repeticao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.exerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fatorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fibonacciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.limiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervaloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exerciciosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // exerciciosToolStripMenuItem
            // 
            this.exerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fibonacciToolStripMenuItem,
            this.fatorialToolStripMenuItem,
            this.fibonacciToolStripMenuItem1,
            this.limiteToolStripMenuItem,
            this.intervaloToolStripMenuItem,
            this.sobreToolStripMenuItem1});
            this.exerciciosToolStripMenuItem.Name = "exerciciosToolStripMenuItem";
            this.exerciciosToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.exerciciosToolStripMenuItem.Text = "Exercicios";
            // 
            // fibonacciToolStripMenuItem
            // 
            this.fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
            this.fibonacciToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.fibonacciToolStripMenuItem.Text = "Tabuada";
            this.fibonacciToolStripMenuItem.Click += new System.EventHandler(this.fibonacciToolStripMenuItem_Click);
            // 
            // fatorialToolStripMenuItem
            // 
            this.fatorialToolStripMenuItem.Name = "fatorialToolStripMenuItem";
            this.fatorialToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.fatorialToolStripMenuItem.Text = "Fatorial";
            this.fatorialToolStripMenuItem.Click += new System.EventHandler(this.fatorialToolStripMenuItem_Click);
            // 
            // fibonacciToolStripMenuItem1
            // 
            this.fibonacciToolStripMenuItem1.Name = "fibonacciToolStripMenuItem1";
            this.fibonacciToolStripMenuItem1.Size = new System.Drawing.Size(193, 34);
            this.fibonacciToolStripMenuItem1.Text = "Fibonacci ";
            this.fibonacciToolStripMenuItem1.Click += new System.EventHandler(this.fibonacciToolStripMenuItem1_Click);
            // 
            // limiteToolStripMenuItem
            // 
            this.limiteToolStripMenuItem.Name = "limiteToolStripMenuItem";
            this.limiteToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.limiteToolStripMenuItem.Text = "Limite";
            this.limiteToolStripMenuItem.Click += new System.EventHandler(this.limiteToolStripMenuItem_Click);
            // 
            // intervaloToolStripMenuItem
            // 
            this.intervaloToolStripMenuItem.Name = "intervaloToolStripMenuItem";
            this.intervaloToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.intervaloToolStripMenuItem.Text = "Intervalo";
            this.intervaloToolStripMenuItem.Click += new System.EventHandler(this.intervaloToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(193, 34);
            this.sobreToolStripMenuItem1.Text = "Sobre ";
            this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.sobreToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem exerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fatorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fibonacciToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem limiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervaloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
    }
}

