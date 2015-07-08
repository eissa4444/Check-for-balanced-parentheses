namespace Check_for_balanced_parentheses_using_stack
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
            this.wrightpbox = new System.Windows.Forms.PictureBox();
            this.wrongpbox = new System.Windows.Forms.PictureBox();
            this.labout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wrightpbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongpbox)).BeginInit();
            this.SuspendLayout();
            // 
            // wrightpbox
            // 
            this.wrightpbox.Image = global::Check_for_balanced_parentheses_using_stack.Properties.Resources.right_sign_accept_achievement_icon_67197761;
            this.wrightpbox.Location = new System.Drawing.Point(427, 233);
            this.wrightpbox.Name = "wrightpbox";
            this.wrightpbox.Size = new System.Drawing.Size(44, 34);
            this.wrightpbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wrightpbox.TabIndex = 2;
            this.wrightpbox.TabStop = false;
            // 
            // wrongpbox
            // 
            this.wrongpbox.Image = global::Check_for_balanced_parentheses_using_stack.Properties.Resources.Cross_Sign_1692450;
            this.wrongpbox.Location = new System.Drawing.Point(427, 233);
            this.wrongpbox.Name = "wrongpbox";
            this.wrongpbox.Size = new System.Drawing.Size(44, 34);
            this.wrongpbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wrongpbox.TabIndex = 2;
            this.wrongpbox.TabStop = false;
            // 
            // labout
            // 
            this.labout.AutoSize = true;
            this.labout.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labout.ForeColor = System.Drawing.Color.Red;
            this.labout.Location = new System.Drawing.Point(40, 239);
            this.labout.Name = "labout";
            this.labout.Size = new System.Drawing.Size(0, 18);
            this.labout.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(512, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "By : M.Eissa";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Crimson;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(600, 200);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 318);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labout);
            this.Controls.Add(this.wrongpbox);
            this.Controls.Add(this.wrightpbox);
            this.Name = "Form1";
            this.Text = "check if balanced parenthes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wrightpbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongpbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wrightpbox;
        private System.Windows.Forms.PictureBox wrongpbox;
        private System.Windows.Forms.Label labout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

