namespace Parcial_2
{
    partial class Form2
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
            this.Question3 = new System.Windows.Forms.GroupBox();
            this.Quest3 = new System.Windows.Forms.Label();
            this.False1 = new System.Windows.Forms.RadioButton();
            this.True1 = new System.Windows.Forms.RadioButton();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.Question4 = new System.Windows.Forms.GroupBox();
            this.Quest4 = new System.Windows.Forms.Label();
            this.False2 = new System.Windows.Forms.RadioButton();
            this.True2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.continuebott = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Question3.SuspendLayout();
            this.Question4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Question3
            // 
            this.Question3.Controls.Add(this.Quest3);
            this.Question3.Controls.Add(this.False1);
            this.Question3.Controls.Add(this.True1);
            this.Question3.Controls.Add(this.QuestionLabel);
            this.Question3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question3.ForeColor = System.Drawing.SystemColors.Control;
            this.Question3.Location = new System.Drawing.Point(517, 70);
            this.Question3.Name = "Question3";
            this.Question3.Size = new System.Drawing.Size(470, 168);
            this.Question3.TabIndex = 10;
            this.Question3.TabStop = false;
            this.Question3.Text = "Pregunta 3";
            this.Question3.Enter += new System.EventHandler(this.Question3_Enter);
            // 
            // Quest3
            // 
            this.Quest3.AutoSize = true;
            this.Quest3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quest3.Location = new System.Drawing.Point(2, 26);
            this.Quest3.Name = "Quest3";
            this.Quest3.Size = new System.Drawing.Size(421, 19);
            this.Quest3.TabIndex = 5;
            this.Quest3.Text = "¿Cristiano es el jugador con mas balones de oro?";
            // 
            // False1
            // 
            this.False1.AutoSize = true;
            this.False1.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.False1.Location = new System.Drawing.Point(126, 111);
            this.False1.Name = "False1";
            this.False1.Size = new System.Drawing.Size(141, 49);
            this.False1.TabIndex = 2;
            this.False1.TabStop = true;
            this.False1.Text = "Falso";
            this.False1.UseVisualStyleBackColor = true;
            this.False1.CheckedChanged += new System.EventHandler(this.False1_CheckedChanged);
            this.False1.Click += new System.EventHandler(this.RadioQuestion3);
            // 
            // True1
            // 
            this.True1.AutoSize = true;
            this.True1.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.True1.Location = new System.Drawing.Point(126, 56);
            this.True1.Name = "True1";
            this.True1.Size = new System.Drawing.Size(243, 49);
            this.True1.TabIndex = 1;
            this.True1.TabStop = true;
            this.True1.Text = "Verdadero";
            this.True1.UseVisualStyleBackColor = true;
            this.True1.CheckedChanged += new System.EventHandler(this.True1_CheckedChanged);
            this.True1.Click += new System.EventHandler(this.RadioQuestion3);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(7, 26);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(0, 22);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Tag = "quest";
            // 
            // Question4
            // 
            this.Question4.Controls.Add(this.Quest4);
            this.Question4.Controls.Add(this.False2);
            this.Question4.Controls.Add(this.True2);
            this.Question4.Controls.Add(this.label2);
            this.Question4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question4.ForeColor = System.Drawing.SystemColors.Control;
            this.Question4.Location = new System.Drawing.Point(517, 315);
            this.Question4.Name = "Question4";
            this.Question4.Size = new System.Drawing.Size(451, 193);
            this.Question4.TabIndex = 11;
            this.Question4.TabStop = false;
            this.Question4.Text = "Pregunta 4";
            // 
            // Quest4
            // 
            this.Quest4.AutoSize = true;
            this.Quest4.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.Quest4.Location = new System.Drawing.Point(2, 26);
            this.Quest4.Name = "Quest4";
            this.Quest4.Size = new System.Drawing.Size(434, 22);
            this.Quest4.TabIndex = 5;
            this.Quest4.Text = "¿Algun Arquero a ganado algun balon de oro?";
            // 
            // False2
            // 
            this.False2.AutoSize = true;
            this.False2.Font = new System.Drawing.Font("Lucida Sans", 24F);
            this.False2.Location = new System.Drawing.Point(102, 124);
            this.False2.Name = "False2";
            this.False2.Size = new System.Drawing.Size(141, 49);
            this.False2.TabIndex = 2;
            this.False2.TabStop = true;
            this.False2.Tag = "False2";
            this.False2.Text = "Falso";
            this.False2.UseVisualStyleBackColor = true;
            this.False2.CheckedChanged += new System.EventHandler(this.False2_CheckedChanged);
            this.False2.Click += new System.EventHandler(this.RadioQuestion4);
            // 
            // True2
            // 
            this.True2.AutoSize = true;
            this.True2.Font = new System.Drawing.Font("Lucida Sans", 24F);
            this.True2.Location = new System.Drawing.Point(102, 69);
            this.True2.Name = "True2";
            this.True2.Size = new System.Drawing.Size(243, 49);
            this.True2.TabIndex = 1;
            this.True2.TabStop = true;
            this.True2.Tag = "True2";
            this.True2.Text = "Verdadero";
            this.True2.UseVisualStyleBackColor = true;
            this.True2.CheckedChanged += new System.EventHandler(this.True2_CheckedChanged);
            this.True2.Click += new System.EventHandler(this.RadioQuestion4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 0;
            this.label2.Tag = "quest";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Menu;
            this.Title.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Title.Location = new System.Drawing.Point(-2, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1024, 35);
            this.Title.TabIndex = 12;
            this.Title.Text = "CUESTIONARIO FUTBOLERO";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // continuebott
            // 
            this.continuebott.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continuebott.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuebott.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continuebott.Location = new System.Drawing.Point(884, 562);
            this.continuebott.Name = "continuebott";
            this.continuebott.Size = new System.Drawing.Size(138, 32);
            this.continuebott.TabIndex = 16;
            this.continuebott.Text = "Continuar";
            this.continuebott.UseVisualStyleBackColor = true;
            this.continuebott.Click += new System.EventHandler(this.continuebott_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Parcial_2.Properties.Resources.valdes;
            this.pictureBox2.Location = new System.Drawing.Point(12, 315);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parcial_2.Properties.Resources.CR7;
            this.pictureBox1.Location = new System.Drawing.Point(12, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1034, 597);
            this.Controls.Add(this.continuebott);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Question4);
            this.Controls.Add(this.Question3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Click += new System.EventHandler(this.RadioQuestion3);
            this.Question3.ResumeLayout(false);
            this.Question3.PerformLayout();
            this.Question4.ResumeLayout(false);
            this.Question4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Question3;
        private System.Windows.Forms.Label Quest3;
        private System.Windows.Forms.RadioButton False1;
        private System.Windows.Forms.RadioButton True1;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.GroupBox Question4;
        private System.Windows.Forms.Label Quest4;
        private System.Windows.Forms.RadioButton False2;
        private System.Windows.Forms.RadioButton True2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button continuebott;
    }
}