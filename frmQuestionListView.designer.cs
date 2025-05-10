namespace LSSEastProblemsDB
{
    partial class frmListQuestions
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.llLogout = new System.Windows.Forms.LinkLabel();
            this.lblTopic = new System.Windows.Forms.Label();
            this.lvProblems = new System.Windows.Forms.ListView();
            this.Topic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Answer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(358, 486);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 31);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(358, 431);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 31);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Remove Question";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(358, 355);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Question";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(358, 393);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 31);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update Question";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // llLogout
            // 
            this.llLogout.AutoSize = true;
            this.llLogout.Location = new System.Drawing.Point(10, 549);
            this.llLogout.Name = "llLogout";
            this.llLogout.Size = new System.Drawing.Size(56, 17);
            this.llLogout.TabIndex = 12;
            this.llLogout.TabStop = true;
            this.llLogout.Text = "Logout";
            this.llLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLogout_LinkClicked);
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(10, 26);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(464, 17);
            this.lblTopic.TabIndex = 13;
            this.lblTopic.Text = "Double-Click a topic to view a related question or prompt";
            // 
            // lvProblems
            // 
            this.lvProblems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Topic,
            this.Answer});
            this.lvProblems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvProblems.FullRowSelect = true;
            this.lvProblems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvProblems.HideSelection = false;
            this.lvProblems.Location = new System.Drawing.Point(13, 46);
            this.lvProblems.MultiSelect = false;
            this.lvProblems.Name = "lvProblems";
            this.lvProblems.Size = new System.Drawing.Size(338, 500);
            this.lvProblems.TabIndex = 14;
            this.lvProblems.UseCompatibleStateImageBehavior = false;
            this.lvProblems.View = System.Windows.Forms.View.Details;
            this.lvProblems.DoubleClick += new System.EventHandler(this.lvProblems_DoubleClick);
            // 
            // Topic
            // 
            this.Topic.Text = "Topic";
            this.Topic.Width = 150;
            // 
            // Answer
            // 
            this.Answer.Text = "Answer";
            this.Answer.Width = 150;
            // 
            // frmListQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(510, 575);
            this.Controls.Add(this.lvProblems);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.llLogout);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions List View";
            this.Load += new System.EventHandler(this.frmListQuestions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.LinkLabel llLogout;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.ListView lvProblems;
        private System.Windows.Forms.ColumnHeader Topic;
        private System.Windows.Forms.ColumnHeader Answer;
    }
}

