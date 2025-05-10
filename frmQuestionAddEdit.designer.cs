namespace LSSEastProblemsDB
{
    partial class frmNewQuestion
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
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.rtxSuggetions = new System.Windows.Forms.RichTextBox();
            this.rtxPrompt = new System.Windows.Forms.RichTextBox();
            this.rtxAnswer = new System.Windows.Forms.RichTextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblSuggestions = new System.Windows.Forms.Label();
            this.chkCompleted = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(20, 17);
            this.lblCourseCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(104, 17);
            this.lblCourseCode.TabIndex = 7;
            this.lblCourseCode.Text = "Course Code:";
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(139, 17);
            this.txtCourseCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.ReadOnly = true;
            this.txtCourseCode.Size = new System.Drawing.Size(149, 23);
            this.txtCourseCode.TabIndex = 12;
            this.txtCourseCode.Tag = "Item no";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(68, 51);
            this.lblTopic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(56, 17);
            this.lblTopic.TabIndex = 8;
            this.lblTopic.Text = "Topic:";
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(138, 48);
            this.txtTopic.Margin = new System.Windows.Forms.Padding(4);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(284, 23);
            this.txtTopic.TabIndex = 0;
            this.txtTopic.Tag = "Description";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(138, 416);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(303, 416);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(60, 109);
            this.lblPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(64, 17);
            this.lblPrompt.TabIndex = 9;
            this.lblPrompt.Text = "Prompt:";
            // 
            // rtxSuggetions
            // 
            this.rtxSuggetions.Location = new System.Drawing.Point(139, 211);
            this.rtxSuggetions.Name = "rtxSuggetions";
            this.rtxSuggetions.Size = new System.Drawing.Size(443, 96);
            this.rtxSuggetions.TabIndex = 2;
            this.rtxSuggetions.Text = "";
            // 
            // rtxPrompt
            // 
            this.rtxPrompt.Location = new System.Drawing.Point(139, 109);
            this.rtxPrompt.Name = "rtxPrompt";
            this.rtxPrompt.Size = new System.Drawing.Size(443, 96);
            this.rtxPrompt.TabIndex = 1;
            this.rtxPrompt.Text = "";
            // 
            // rtxAnswer
            // 
            this.rtxAnswer.Location = new System.Drawing.Point(139, 313);
            this.rtxAnswer.Name = "rtxAnswer";
            this.rtxAnswer.Size = new System.Drawing.Size(443, 60);
            this.rtxAnswer.TabIndex = 3;
            this.rtxAnswer.Text = "";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(60, 316);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(64, 17);
            this.lblAnswer.TabIndex = 11;
            this.lblAnswer.Text = "Answer:";
            // 
            // lblSuggestions
            // 
            this.lblSuggestions.AutoSize = true;
            this.lblSuggestions.Location = new System.Drawing.Point(20, 214);
            this.lblSuggestions.Name = "lblSuggestions";
            this.lblSuggestions.Size = new System.Drawing.Size(104, 17);
            this.lblSuggestions.TabIndex = 10;
            this.lblSuggestions.Text = "Suggestions:";
            // 
            // chkCompleted
            // 
            this.chkCompleted.AutoSize = true;
            this.chkCompleted.Location = new System.Drawing.Point(483, 379);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.Size = new System.Drawing.Size(99, 21);
            this.chkCompleted.TabIndex = 4;
            this.chkCompleted.Text = "Completed";
            this.chkCompleted.UseVisualStyleBackColor = true;
            // 
            // frmNewQuestion
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(630, 470);
            this.ControlBox = false;
            this.Controls.Add(this.chkCompleted);
            this.Controls.Add(this.lblSuggestions);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.rtxAnswer);
            this.Controls.Add(this.rtxPrompt);
            this.Controls.Add(this.rtxSuggetions);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.lblCourseCode);
            this.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submit New Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.RichTextBox rtxSuggetions;
        private System.Windows.Forms.RichTextBox rtxPrompt;
        private System.Windows.Forms.RichTextBox rtxAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblSuggestions;
        private System.Windows.Forms.CheckBox chkCompleted;
    }
}