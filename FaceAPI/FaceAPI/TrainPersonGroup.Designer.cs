namespace FaceAPI
{
    partial class TrainPersonGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainPersonGroup));
            this.button_CreateAPersonGroup = new System.Windows.Forms.Button();
            this.textBox_PersonGroupId = new System.Windows.Forms.TextBox();
            this.textBox_PersonGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_PersonGroupUserData = new System.Windows.Forms.TextBox();
            this.textBox_CreateAPersonGroupResult = new System.Windows.Forms.TextBox();
            this.button_CreateAPerson = new System.Windows.Forms.Button();
            this.textBox_CreateAPersonResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_personUserData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_personName = new System.Windows.Forms.TextBox();
            this.button_AddAPersonFace = new System.Windows.Forms.Button();
            this.pictureBox_ChooseFaceImage = new System.Windows.Forms.PictureBox();
            this.button_ChooseAPersonFace = new System.Windows.Forms.Button();
            this.textBox_AddAPersonFaceResult = new System.Windows.Forms.TextBox();
            this.button_TrainPersonGroup = new System.Windows.Forms.Button();
            this.textBox_TrainPersonGroupResult = new System.Windows.Forms.TextBox();
            this.button_Detect = new System.Windows.Forms.Button();
            this.pictureBox_Detect = new System.Windows.Forms.PictureBox();
            this.textBox_DetectResult = new System.Windows.Forms.TextBox();
            this.button_Identify = new System.Windows.Forms.Button();
            this.textBox_IdentifyResult = new System.Windows.Forms.TextBox();
            this.trackBar_confidenceThreshold = new System.Windows.Forms.TrackBar();
            this.label_confidenceThreshold = new System.Windows.Forms.Label();
            this.button_DetectDetect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChooseFaceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Detect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_confidenceThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // button_CreateAPersonGroup
            // 
            this.button_CreateAPersonGroup.Location = new System.Drawing.Point(12, 12);
            this.button_CreateAPersonGroup.Name = "button_CreateAPersonGroup";
            this.button_CreateAPersonGroup.Size = new System.Drawing.Size(130, 40);
            this.button_CreateAPersonGroup.TabIndex = 0;
            this.button_CreateAPersonGroup.Text = "CreateAPersonGroup";
            this.button_CreateAPersonGroup.UseVisualStyleBackColor = true;
            this.button_CreateAPersonGroup.Click += new System.EventHandler(this.button_CreateAPersonGroup_Click);
            // 
            // textBox_PersonGroupId
            // 
            this.textBox_PersonGroupId.Location = new System.Drawing.Point(171, 23);
            this.textBox_PersonGroupId.Name = "textBox_PersonGroupId";
            this.textBox_PersonGroupId.Size = new System.Drawing.Size(174, 21);
            this.textBox_PersonGroupId.TabIndex = 1;
            this.textBox_PersonGroupId.Text = "lovefamily";
            // 
            // textBox_PersonGroupName
            // 
            this.textBox_PersonGroupName.Location = new System.Drawing.Point(386, 23);
            this.textBox_PersonGroupName.Name = "textBox_PersonGroupName";
            this.textBox_PersonGroupName.Size = new System.Drawing.Size(160, 21);
            this.textBox_PersonGroupName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "UserData";
            // 
            // textBox_PersonGroupUserData
            // 
            this.textBox_PersonGroupUserData.Location = new System.Drawing.Point(612, 23);
            this.textBox_PersonGroupUserData.Name = "textBox_PersonGroupUserData";
            this.textBox_PersonGroupUserData.Size = new System.Drawing.Size(160, 21);
            this.textBox_PersonGroupUserData.TabIndex = 5;
            // 
            // textBox_CreateAPersonGroupResult
            // 
            this.textBox_CreateAPersonGroupResult.Location = new System.Drawing.Point(12, 58);
            this.textBox_CreateAPersonGroupResult.Multiline = true;
            this.textBox_CreateAPersonGroupResult.Name = "textBox_CreateAPersonGroupResult";
            this.textBox_CreateAPersonGroupResult.Size = new System.Drawing.Size(760, 24);
            this.textBox_CreateAPersonGroupResult.TabIndex = 7;
            // 
            // button_CreateAPerson
            // 
            this.button_CreateAPerson.Location = new System.Drawing.Point(12, 98);
            this.button_CreateAPerson.Name = "button_CreateAPerson";
            this.button_CreateAPerson.Size = new System.Drawing.Size(130, 40);
            this.button_CreateAPerson.TabIndex = 8;
            this.button_CreateAPerson.Text = "CreateAPerson";
            this.button_CreateAPerson.UseVisualStyleBackColor = true;
            this.button_CreateAPerson.Click += new System.EventHandler(this.button_CreateAPerson_Click);
            // 
            // textBox_CreateAPersonResult
            // 
            this.textBox_CreateAPersonResult.Location = new System.Drawing.Point(12, 144);
            this.textBox_CreateAPersonResult.Multiline = true;
            this.textBox_CreateAPersonResult.Name = "textBox_CreateAPersonResult";
            this.textBox_CreateAPersonResult.Size = new System.Drawing.Size(333, 24);
            this.textBox_CreateAPersonResult.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "UserData";
            // 
            // textBox_personUserData
            // 
            this.textBox_personUserData.Location = new System.Drawing.Point(612, 109);
            this.textBox_personUserData.Name = "textBox_personUserData";
            this.textBox_personUserData.Size = new System.Drawing.Size(160, 21);
            this.textBox_personUserData.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // textBox_personName
            // 
            this.textBox_personName.Location = new System.Drawing.Point(386, 109);
            this.textBox_personName.Name = "textBox_personName";
            this.textBox_personName.Size = new System.Drawing.Size(160, 21);
            this.textBox_personName.TabIndex = 10;
            // 
            // button_AddAPersonFace
            // 
            this.button_AddAPersonFace.Location = new System.Drawing.Point(12, 186);
            this.button_AddAPersonFace.Name = "button_AddAPersonFace";
            this.button_AddAPersonFace.Size = new System.Drawing.Size(130, 40);
            this.button_AddAPersonFace.TabIndex = 14;
            this.button_AddAPersonFace.Text = "AddAPersonFace";
            this.button_AddAPersonFace.UseVisualStyleBackColor = true;
            this.button_AddAPersonFace.Click += new System.EventHandler(this.button_AddAPersonFace_Click);
            // 
            // pictureBox_ChooseFaceImage
            // 
            this.pictureBox_ChooseFaceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_ChooseFaceImage.Location = new System.Drawing.Point(351, 186);
            this.pictureBox_ChooseFaceImage.Name = "pictureBox_ChooseFaceImage";
            this.pictureBox_ChooseFaceImage.Size = new System.Drawing.Size(203, 302);
            this.pictureBox_ChooseFaceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ChooseFaceImage.TabIndex = 15;
            this.pictureBox_ChooseFaceImage.TabStop = false;
            // 
            // button_ChooseAPersonFace
            // 
            this.button_ChooseAPersonFace.Location = new System.Drawing.Point(386, 174);
            this.button_ChooseAPersonFace.Name = "button_ChooseAPersonFace";
            this.button_ChooseAPersonFace.Size = new System.Drawing.Size(130, 24);
            this.button_ChooseAPersonFace.TabIndex = 16;
            this.button_ChooseAPersonFace.Text = "ChooseAPersonFace";
            this.button_ChooseAPersonFace.UseVisualStyleBackColor = true;
            this.button_ChooseAPersonFace.Click += new System.EventHandler(this.button_ChooseAPersonFace_Click);
            // 
            // textBox_AddAPersonFaceResult
            // 
            this.textBox_AddAPersonFaceResult.Location = new System.Drawing.Point(12, 232);
            this.textBox_AddAPersonFaceResult.Multiline = true;
            this.textBox_AddAPersonFaceResult.Name = "textBox_AddAPersonFaceResult";
            this.textBox_AddAPersonFaceResult.Size = new System.Drawing.Size(333, 24);
            this.textBox_AddAPersonFaceResult.TabIndex = 17;
            // 
            // button_TrainPersonGroup
            // 
            this.button_TrainPersonGroup.Location = new System.Drawing.Point(12, 275);
            this.button_TrainPersonGroup.Name = "button_TrainPersonGroup";
            this.button_TrainPersonGroup.Size = new System.Drawing.Size(130, 40);
            this.button_TrainPersonGroup.TabIndex = 18;
            this.button_TrainPersonGroup.Text = "TrainPersonGroup";
            this.button_TrainPersonGroup.UseVisualStyleBackColor = true;
            this.button_TrainPersonGroup.Click += new System.EventHandler(this.button_TrainPersonGroup_Click);
            // 
            // textBox_TrainPersonGroupResult
            // 
            this.textBox_TrainPersonGroupResult.Location = new System.Drawing.Point(12, 321);
            this.textBox_TrainPersonGroupResult.Multiline = true;
            this.textBox_TrainPersonGroupResult.Name = "textBox_TrainPersonGroupResult";
            this.textBox_TrainPersonGroupResult.Size = new System.Drawing.Size(333, 24);
            this.textBox_TrainPersonGroupResult.TabIndex = 19;
            // 
            // button_Detect
            // 
            this.button_Detect.Location = new System.Drawing.Point(12, 365);
            this.button_Detect.Name = "button_Detect";
            this.button_Detect.Size = new System.Drawing.Size(130, 40);
            this.button_Detect.TabIndex = 20;
            this.button_Detect.Text = "Detect";
            this.button_Detect.UseVisualStyleBackColor = true;
            this.button_Detect.Click += new System.EventHandler(this.button_Detect_Click);
            // 
            // pictureBox_Detect
            // 
            this.pictureBox_Detect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Detect.Location = new System.Drawing.Point(560, 186);
            this.pictureBox_Detect.Name = "pictureBox_Detect";
            this.pictureBox_Detect.Size = new System.Drawing.Size(212, 302);
            this.pictureBox_Detect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Detect.TabIndex = 21;
            this.pictureBox_Detect.TabStop = false;
            // 
            // textBox_DetectResult
            // 
            this.textBox_DetectResult.Location = new System.Drawing.Point(12, 411);
            this.textBox_DetectResult.Multiline = true;
            this.textBox_DetectResult.Name = "textBox_DetectResult";
            this.textBox_DetectResult.Size = new System.Drawing.Size(333, 77);
            this.textBox_DetectResult.TabIndex = 22;
            // 
            // button_Identify
            // 
            this.button_Identify.Location = new System.Drawing.Point(12, 520);
            this.button_Identify.Name = "button_Identify";
            this.button_Identify.Size = new System.Drawing.Size(130, 40);
            this.button_Identify.TabIndex = 23;
            this.button_Identify.Text = "Identify";
            this.button_Identify.UseVisualStyleBackColor = true;
            this.button_Identify.Click += new System.EventHandler(this.button_Identify_Click);
            // 
            // textBox_IdentifyResult
            // 
            this.textBox_IdentifyResult.Location = new System.Drawing.Point(150, 510);
            this.textBox_IdentifyResult.Multiline = true;
            this.textBox_IdentifyResult.Name = "textBox_IdentifyResult";
            this.textBox_IdentifyResult.Size = new System.Drawing.Size(404, 62);
            this.textBox_IdentifyResult.TabIndex = 24;
            // 
            // trackBar_confidenceThreshold
            // 
            this.trackBar_confidenceThreshold.Location = new System.Drawing.Point(562, 520);
            this.trackBar_confidenceThreshold.Maximum = 100;
            this.trackBar_confidenceThreshold.Name = "trackBar_confidenceThreshold";
            this.trackBar_confidenceThreshold.Size = new System.Drawing.Size(212, 45);
            this.trackBar_confidenceThreshold.TabIndex = 25;
            this.trackBar_confidenceThreshold.Value = 50;
            this.trackBar_confidenceThreshold.Scroll += new System.EventHandler(this.trackBar_confidenceThreshold_Scroll);
            // 
            // label_confidenceThreshold
            // 
            this.label_confidenceThreshold.Location = new System.Drawing.Point(562, 552);
            this.label_confidenceThreshold.Name = "label_confidenceThreshold";
            this.label_confidenceThreshold.Size = new System.Drawing.Size(210, 23);
            this.label_confidenceThreshold.TabIndex = 26;
            this.label_confidenceThreshold.Text = "0.5";
            this.label_confidenceThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_DetectDetect
            // 
            this.button_DetectDetect.Location = new System.Drawing.Point(706, 553);
            this.button_DetectDetect.Name = "button_DetectDetect";
            this.button_DetectDetect.Size = new System.Drawing.Size(66, 22);
            this.button_DetectDetect.TabIndex = 27;
            this.button_DetectDetect.Text = "Detect";
            this.button_DetectDetect.UseVisualStyleBackColor = true;
            // 
            // TrainPersonGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 584);
            this.Controls.Add(this.button_DetectDetect);
            this.Controls.Add(this.label_confidenceThreshold);
            this.Controls.Add(this.trackBar_confidenceThreshold);
            this.Controls.Add(this.textBox_IdentifyResult);
            this.Controls.Add(this.button_Identify);
            this.Controls.Add(this.textBox_DetectResult);
            this.Controls.Add(this.pictureBox_Detect);
            this.Controls.Add(this.button_Detect);
            this.Controls.Add(this.textBox_TrainPersonGroupResult);
            this.Controls.Add(this.button_TrainPersonGroup);
            this.Controls.Add(this.textBox_AddAPersonFaceResult);
            this.Controls.Add(this.button_ChooseAPersonFace);
            this.Controls.Add(this.pictureBox_ChooseFaceImage);
            this.Controls.Add(this.button_AddAPersonFace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_personUserData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_personName);
            this.Controls.Add(this.textBox_CreateAPersonResult);
            this.Controls.Add(this.button_CreateAPerson);
            this.Controls.Add(this.textBox_CreateAPersonGroupResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_PersonGroupUserData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_PersonGroupName);
            this.Controls.Add(this.textBox_PersonGroupId);
            this.Controls.Add(this.button_CreateAPersonGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrainPersonGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainPersonGroup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChooseFaceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Detect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_confidenceThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CreateAPersonGroup;
        private System.Windows.Forms.TextBox textBox_PersonGroupId;
        private System.Windows.Forms.TextBox textBox_PersonGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_PersonGroupUserData;
        private System.Windows.Forms.TextBox textBox_CreateAPersonGroupResult;
        private System.Windows.Forms.Button button_CreateAPerson;
        private System.Windows.Forms.TextBox textBox_CreateAPersonResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_personUserData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_personName;
        private System.Windows.Forms.Button button_AddAPersonFace;
        private System.Windows.Forms.PictureBox pictureBox_ChooseFaceImage;
        private System.Windows.Forms.Button button_ChooseAPersonFace;
        private System.Windows.Forms.TextBox textBox_AddAPersonFaceResult;
        private System.Windows.Forms.Button button_TrainPersonGroup;
        private System.Windows.Forms.TextBox textBox_TrainPersonGroupResult;
        private System.Windows.Forms.Button button_Detect;
        private System.Windows.Forms.PictureBox pictureBox_Detect;
        private System.Windows.Forms.TextBox textBox_DetectResult;
        private System.Windows.Forms.Button button_Identify;
        private System.Windows.Forms.TextBox textBox_IdentifyResult;
        private System.Windows.Forms.TrackBar trackBar_confidenceThreshold;
        private System.Windows.Forms.Label label_confidenceThreshold;
        private System.Windows.Forms.Button button_DetectDetect;
    }
}