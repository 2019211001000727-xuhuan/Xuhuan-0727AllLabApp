namespace LabAss3
{
    partial class frmCustomerDataEntry
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
            this.btnPreview = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.radioUnmarried = new System.Windows.Forms.RadioButton();
            this.radioMarried = new System.Windows.Forms.RadioButton();
            this.chkPainting = new System.Windows.Forms.CheckBox();
            this.chkReading = new System.Windows.Forms.CheckBox();
            this.lblHobby = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(223, 445);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 19;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.radioUnmarried);
            this.GroupBox2.Controls.Add(this.radioMarried);
            this.GroupBox2.Location = new System.Drawing.Point(108, 342);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(323, 76);
            this.GroupBox2.TabIndex = 18;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Status";
            // 
            // radioUnmarried
            // 
            this.radioUnmarried.AutoSize = true;
            this.radioUnmarried.Location = new System.Drawing.Point(164, 39);
            this.radioUnmarried.Name = "radioUnmarried";
            this.radioUnmarried.Size = new System.Drawing.Size(100, 19);
            this.radioUnmarried.TabIndex = 1;
            this.radioUnmarried.TabStop = true;
            this.radioUnmarried.Text = "Unmarried";
            this.radioUnmarried.UseVisualStyleBackColor = true;
            // 
            // radioMarried
            // 
            this.radioMarried.AutoSize = true;
            this.radioMarried.Location = new System.Drawing.Point(18, 39);
            this.radioMarried.Name = "radioMarried";
            this.radioMarried.Size = new System.Drawing.Size(84, 19);
            this.radioMarried.TabIndex = 0;
            this.radioMarried.TabStop = true;
            this.radioMarried.Text = "Married";
            this.radioMarried.UseVisualStyleBackColor = true;
            // 
            // chkPainting
            // 
            this.chkPainting.AutoSize = true;
            this.chkPainting.Location = new System.Drawing.Point(331, 300);
            this.chkPainting.Name = "chkPainting";
            this.chkPainting.Size = new System.Drawing.Size(93, 19);
            this.chkPainting.TabIndex = 17;
            this.chkPainting.Text = "Painting";
            this.chkPainting.UseVisualStyleBackColor = true;
            // 
            // chkReading
            // 
            this.chkReading.AutoSize = true;
            this.chkReading.Location = new System.Drawing.Point(223, 300);
            this.chkReading.Name = "chkReading";
            this.chkReading.Size = new System.Drawing.Size(85, 19);
            this.chkReading.TabIndex = 16;
            this.chkReading.Text = "Reading";
            this.chkReading.UseVisualStyleBackColor = true;
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Location = new System.Drawing.Point(108, 300);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(63, 15);
            this.lblHobby.TabIndex = 15;
            this.lblHobby.Text = "Hobbies";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.radioFemale);
            this.GroupBox1.Controls.Add(this.radioMale);
            this.GroupBox1.Location = new System.Drawing.Point(108, 200);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(323, 76);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Gender";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(164, 38);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(76, 19);
            this.radioFemale.TabIndex = 1;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(18, 38);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(60, 19);
            this.radioMale.TabIndex = 0;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "China",
            "US",
            "Bangladesh"});
            this.cmbCountry.Location = new System.Drawing.Point(223, 148);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(208, 23);
            this.cmbCountry.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(223, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 25);
            this.txtName.TabIndex = 12;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(108, 148);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(63, 15);
            this.lblCountry.TabIndex = 11;
            this.lblCountry.Text = "Country";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(105, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 15);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Customer Name";
            // 
            // frmCustomerDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 578);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.chkPainting);
            this.Controls.Add(this.chkReading);
            this.Controls.Add(this.lblHobby);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblName);
            this.Name = "frmCustomerDataEntry";
            this.Text = "Customer Data Entry Screen";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.RadioButton radioUnmarried;
        private System.Windows.Forms.RadioButton radioMarried;
        private System.Windows.Forms.CheckBox chkPainting;
        private System.Windows.Forms.CheckBox chkReading;
        private System.Windows.Forms.Label lblHobby;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblName;
    }
}