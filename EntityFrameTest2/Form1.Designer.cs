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
            this.cmdProjections = new System.Windows.Forms.Button();
            this.cmdQuery2 = new System.Windows.Forms.Button();
            this.cmdPaging = new System.Windows.Forms.Button();
            this.cmdJoin = new System.Windows.Forms.Button();
            this.cmdGroupby = new System.Windows.Forms.Button();
            this.cmdSelectmany = new System.Windows.Forms.Button();
            this.cmdUnion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdStoreproc = new System.Windows.Forms.Button();
            this.cmdAsync = new System.Windows.Forms.Button();
            this.cmdNewPerson = new System.Windows.Forms.Button();
            this.cmdConcurrency = new System.Windows.Forms.Button();
            this.cmdRawQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdQuery1
            // 
            this.cmdQuery1.Location = new System.Drawing.Point(33, 14);
            this.cmdQuery1.Name = "cmdQuery1";
            this.cmdQuery1.Size = new System.Drawing.Size(85, 43);
            this.cmdQuery1.TabIndex = 0;
            this.cmdQuery1.Text = "query 1";
            this.cmdQuery1.UseVisualStyleBackColor = true;
            this.cmdQuery1.Click += new System.EventHandler(this.cmdQuery1_Click);
            // 
            // cmdQuantifiers
            // 
            this.cmdQuantifiers.Location = new System.Drawing.Point(147, 11);
            this.cmdQuantifiers.Name = "cmdQuantifiers";
            this.cmdQuantifiers.Size = new System.Drawing.Size(85, 46);
            this.cmdQuantifiers.TabIndex = 1;
            this.cmdQuantifiers.Text = "quantifiers";
            this.cmdQuantifiers.UseVisualStyleBackColor = true;
            this.cmdQuantifiers.Click += new System.EventHandler(this.cmdQuantifiers_Click);
            // 
            // cmdRelation
            // 
            this.cmdRelation.Location = new System.Drawing.Point(259, 12);
            this.cmdRelation.Name = "cmdRelation";
            this.cmdRelation.Size = new System.Drawing.Size(85, 46);
            this.cmdRelation.TabIndex = 2;
            this.cmdRelation.Text = "relation";
            this.cmdRelation.UseVisualStyleBackColor = true;
            this.cmdRelation.Click += new System.EventHandler(this.cmdRelation_Click);
            // 
            // cmdProjections
            // 
            this.cmdProjections.Location = new System.Drawing.Point(373, 12);
            this.cmdProjections.Name = "cmdProjections";
            this.cmdProjections.Size = new System.Drawing.Size(85, 46);
            this.cmdProjections.TabIndex = 3;
            this.cmdProjections.Text = "projections";
            this.cmdProjections.UseVisualStyleBackColor = true;
            this.cmdProjections.Click += new System.EventHandler(this.cmdProjections_Click);
            // 
            // cmdQuery2
            // 
            this.cmdQuery2.Location = new System.Drawing.Point(33, 74);
            this.cmdQuery2.Name = "cmdQuery2";
            this.cmdQuery2.Size = new System.Drawing.Size(85, 48);
            this.cmdQuery2.TabIndex = 4;
            this.cmdQuery2.Text = "advanced query construction";
            this.cmdQuery2.UseVisualStyleBackColor = true;
            this.cmdQuery2.Click += new System.EventHandler(this.cmdQuery2_Click);
            // 
            // cmdPaging
            // 
            this.cmdPaging.Location = new System.Drawing.Point(147, 74);
            this.cmdPaging.Name = "cmdPaging";
            this.cmdPaging.Size = new System.Drawing.Size(85, 48);
            this.cmdPaging.TabIndex = 5;
            this.cmdPaging.Text = "paging";
            this.cmdPaging.UseVisualStyleBackColor = true;
            this.cmdPaging.Click += new System.EventHandler(this.cmdPaging_Click);
            // 
            // cmdJoin
            // 
            this.cmdJoin.Location = new System.Drawing.Point(259, 74);
            this.cmdJoin.Name = "cmdJoin";
            this.cmdJoin.Size = new System.Drawing.Size(85, 48);
            this.cmdJoin.TabIndex = 6;
            this.cmdJoin.Text = "Join";
            this.cmdJoin.UseVisualStyleBackColor = true;
            this.cmdJoin.Click += new System.EventHandler(this.cmdJoin_Click);
            // 
            // cmdGroupby
            // 
            this.cmdGroupby.Location = new System.Drawing.Point(373, 74);
            this.cmdGroupby.Name = "cmdGroupby";
            this.cmdGroupby.Size = new System.Drawing.Size(85, 48);
            this.cmdGroupby.TabIndex = 7;
            this.cmdGroupby.Text = "group by";
            this.cmdGroupby.UseVisualStyleBackColor = true;
            this.cmdGroupby.Click += new System.EventHandler(this.cmdGroupby_Click);
            // 
            // cmdSelectmany
            // 
            this.cmdSelectmany.Location = new System.Drawing.Point(33, 138);
            this.cmdSelectmany.Name = "cmdSelectmany";
            this.cmdSelectmany.Size = new System.Drawing.Size(85, 48);
            this.cmdSelectmany.TabIndex = 8;
            this.cmdSelectmany.Text = "select many";
            this.cmdSelectmany.UseVisualStyleBackColor = true;
            this.cmdSelectmany.Click += new System.EventHandler(this.cmdSelectmany_Click);
            // 
            // cmdUnion
            // 
            this.cmdUnion.Location = new System.Drawing.Point(147, 138);
            this.cmdUnion.Name = "cmdUnion";
            this.cmdUnion.Size = new System.Drawing.Size(85, 48);
            this.cmdUnion.TabIndex = 9;
            this.cmdUnion.Text = "Distinct + Union";
            this.cmdUnion.UseVisualStyleBackColor = true;
            this.cmdUnion.Click += new System.EventHandler(this.cmdUnion_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(26, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 10);
            this.panel1.TabIndex = 10;
            // 
            // cmdStoreproc
            // 
            this.cmdStoreproc.Location = new System.Drawing.Point(33, 208);
            this.cmdStoreproc.Name = "cmdStoreproc";
            this.cmdStoreproc.Size = new System.Drawing.Size(85, 48);
            this.cmdStoreproc.TabIndex = 11;
            this.cmdStoreproc.Text = "store procedure";
            this.cmdStoreproc.UseVisualStyleBackColor = true;
            this.cmdStoreproc.Click += new System.EventHandler(this.cmdStoreproc_Click);
            // 
            // cmdAsync
            // 
            this.cmdAsync.Location = new System.Drawing.Point(147, 208);
            this.cmdAsync.Name = "cmdAsync";
            this.cmdAsync.Size = new System.Drawing.Size(85, 48);
            this.cmdAsync.TabIndex = 12;
            this.cmdAsync.Text = "Async";
            this.cmdAsync.UseVisualStyleBackColor = true;
            this.cmdAsync.Click += new System.EventHandler(this.cmdAsync_Click);
            // 
            // cmdNewPerson
            // 
            this.cmdNewPerson.Location = new System.Drawing.Point(259, 138);
            this.cmdNewPerson.Name = "cmdNewPerson";
            this.cmdNewPerson.Size = new System.Drawing.Size(85, 48);
            this.cmdNewPerson.TabIndex = 13;
            this.cmdNewPerson.Text = "crea record";
            this.cmdNewPerson.UseVisualStyleBackColor = true;
            this.cmdNewPerson.Click += new System.EventHandler(this.cmdNewPerson_Click);
            // 
            // cmdConcurrency
            // 
            this.cmdConcurrency.Location = new System.Drawing.Point(259, 208);
            this.cmdConcurrency.Name = "cmdConcurrency";
            this.cmdConcurrency.Size = new System.Drawing.Size(85, 48);
            this.cmdConcurrency.TabIndex = 14;
            this.cmdConcurrency.Text = "Concurrency";
            this.cmdConcurrency.UseVisualStyleBackColor = true;
            this.cmdConcurrency.Click += new System.EventHandler(this.cmdConcurrency_Click);
            // 
            // cmdRawQuery
            // 
            this.cmdRawQuery.Location = new System.Drawing.Point(373, 208);
            this.cmdRawQuery.Name = "cmdRawQuery";
            this.cmdRawQuery.Size = new System.Drawing.Size(85, 48);
            this.cmdRawQuery.TabIndex = 15;
            this.cmdRawQuery.Text = "Raw query dynamic";
            this.cmdRawQuery.UseVisualStyleBackColor = true;
            this.cmdRawQuery.Click += new System.EventHandler(this.cmdRawQuery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 334);
            this.Controls.Add(this.cmdRawQuery);
            this.Controls.Add(this.cmdConcurrency);
            this.Controls.Add(this.cmdNewPerson);
            this.Controls.Add(this.cmdAsync);
            this.Controls.Add(this.cmdStoreproc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdUnion);
            this.Controls.Add(this.cmdSelectmany);
            this.Controls.Add(this.cmdGroupby);
            this.Controls.Add(this.cmdJoin);
            this.Controls.Add(this.cmdPaging);
            this.Controls.Add(this.cmdQuery2);
            this.Controls.Add(this.cmdProjections);
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
        private System.Windows.Forms.Button cmdProjections;
        private System.Windows.Forms.Button cmdQuery2;
        private System.Windows.Forms.Button cmdPaging;
        private System.Windows.Forms.Button cmdJoin;
        private System.Windows.Forms.Button cmdGroupby;
        private System.Windows.Forms.Button cmdSelectmany;
        private System.Windows.Forms.Button cmdUnion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdStoreproc;
        private System.Windows.Forms.Button cmdAsync;
        private System.Windows.Forms.Button cmdNewPerson;
        private System.Windows.Forms.Button cmdConcurrency;
        private System.Windows.Forms.Button cmdRawQuery;
    }
}

