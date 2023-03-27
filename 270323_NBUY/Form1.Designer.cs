namespace _270323_NBUY
{
    partial class Form1
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
            this.rdErkek = new System.Windows.Forms.RadioButton();
            this.rdKadin = new System.Windows.Forms.RadioButton();
            this.rdIlkokul = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdOrta = new System.Windows.Forms.RadioButton();
            this.rdLise = new System.Windows.Forms.RadioButton();
            this.rdUni = new System.Windows.Forms.RadioButton();
            this.btnGoster = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdErkek
            // 
            this.rdErkek.AutoSize = true;
            this.rdErkek.Location = new System.Drawing.Point(16, 31);
            this.rdErkek.Name = "rdErkek";
            this.rdErkek.Size = new System.Drawing.Size(53, 17);
            this.rdErkek.TabIndex = 0;
            this.rdErkek.TabStop = true;
            this.rdErkek.Text = "Erkek";
            this.rdErkek.UseVisualStyleBackColor = true;
            // 
            // rdKadin
            // 
            this.rdKadin.AutoSize = true;
            this.rdKadin.Location = new System.Drawing.Point(16, 64);
            this.rdKadin.Name = "rdKadin";
            this.rdKadin.Size = new System.Drawing.Size(52, 17);
            this.rdKadin.TabIndex = 1;
            this.rdKadin.TabStop = true;
            this.rdKadin.Text = "Kadin";
            this.rdKadin.UseVisualStyleBackColor = true;
            // 
            // rdIlkokul
            // 
            this.rdIlkokul.AutoSize = true;
            this.rdIlkokul.Location = new System.Drawing.Point(6, 19);
            this.rdIlkokul.Name = "rdIlkokul";
            this.rdIlkokul.Size = new System.Drawing.Size(55, 17);
            this.rdIlkokul.TabIndex = 2;
            this.rdIlkokul.TabStop = true;
            this.rdIlkokul.Text = "ilkokul";
            this.rdIlkokul.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdKadin);
            this.groupBox1.Controls.Add(this.rdErkek);
            this.groupBox1.Location = new System.Drawing.Point(23, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdUni);
            this.groupBox2.Controls.Add(this.rdLise);
            this.groupBox2.Controls.Add(this.rdOrta);
            this.groupBox2.Controls.Add(this.rdIlkokul);
            this.groupBox2.Location = new System.Drawing.Point(23, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 153);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eğitim Durumu";
            // 
            // rdOrta
            // 
            this.rdOrta.AutoSize = true;
            this.rdOrta.Location = new System.Drawing.Point(6, 51);
            this.rdOrta.Name = "rdOrta";
            this.rdOrta.Size = new System.Drawing.Size(43, 17);
            this.rdOrta.TabIndex = 3;
            this.rdOrta.TabStop = true;
            this.rdOrta.Text = "orta";
            this.rdOrta.UseVisualStyleBackColor = true;
            // 
            // rdLise
            // 
            this.rdLise.AutoSize = true;
            this.rdLise.Location = new System.Drawing.Point(6, 74);
            this.rdLise.Name = "rdLise";
            this.rdLise.Size = new System.Drawing.Size(44, 17);
            this.rdLise.TabIndex = 5;
            this.rdLise.TabStop = true;
            this.rdLise.Text = "Lise";
            this.rdLise.UseVisualStyleBackColor = true;
            // 
            // rdUni
            // 
            this.rdUni.AutoSize = true;
            this.rdUni.Location = new System.Drawing.Point(6, 97);
            this.rdUni.Name = "rdUni";
            this.rdUni.Size = new System.Drawing.Size(72, 17);
            this.rdUni.TabIndex = 5;
            this.rdUni.TabStop = true;
            this.rdUni.Text = "Üniversite";
            this.rdUni.UseVisualStyleBackColor = true;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(650, 351);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(138, 87);
            this.btnGoster.TabIndex = 5;
            this.btnGoster.Text = "Gönder";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdErkek;
        private System.Windows.Forms.RadioButton rdKadin;
        private System.Windows.Forms.RadioButton rdIlkokul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdUni;
        private System.Windows.Forms.RadioButton rdLise;
        private System.Windows.Forms.RadioButton rdOrta;
        private System.Windows.Forms.Button btnGoster;
    }
}

