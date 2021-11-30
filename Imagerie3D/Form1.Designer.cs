namespace Imagerie3D
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox_Angle_X = new System.Windows.Forms.TextBox();
            this.textBox_Z_coord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_afficher_coupe = new System.Windows.Forms.Button();
            this.button_ouvrir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Angle_Y = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Angle_Z = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_Angle_X
            // 
            this.textBox_Angle_X.Location = new System.Drawing.Point(789, 177);
            this.textBox_Angle_X.Name = "textBox_Angle_X";
            this.textBox_Angle_X.Size = new System.Drawing.Size(100, 20);
            this.textBox_Angle_X.TabIndex = 2;
            this.textBox_Angle_X.Text = "0";
            // 
            // textBox_Z_coord
            // 
            this.textBox_Z_coord.Location = new System.Drawing.Point(789, 148);
            this.textBox_Z_coord.Name = "textBox_Z_coord";
            this.textBox_Z_coord.Size = new System.Drawing.Size(100, 20);
            this.textBox_Z_coord.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Angle X (°)";
            // 
            // button_afficher_coupe
            // 
            this.button_afficher_coupe.Location = new System.Drawing.Point(774, 309);
            this.button_afficher_coupe.Name = "button_afficher_coupe";
            this.button_afficher_coupe.Size = new System.Drawing.Size(115, 23);
            this.button_afficher_coupe.TabIndex = 6;
            this.button_afficher_coupe.Text = "Afficher coupe";
            this.button_afficher_coupe.UseVisualStyleBackColor = true;
            this.button_afficher_coupe.Click += new System.EventHandler(this.button_afficher_coupe_Click);
            // 
            // button_ouvrir
            // 
            this.button_ouvrir.Location = new System.Drawing.Point(26, 490);
            this.button_ouvrir.Name = "button_ouvrir";
            this.button_ouvrir.Size = new System.Drawing.Size(100, 23);
            this.button_ouvrir.TabIndex = 7;
            this.button_ouvrir.Text = "Ouvrir dossier";
            this.button_ouvrir.UseVisualStyleBackColor = true;
            this.button_ouvrir.Click += new System.EventHandler(this.button_ouvrir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(745, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Z";
            // 
            // textBox_Angle_Y
            // 
            this.textBox_Angle_Y.Location = new System.Drawing.Point(789, 207);
            this.textBox_Angle_Y.Name = "textBox_Angle_Y";
            this.textBox_Angle_Y.Size = new System.Drawing.Size(100, 20);
            this.textBox_Angle_Y.TabIndex = 2;
            this.textBox_Angle_Y.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(726, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Angle Y(°)";
            // 
            // textBox_Angle_Z
            // 
            this.textBox_Angle_Z.Location = new System.Drawing.Point(789, 242);
            this.textBox_Angle_Z.Name = "textBox_Angle_Z";
            this.textBox_Angle_Z.Size = new System.Drawing.Size(100, 20);
            this.textBox_Angle_Z.TabIndex = 2;
            this.textBox_Angle_Z.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Angle Z(°)";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(26, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 471);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_ouvrir);
            this.Controls.Add(this.button_afficher_coupe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Angle_Z);
            this.Controls.Add(this.textBox_Z_coord);
            this.Controls.Add(this.textBox_Angle_Y);
            this.Controls.Add(this.textBox_Angle_X);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox_Angle_X;
        private System.Windows.Forms.TextBox textBox_Z_coord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_afficher_coupe;
        private System.Windows.Forms.Button button_ouvrir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Angle_Y;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Angle_Z;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

