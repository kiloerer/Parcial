namespace Parcial_2
{
    partial class Form3
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
            this.Question5 = new System.Windows.Forms.GroupBox();
            this.Quest5 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Quest3 = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.Question6 = new System.Windows.Forms.GroupBox();
            this.Quest6 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.continuebott = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Question5.SuspendLayout();
            this.Question6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Menu;
            this.Title.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Title.Location = new System.Drawing.Point(-2, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(967, 35);
            this.Title.TabIndex = 13;
            this.Title.Text = "CUESTIONARIO FUTBOLERO";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // Question5
            // 
            this.Question5.Controls.Add(this.Quest5);
            this.Question5.Controls.Add(this.label3);
            this.Question5.Controls.Add(this.Quest3);
            this.Question5.Controls.Add(this.QuestionLabel);
            this.Question5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question5.ForeColor = System.Drawing.SystemColors.Control;
            this.Question5.Location = new System.Drawing.Point(499, 89);
            this.Question5.Name = "Question5";
            this.Question5.Size = new System.Drawing.Size(454, 142);
            this.Question5.TabIndex = 14;
            this.Question5.TabStop = false;
            this.Question5.Text = "Pregunta 5";
            this.Question5.Enter += new System.EventHandler(this.Question5_Enter);
            // 
            // Quest5
            // 
            this.Quest5.BackColor = System.Drawing.Color.Peru;
            this.Quest5.FormattingEnabled = true;
            this.Quest5.Items.AddRange(new object[] {
            "AFICION",
            "HINCHADA",
            "GENTE",
            "EQUIPO"});
            this.Quest5.Location = new System.Drawing.Point(163, 24);
            this.Quest5.Name = "Quest5";
            this.Quest5.Size = new System.Drawing.Size(240, 31);
            this.Quest5.TabIndex = 6;
            this.Quest5.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 69);
            this.label3.TabIndex = 7;
            this.label3.Text = "Muchas gracias           \r\n\r\nesto es para vosotros! SIUUUUUUUUUUUU!";
            // 
            // Quest3
            // 
            this.Quest3.AutoSize = true;
            this.Quest3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quest3.Location = new System.Drawing.Point(2, 26);
            this.Quest3.Name = "Quest3";
            this.Quest3.Size = new System.Drawing.Size(0, 19);
            this.Quest3.TabIndex = 5;
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
            // Question6
            // 
            this.Question6.Controls.Add(this.Quest6);
            this.Question6.Controls.Add(this.label4);
            this.Question6.Controls.Add(this.label1);
            this.Question6.Controls.Add(this.label2);
            this.Question6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question6.ForeColor = System.Drawing.SystemColors.Control;
            this.Question6.Location = new System.Drawing.Point(499, 358);
            this.Question6.Name = "Question6";
            this.Question6.Size = new System.Drawing.Size(454, 139);
            this.Question6.TabIndex = 15;
            this.Question6.TabStop = false;
            this.Question6.Text = "Pregunta 6";
            this.Question6.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Quest6
            // 
            this.Quest6.BackColor = System.Drawing.Color.Peru;
            this.Quest6.FormattingEnabled = true;
            this.Quest6.Items.AddRange(new object[] {
            "COBRA",
            "DEFIENDE",
            "HACE",
            "GENERA",
            ""});
            this.Quest6.Location = new System.Drawing.Point(185, 26);
            this.Quest6.Name = "Quest6";
            this.Quest6.Size = new System.Drawing.Size(110, 31);
            this.Quest6.TabIndex = 6;
            this.Quest6.SelectedIndexChanged += new System.EventHandler(this.Quest6_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "EL QUE NO LOS                    \r\nLOS VE HACER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 5;
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
            // continuebott
            // 
            this.continuebott.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continuebott.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuebott.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continuebott.Location = new System.Drawing.Point(815, 639);
            this.continuebott.Name = "continuebott";
            this.continuebott.Size = new System.Drawing.Size(138, 32);
            this.continuebott.TabIndex = 17;
            this.continuebott.Text = "Continuar";
            this.continuebott.UseVisualStyleBackColor = true;
            this.continuebott.Click += new System.EventHandler(this.continuebott_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Parcial_2.Properties.Resources.messirve;
            this.pictureBox2.Location = new System.Drawing.Point(27, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parcial_2.Properties.Resources.valderrama;
            this.pictureBox1.Location = new System.Drawing.Point(27, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(965, 683);
            this.Controls.Add(this.continuebott);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Question6);
            this.Controls.Add(this.Question5);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Question5.ResumeLayout(false);
            this.Question5.PerformLayout();
            this.Question6.ResumeLayout(false);
            this.Question6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.GroupBox Question5;
        private System.Windows.Forms.Label Quest3;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.ComboBox Quest5;
        private System.Windows.Forms.GroupBox Question6;
        private System.Windows.Forms.ComboBox Quest6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button continuebott;
    }
}