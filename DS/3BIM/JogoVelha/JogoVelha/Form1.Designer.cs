namespace JogoVelha
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picP1 = new System.Windows.Forms.PictureBox();
            this.picP2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnVerm = new System.Windows.Forms.Button();
            this.btnVerd = new System.Windows.Forms.Button();
            this.btnAmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picP1
            // 
            this.picP1.BackColor = System.Drawing.Color.Transparent;
            this.picP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picP1.Location = new System.Drawing.Point(0, 148);
            this.picP1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picP1.Name = "picP1";
            this.picP1.Size = new System.Drawing.Size(219, 306);
            this.picP1.TabIndex = 1;
            this.picP1.TabStop = false;
            // 
            // picP2
            // 
            this.picP2.BackColor = System.Drawing.Color.Transparent;
            this.picP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picP2.Location = new System.Drawing.Point(582, 148);
            this.picP2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picP2.Name = "picP2";
            this.picP2.Size = new System.Drawing.Size(219, 306);
            this.picP2.TabIndex = 2;
            this.picP2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox5.Image = global::JogoVelha.Properties.Resources.p2;
            this.pictureBox5.Location = new System.Drawing.Point(663, 69);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(81, 71);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Image = global::JogoVelha.Properties.Resources.p1;
            this.pictureBox4.Location = new System.Drawing.Point(50, 69);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 71);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Transparent;
            this.btnJogar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJogar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnJogar.Location = new System.Drawing.Point(279, 383);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(0);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(254, 71);
            this.btnJogar.TabIndex = 6;
            this.btnJogar.Text = "JOGAR";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAzul.BackgroundImage = global::JogoVelha.Properties.Resources.clotildepfp;
            this.btnAzul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAzul.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzul.Location = new System.Drawing.Point(279, 148);
            this.btnAzul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(118, 105);
            this.btnAzul.TabIndex = 7;
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnVerm
            // 
            this.btnVerm.BackColor = System.Drawing.Color.Red;
            this.btnVerm.BackgroundImage = global::JogoVelha.Properties.Resources.cleidepfp;
            this.btnVerm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerm.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerm.Location = new System.Drawing.Point(414, 148);
            this.btnVerm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerm.Name = "btnVerm";
            this.btnVerm.Size = new System.Drawing.Size(118, 105);
            this.btnVerm.TabIndex = 8;
            this.btnVerm.UseVisualStyleBackColor = false;
            this.btnVerm.Click += new System.EventHandler(this.btnVerm_Click);
            // 
            // btnVerd
            // 
            this.btnVerd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVerd.BackgroundImage = global::JogoVelha.Properties.Resources.beneditapfp;
            this.btnVerd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerd.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerd.Location = new System.Drawing.Point(279, 262);
            this.btnVerd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerd.Name = "btnVerd";
            this.btnVerd.Size = new System.Drawing.Size(118, 105);
            this.btnVerd.TabIndex = 9;
            this.btnVerd.UseVisualStyleBackColor = false;
            this.btnVerd.Click += new System.EventHandler(this.btnVerd_Click);
            // 
            // btnAmar
            // 
            this.btnAmar.BackColor = System.Drawing.Color.Yellow;
            this.btnAmar.BackgroundImage = global::JogoVelha.Properties.Resources.matildepfp;
            this.btnAmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAmar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmar.Location = new System.Drawing.Point(414, 262);
            this.btnAmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAmar.Name = "btnAmar";
            this.btnAmar.Size = new System.Drawing.Size(118, 105);
            this.btnAmar.TabIndex = 10;
            this.btnAmar.UseVisualStyleBackColor = false;
            this.btnAmar.Click += new System.EventHandler(this.btnAmar_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoVelha.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnAmar);
            this.Controls.Add(this.btnVerd);
            this.Controls.Add(this.btnVerm);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.picP2);
            this.Controls.Add(this.picP1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMenu";
            this.Text = "Jogo das Velhas 👵";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picP1;
        private System.Windows.Forms.PictureBox picP2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnVerm;
        private System.Windows.Forms.Button btnVerd;
        private System.Windows.Forms.Button btnAmar;
    }
}

