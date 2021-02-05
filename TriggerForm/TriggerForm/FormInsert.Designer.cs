namespace TriggerForm
{
    partial class FormInsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nmudNumber = new System.Windows.Forms.NumericUpDown();
            this.nmudTeamID = new System.Windows.Forms.NumericUpDown();
            this.nmudPodiusNumber = new System.Windows.Forms.NumericUpDown();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnUpHelmetImage = new System.Windows.Forms.Button();
            this.btnUpFullImage = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmudNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudPodiusNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "full_name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "country:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "date_birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "team_id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "podius_number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "helmet_image:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "full_image:";
            // 
            // nmudNumber
            // 
            this.nmudNumber.Location = new System.Drawing.Point(141, 30);
            this.nmudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudNumber.Name = "nmudNumber";
            this.nmudNumber.Size = new System.Drawing.Size(120, 22);
            this.nmudNumber.TabIndex = 8;
            this.nmudNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmudTeamID
            // 
            this.nmudTeamID.Location = new System.Drawing.Point(141, 170);
            this.nmudTeamID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudTeamID.Name = "nmudTeamID";
            this.nmudTeamID.Size = new System.Drawing.Size(120, 22);
            this.nmudTeamID.TabIndex = 9;
            this.nmudTeamID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmudPodiusNumber
            // 
            this.nmudPodiusNumber.Location = new System.Drawing.Point(141, 205);
            this.nmudPodiusNumber.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nmudPodiusNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudPodiusNumber.Name = "nmudPodiusNumber";
            this.nmudPodiusNumber.Size = new System.Drawing.Size(120, 22);
            this.nmudPodiusNumber.TabIndex = 10;
            this.nmudPodiusNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(141, 64);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(120, 22);
            this.txtFullName.TabIndex = 11;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(141, 99);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(120, 22);
            this.txtCountry.TabIndex = 12;
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(141, 137);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(120, 22);
            this.dtp.TabIndex = 13;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnUpHelmetImage
            // 
            this.btnUpHelmetImage.Enabled = false;
            this.btnUpHelmetImage.Location = new System.Drawing.Point(141, 239);
            this.btnUpHelmetImage.Name = "btnUpHelmetImage";
            this.btnUpHelmetImage.Size = new System.Drawing.Size(120, 29);
            this.btnUpHelmetImage.TabIndex = 14;
            this.btnUpHelmetImage.Text = "Upload image";
            this.btnUpHelmetImage.UseVisualStyleBackColor = true;
            // 
            // btnUpFullImage
            // 
            this.btnUpFullImage.Enabled = false;
            this.btnUpFullImage.Location = new System.Drawing.Point(141, 271);
            this.btnUpFullImage.Name = "btnUpFullImage";
            this.btnUpFullImage.Size = new System.Drawing.Size(120, 29);
            this.btnUpFullImage.TabIndex = 16;
            this.btnUpFullImage.Text = "Upload image";
            this.btnUpFullImage.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(15, 312);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(246, 29);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Done";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // FormInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 353);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpFullImage);
            this.Controls.Add(this.btnUpHelmetImage);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.nmudPodiusNumber);
            this.Controls.Add(this.nmudTeamID);
            this.Controls.Add(this.nmudNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(301, 400);
            this.Name = "FormInsert";
            this.ShowIcon = false;
            this.Text = "Insert a new Driver";
            ((System.ComponentModel.ISupportInitialize)(this.nmudNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudPodiusNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmudNumber;
        private System.Windows.Forms.NumericUpDown nmudTeamID;
        private System.Windows.Forms.NumericUpDown nmudPodiusNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnUpHelmetImage;
        private System.Windows.Forms.Button btnUpFullImage;
        private System.Windows.Forms.Button btnInsert;
    }
}