namespace EntityFrameTest2
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
            this.cmdQuery1 = new System.Windows.Forms.Button();
            this.cmdQuantifiers = new System.Windows.Forms.Button();
            this.cmdRelation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdQuery1
            // 
            this.cmdQuery1.Location = new System.Drawing.Point(26, 31);
            this.cmdQuery1.Name = "cmdQuery1";
            this.cmdQuery1.Size = new System.Drawing.Size(85, 43);
            this.cmdQuery1.TabIndex = 0;
            this.cmdQuery1.Text = "query 1";
            this.cmdQuery1.UseVisualStyleBackColor = true;
            this.cmdQuery1.Click += new System.EventHandler(this.cmdQuery1_Click);
            // 
            // cmdQuantifiers
            // 
            this.cmdQuantifiers.Location = new System.Drawing.Point(140, 28);
            this.cmdQuantifiers.Name = "cmdQuantifiers";
            this.cmdQuantifiers.Size = new System.Drawing.Size(85, 46);
            this.cmdQuantifiers.TabIndex = 1;
            this.cmdQuantifiers.Text = "quantifiers";
            this.cmdQuantifiers.UseVisualStyleBackColor = true;
            this.cmdQuantifiers.Click += new System.EventHandler(this.cmdQuantifiers_Click);
            // 
            // cmdRelation
            // 
            this.cmdRelation.Location = new System.Drawing.Point(252, 29);
            this.cmdRelation.Name = "cmdRelation";
            this.cmdRelation.Size = new System.Drawing.Size(85, 46);
            this.cmdRelation.TabIndex = 2;
            this.cmdRelation.Text = "relation";
            this.cmdRelation.UseVisualStyleBackColor = true;
            this.cmdRelation.Click += new System.EventHandler(this.cmdRelation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 269);
            this.Controls.Add(this.cmdRelation);
            this.Controls.Add(this.cmdQuantifiers);
            this.Controls.Add(this.cmdQuery1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdQuery1;
        private System.Windows.Forms.Button cmdQuantifiers;
        private System.Windows.Forms.Button cmdRelation;
    }
}

