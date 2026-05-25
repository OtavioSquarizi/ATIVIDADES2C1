namespace ExibirImagem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioImagem1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioaImagem2 = new System.Windows.Forms.RadioButton();
            this.radioSemborda = new System.Windows.Forms.RadioButton();
            this.radioFixa = new System.Windows.Forms.RadioButton();
            this.radio3D = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(208, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioImagem1
            // 
            this.radioImagem1.AutoSize = true;
            this.radioImagem1.Location = new System.Drawing.Point(188, 287);
            this.radioImagem1.Name = "radioImagem1";
            this.radioImagem1.Size = new System.Drawing.Size(105, 24);
            this.radioImagem1.TabIndex = 1;
            this.radioImagem1.TabStop = true;
            this.radioImagem1.Text = "Imagem 1";
            this.radioImagem1.UseVisualStyleBackColor = true;
            this.radioImagem1.CheckedChanged += new System.EventHandler(this.radioImagem1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(188, 371);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sem Imagem";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioaImagem2
            // 
            this.radioaImagem2.AutoSize = true;
            this.radioaImagem2.Location = new System.Drawing.Point(188, 329);
            this.radioaImagem2.Name = "radioaImagem2";
            this.radioaImagem2.Size = new System.Drawing.Size(105, 24);
            this.radioaImagem2.TabIndex = 3;
            this.radioaImagem2.TabStop = true;
            this.radioaImagem2.Text = "Imagem 2";
            this.radioaImagem2.UseVisualStyleBackColor = true;
            this.radioaImagem2.CheckedChanged += new System.EventHandler(this.radioaImagem2_CheckedChanged);
            // 
            // radioSemborda
            // 
            this.radioSemborda.AutoSize = true;
            this.radioSemborda.Location = new System.Drawing.Point(418, 287);
            this.radioSemborda.Name = "radioSemborda";
            this.radioSemborda.Size = new System.Drawing.Size(112, 24);
            this.radioSemborda.TabIndex = 4;
            this.radioSemborda.TabStop = true;
            this.radioSemborda.Text = "Sem borda";
            this.radioSemborda.UseVisualStyleBackColor = true;
            this.radioSemborda.CheckedChanged += new System.EventHandler(this.radioSemborda_CheckedChanged);
            // 
            // radioFixa
            // 
            this.radioFixa.AutoSize = true;
            this.radioFixa.Location = new System.Drawing.Point(418, 329);
            this.radioFixa.Name = "radioFixa";
            this.radioFixa.Size = new System.Drawing.Size(123, 24);
            this.radioFixa.TabIndex = 5;
            this.radioFixa.TabStop = true;
            this.radioFixa.Text = "Fixa Simples";
            this.radioFixa.UseVisualStyleBackColor = true;
            this.radioFixa.CheckedChanged += new System.EventHandler(this.radioFixa_CheckedChanged);
            // 
            // radio3D
            // 
            this.radio3D.AutoSize = true;
            this.radio3D.Location = new System.Drawing.Point(418, 371);
            this.radio3D.Name = "radio3D";
            this.radio3D.Size = new System.Drawing.Size(55, 24);
            this.radio3D.TabIndex = 6;
            this.radio3D.TabStop = true;
            this.radio3D.Text = "3D";
            this.radio3D.UseVisualStyleBackColor = true;
            this.radio3D.CheckedChanged += new System.EventHandler(this.radio3D_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Borda:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(593, 287);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Imagem Visível";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(593, 350);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(141, 45);
            this.sair.TabIndex = 10;
            this.sair.Text = "SAIR";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio3D);
            this.Controls.Add(this.radioFixa);
            this.Controls.Add(this.radioSemborda);
            this.Controls.Add(this.radioaImagem2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioImagem1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "ExibirImagem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioImagem1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioaImagem2;
        private System.Windows.Forms.RadioButton radioSemborda;
        private System.Windows.Forms.RadioButton radioFixa;
        private System.Windows.Forms.RadioButton radio3D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button sair;
    }
}

