namespace Parcial_2
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
            this.Title = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Question1 = new System.Windows.Forms.GroupBox();
            this.BQ4 = new System.Windows.Forms.Button();
            this.BQ3 = new System.Windows.Forms.Button();
            this.BQ1 = new System.Windows.Forms.Button();
            this.BQ2 = new System.Windows.Forms.Button();
            this.Quest1 = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.continuebott = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Question1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Menu;
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.Location = new System.Drawing.Point(0, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(413, 35);
            this.Title.TabIndex = 2;
            this.Title.Text = "Cuestionario Futbolero";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(12, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(390, 83);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "SI SE RESPONDE TODAS LAS PREGUNTAS CORRECTAMENTE, TU PUNTAJE SERA DE 75\n";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Question1
            // 
            this.Question1.AutoSize = true;
            this.Question1.Controls.Add(this.BQ4);
            this.Question1.Controls.Add(this.BQ3);
            this.Question1.Controls.Add(this.BQ1);
            this.Question1.Controls.Add(this.BQ2);
            this.Question1.Controls.Add(this.Quest1);
            this.Question1.Controls.Add(this.QuestionLabel);
            this.Question1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Question1.Location = new System.Drawing.Point(419, 12);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(486, 455);
            this.Question1.TabIndex = 5;
            this.Question1.TabStop = false;
            this.Question1.Text = "Pregunta ";
            this.Question1.Enter += new System.EventHandler(this.Question1_Enter);
            // 
            // BQ4
            // 
            this.BQ4.AutoSize = true;
            this.BQ4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BQ4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BQ4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BQ4.Location = new System.Drawing.Point(266, 289);
            this.BQ4.Name = "BQ4";
            this.BQ4.Size = new System.Drawing.Size(175, 136);
            this.BQ4.TabIndex = 9;
            this.BQ4.Tag = "4";
            this.BQ4.UseVisualStyleBackColor = true;
            // 
            // BQ3
            // 
            this.BQ3.AutoSize = true;
            this.BQ3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BQ3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BQ3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BQ3.Location = new System.Drawing.Point(25, 289);
            this.BQ3.Name = "BQ3";
            this.BQ3.Size = new System.Drawing.Size(175, 136);
            this.BQ3.TabIndex = 8;
            this.BQ3.Tag = "3";
            this.BQ3.UseVisualStyleBackColor = true;
            // 
            // BQ1
            // 
            this.BQ1.AutoSize = true;
            this.BQ1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BQ1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BQ1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BQ1.Location = new System.Drawing.Point(25, 67);
            this.BQ1.Name = "BQ1";
            this.BQ1.Size = new System.Drawing.Size(175, 137);
            this.BQ1.TabIndex = 7;
            this.BQ1.Tag = "1";
            this.BQ1.UseVisualStyleBackColor = true;
            // 
            // BQ2
            // 
            this.BQ2.AutoSize = true;
            this.BQ2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BQ2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BQ2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BQ2.Location = new System.Drawing.Point(266, 67);
            this.BQ2.Name = "BQ2";
            this.BQ2.Size = new System.Drawing.Size(175, 137);
            this.BQ2.TabIndex = 6;
            this.BQ2.Tag = "2";
            this.BQ2.UseVisualStyleBackColor = true;
            // 
            // Quest1
            // 
            this.Quest1.AutoEllipsis = true;
            this.Quest1.AutoSize = true;
            this.Quest1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Quest1.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.Quest1.Location = new System.Drawing.Point(3, 27);
            this.Quest1.Name = "Quest1";
            this.Quest1.Size = new System.Drawing.Size(0, 22);
            this.Quest1.TabIndex = 5;
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
            // continuebott
            // 
            this.continuebott.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continuebott.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuebott.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continuebott.Location = new System.Drawing.Point(773, 473);
            this.continuebott.Name = "continuebott";
            this.continuebott.Size = new System.Drawing.Size(138, 32);
            this.continuebott.TabIndex = 18;
            this.continuebott.Text = "Continuar";
            this.continuebott.UseVisualStyleBackColor = true;
            this.continuebott.Click += new System.EventHandler(this.continuebott_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parcial_2.Properties.Resources.Primermundial1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(923, 510);
            this.Controls.Add(this.continuebott);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Question1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Question1.ResumeLayout(false);
            this.Question1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox Question1;
        private System.Windows.Forms.Label Quest1;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button BQ4;
        private System.Windows.Forms.Button BQ3;
        private System.Windows.Forms.Button BQ1;
        private System.Windows.Forms.Button BQ2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button continuebott;
    }
}

