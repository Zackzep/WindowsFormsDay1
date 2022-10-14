namespace WindowsFormsDay1
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.lbCourseName = new System.Windows.Forms.Label();
            this.lbCourseId = new System.Windows.Forms.Label();
            this.tbCourseId = new System.Windows.Forms.TextBox();
            this.lbRoomNumber = new System.Windows.Forms.Label();
            this.tbRoomNumber = new System.Windows.Forms.TextBox();
            this.lbTeacher = new System.Windows.Forms.Label();
            this.tbStudent = new System.Windows.Forms.TextBox();
            this.lbStudent = new System.Windows.Forms.Label();
            this.tbTeacher = new System.Windows.Forms.TextBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(268, 355);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(220, 74);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(498, 22);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(290, 22);
            this.tbCourseName.TabIndex = 1;
            // 
            // lbCourseName
            // 
            this.lbCourseName.AutoSize = true;
            this.lbCourseName.Location = new System.Drawing.Point(398, 28);
            this.lbCourseName.Name = "lbCourseName";
            this.lbCourseName.Size = new System.Drawing.Size(90, 16);
            this.lbCourseName.TabIndex = 2;
            this.lbCourseName.Text = "Course Name";
            // 
            // lbCourseId
            // 
            this.lbCourseId.AutoSize = true;
            this.lbCourseId.Location = new System.Drawing.Point(398, 65);
            this.lbCourseId.Name = "lbCourseId";
            this.lbCourseId.Size = new System.Drawing.Size(66, 16);
            this.lbCourseId.TabIndex = 4;
            this.lbCourseId.Text = "Course ID";
            // 
            // tbCourseId
            // 
            this.tbCourseId.Location = new System.Drawing.Point(498, 62);
            this.tbCourseId.Name = "tbCourseId";
            this.tbCourseId.Size = new System.Drawing.Size(290, 22);
            this.tbCourseId.TabIndex = 3;
            // 
            // lbRoomNumber
            // 
            this.lbRoomNumber.AutoSize = true;
            this.lbRoomNumber.Location = new System.Drawing.Point(393, 109);
            this.lbRoomNumber.Name = "lbRoomNumber";
            this.lbRoomNumber.Size = new System.Drawing.Size(95, 16);
            this.lbRoomNumber.TabIndex = 6;
            this.lbRoomNumber.Text = "Room Number";
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.Location = new System.Drawing.Point(498, 103);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(290, 22);
            this.tbRoomNumber.TabIndex = 5;
            // 
            // lbTeacher
            // 
            this.lbTeacher.AutoSize = true;
            this.lbTeacher.Location = new System.Drawing.Point(392, 201);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.Size = new System.Drawing.Size(58, 16);
            this.lbTeacher.TabIndex = 8;
            this.lbTeacher.Text = "Teacher";
            // 
            // tbStudent
            // 
            this.tbStudent.Location = new System.Drawing.Point(498, 147);
            this.tbStudent.Name = "tbStudent";
            this.tbStudent.Size = new System.Drawing.Size(290, 22);
            this.tbStudent.TabIndex = 7;
            // 
            // lbStudent
            // 
            this.lbStudent.AutoSize = true;
            this.lbStudent.Location = new System.Drawing.Point(398, 153);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.Size = new System.Drawing.Size(52, 16);
            this.lbStudent.TabIndex = 10;
            this.lbStudent.Text = "Student";
            // 
            // tbTeacher
            // 
            this.tbTeacher.Location = new System.Drawing.Point(498, 195);
            this.tbTeacher.Name = "tbTeacher";
            this.tbTeacher.Size = new System.Drawing.Size(290, 22);
            this.tbTeacher.TabIndex = 9;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(12, 43);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(342, 263);
            this.rtbDisplay.TabIndex = 11;
            this.rtbDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.lbStudent);
            this.Controls.Add(this.tbTeacher);
            this.Controls.Add(this.lbTeacher);
            this.Controls.Add(this.tbStudent);
            this.Controls.Add(this.lbRoomNumber);
            this.Controls.Add(this.tbRoomNumber);
            this.Controls.Add(this.lbCourseId);
            this.Controls.Add(this.tbCourseId);
            this.Controls.Add(this.lbCourseName);
            this.Controls.Add(this.tbCourseName);
            this.Controls.Add(this.btnDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.Label lbCourseName;
        private System.Windows.Forms.Label lbCourseId;
        private System.Windows.Forms.TextBox tbCourseId;
        private System.Windows.Forms.Label lbRoomNumber;
        private System.Windows.Forms.TextBox tbRoomNumber;
        private System.Windows.Forms.Label lbTeacher;
        private System.Windows.Forms.TextBox tbStudent;
        private System.Windows.Forms.Label lbStudent;
        private System.Windows.Forms.TextBox tbTeacher;
        private System.Windows.Forms.RichTextBox rtbDisplay;
    }
}

