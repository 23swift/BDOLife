namespace ProposalApplicationUtil
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectPDF = new System.Windows.Forms.Button();
            this.txtPDFPath = new System.Windows.Forms.TextBox();
            this.btnSelectTemp = new System.Windows.Forms.Button();
            this.txtTempPath = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblApplicationNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnUpdatePDF = new System.Windows.Forms.Button();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalPages = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLocation = new System.Windows.Forms.Button();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.btnSelectLicense = new System.Windows.Forms.Button();
            this.txtTrial = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(618, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Load Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectLicense);
            this.groupBox1.Controls.Add(this.txtTrial);
            this.groupBox1.Controls.Add(this.btnSelectPDF);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtPDFPath);
            this.groupBox1.Controls.Add(this.btnSelectTemp);
            this.groupBox1.Controls.Add(this.txtTempPath);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblApplicationNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 275);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read Application PDF Data";
            // 
            // btnSelectPDF
            // 
            this.btnSelectPDF.Location = new System.Drawing.Point(496, 191);
            this.btnSelectPDF.Name = "btnSelectPDF";
            this.btnSelectPDF.Size = new System.Drawing.Size(145, 23);
            this.btnSelectPDF.TabIndex = 11;
            this.btnSelectPDF.Text = "Select PDF File To Read";
            this.btnSelectPDF.UseVisualStyleBackColor = true;
            this.btnSelectPDF.Click += new System.EventHandler(this.btnSelectPDF_Click);
            // 
            // txtPDFPath
            // 
            this.txtPDFPath.Enabled = false;
            this.txtPDFPath.Location = new System.Drawing.Point(23, 193);
            this.txtPDFPath.Name = "txtPDFPath";
            this.txtPDFPath.Size = new System.Drawing.Size(467, 20);
            this.txtPDFPath.TabIndex = 10;
            this.txtPDFPath.TextChanged += new System.EventHandler(this.txtPDFPath_TextChanged);
            // 
            // btnSelectTemp
            // 
            this.btnSelectTemp.Location = new System.Drawing.Point(496, 162);
            this.btnSelectTemp.Name = "btnSelectTemp";
            this.btnSelectTemp.Size = new System.Drawing.Size(145, 23);
            this.btnSelectTemp.TabIndex = 9;
            this.btnSelectTemp.Text = "Select Data Template";
            this.btnSelectTemp.UseVisualStyleBackColor = true;
            this.btnSelectTemp.Click += new System.EventHandler(this.btnSelectTemp_Click);
            // 
            // txtTempPath
            // 
            this.txtTempPath.Enabled = false;
            this.txtTempPath.Location = new System.Drawing.Point(23, 164);
            this.txtTempPath.Name = "txtTempPath";
            this.txtTempPath.Size = new System.Drawing.Size(467, 20);
            this.txtTempPath.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(85, 100);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 13);
            this.lblAddress.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address:";
            // 
            // lblApplicationNo
            // 
            this.lblApplicationNo.AutoSize = true;
            this.lblApplicationNo.Location = new System.Drawing.Point(570, 16);
            this.lblApplicationNo.Name = "lblApplicationNo";
            this.lblApplicationNo.Size = new System.Drawing.Size(79, 13);
            this.lblApplicationNo.TabIndex = 5;
            this.lblApplicationNo.Text = "Application No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Application No.:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(85, 66);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(84, 43);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutPut);
            this.groupBox2.Controls.Add(this.btnLocation);
            this.groupBox2.Controls.Add(this.btnSelectFile);
            this.groupBox2.Controls.Add(this.txtFilePath);
            this.groupBox2.Controls.Add(this.btnUpdatePDF);
            this.groupBox2.Controls.Add(this.numUpDown);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblTotalPages);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 182);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove PDF Page";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(491, 22);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(145, 23);
            this.btnSelectFile.TabIndex = 12;
            this.btnSelectFile.Text = "Select PDF File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(20, 24);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(467, 20);
            this.txtFilePath.TabIndex = 12;
            // 
            // btnUpdatePDF
            // 
            this.btnUpdatePDF.Location = new System.Drawing.Point(21, 146);
            this.btnUpdatePDF.Name = "btnUpdatePDF";
            this.btnUpdatePDF.Size = new System.Drawing.Size(628, 23);
            this.btnUpdatePDF.TabIndex = 5;
            this.btnUpdatePDF.Text = "Update PDF";
            this.btnUpdatePDF.UseVisualStyleBackColor = true;
            this.btnUpdatePDF.Click += new System.EventHandler(this.btnUpdatePDF_Click);
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(126, 106);
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(120, 20);
            this.numUpDown.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Remove Page No.:";
            // 
            // lblTotalPages
            // 
            this.lblTotalPages.AutoSize = true;
            this.lblTotalPages.Location = new System.Drawing.Point(124, 83);
            this.lblTotalPages.Name = "lblTotalPages";
            this.lblTotalPages.Size = new System.Drawing.Size(64, 13);
            this.lblTotalPages.TabIndex = 1;
            this.lblTotalPages.Text = "Total Pages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total No. of Pages:";
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(491, 51);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(145, 23);
            this.btnLocation.TabIndex = 13;
            this.btnLocation.Text = "Select Output Location";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // txtOutPut
            // 
            this.txtOutPut.Enabled = false;
            this.txtOutPut.Location = new System.Drawing.Point(20, 54);
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(467, 20);
            this.txtOutPut.TabIndex = 14;
            // 
            // btnSelectLicense
            // 
            this.btnSelectLicense.Location = new System.Drawing.Point(496, 126);
            this.btnSelectLicense.Name = "btnSelectLicense";
            this.btnSelectLicense.Size = new System.Drawing.Size(145, 23);
            this.btnSelectLicense.TabIndex = 13;
            this.btnSelectLicense.Text = "Select IText Trial Key";
            this.btnSelectLicense.UseVisualStyleBackColor = true;
            this.btnSelectLicense.Click += new System.EventHandler(this.btnSelectLicense_Click);
            // 
            // txtTrial
            // 
            this.txtTrial.Enabled = false;
            this.txtTrial.Location = new System.Drawing.Point(23, 128);
            this.txtTrial.Name = "txtTrial";
            this.txtTrial.Size = new System.Drawing.Size(467, 20);
            this.txtTrial.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApplicationNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectPDF;
        private System.Windows.Forms.TextBox txtPDFPath;
        private System.Windows.Forms.Button btnSelectTemp;
        private System.Windows.Forms.TextBox txtTempPath;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdatePDF;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.Button btnSelectLicense;
        private System.Windows.Forms.TextBox txtTrial;
    }
}

