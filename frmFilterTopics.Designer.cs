namespace LSSEastProblemsDB
{
    partial class frmFilterTopics
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
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.cboCourseNo = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboSubject
            // 
            this.cboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(105, 57);
            this.cboSubject.Margin = new System.Windows.Forms.Padding(4);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(265, 25);
            this.cboSubject.TabIndex = 0;
            this.cboSubject.SelectedIndexChanged += new System.EventHandler(this.cboSubject_SelectedIndexChanged);
            // 
            // cboCourseNo
            // 
            this.cboCourseNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourseNo.Enabled = false;
            this.cboCourseNo.FormattingEnabled = true;
            this.cboCourseNo.Location = new System.Drawing.Point(548, 57);
            this.cboCourseNo.Margin = new System.Windows.Forms.Padding(4);
            this.cboCourseNo.Name = "cboCourseNo";
            this.cboCourseNo.Size = new System.Drawing.Size(265, 25);
            this.cboCourseNo.TabIndex = 1;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(421, 60);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(120, 17);
            this.lblCourse.TabIndex = 2;
            this.lblCourse.Text = "Course Number:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(26, 60);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(72, 17);
            this.lblSubject.TabIndex = 3;
            this.lblSubject.Text = "Subject:";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.Location = new System.Drawing.Point(351, 9);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(166, 25);
            this.lblTopic.TabIndex = 4;
            this.lblTopic.Text = "Select a Topic";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(735, 429);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(78, 36);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "View";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(612, 429);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 36);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Return";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmFilterTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 477);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.cboCourseNo);
            this.Controls.Add(this.cboSubject);
            this.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFilterTopics";
            this.Text = "frmFilterTopics";
            this.Load += new System.EventHandler(this.frmFilterTopics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.ComboBox cboCourseNo;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
    }
}