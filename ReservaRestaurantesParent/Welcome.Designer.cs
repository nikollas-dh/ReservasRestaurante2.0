namespace ReservaRestaurantesParent
{
    partial class Welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(933, 535);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            // 
            // label1
            // 
            this.label1.AccessibleName = "titulo";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem-Vindo ao Belle Croissant Reserve!";
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(539, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descubra e reserve os melhores restaurantes da sua região, adaptados ao seu palad" +
    "ar e preferências culinárias .";
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Experimente a alta gastronomia com apenas alguns cliques!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 535);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}