namespace SimplePaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            groupBox1 = new GroupBox();
            btnCircle = new Button();
            btnRectangle = new Button();
            btnLine = new Button();
            groupBox2 = new GroupBox();
            cmbColor = new ComboBox();
            groupBox3 = new GroupBox();
            trbLineWidth = new TrackBar();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            PicCanvas = new PictureBox();
            lblStatus = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicCanvas).BeginInit();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("한컴 바겐세일 B", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.PaleVioletRed;
            lblAppName.Location = new Point(12, 18);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(297, 62);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "SimplePaint";
            lblAppName.Click += lblAppName_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCircle);
            groupBox1.Controls.Add(btnRectangle);
            groupBox1.Controls.Add(btnLine);
            groupBox1.Location = new Point(12, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 139);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "도형 선택";
            // 
            // btnCircle
            // 
            btnCircle.Font = new Font("한컴 소망 B", 7.874999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCircle.Image = Properties.Resources.KakaoTalk_20260430_100205471_032;
            btnCircle.ImageAlign = ContentAlignment.TopCenter;
            btnCircle.Location = new Point(206, 36);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(93, 91);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "원";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            btnRectangle.Font = new Font("한컴 소망 B", 7.874999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnRectangle.Image = Properties.Resources.KakaoTalk_20260430_100205471_031;
            btnRectangle.ImageAlign = ContentAlignment.TopCenter;
            btnRectangle.Location = new Point(107, 36);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(93, 91);
            btnRectangle.TabIndex = 1;
            btnRectangle.Text = "사각형";
            btnRectangle.TextAlign = ContentAlignment.BottomCenter;
            btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            btnLine.Font = new Font("한컴 소망 B", 7.874999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLine.Image = Properties.Resources.KakaoTalk_20260430_100205471_03;
            btnLine.ImageAlign = ContentAlignment.TopCenter;
            btnLine.Location = new Point(8, 36);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(93, 91);
            btnLine.TabIndex = 0;
            btnLine.Text = "직선";
            btnLine.TextAlign = ContentAlignment.BottomCenter;
            btnLine.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbColor);
            groupBox2.Location = new Point(339, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(199, 139);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "색 선택";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black 검정", "Red 빨강", "Blue 파랑", "Green 녹색" });
            cmbColor.Location = new Point(6, 58);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(187, 40);
            cmbColor.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(trbLineWidth);
            groupBox3.Location = new Point(571, 122);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(190, 139);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "선 두께";
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(0, 49);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(190, 90);
            trbLineWidth.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.FromArgb(255, 255, 192);
            btnOpenFile.Font = new Font("한컴 백제 B", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnOpenFile.Location = new Point(790, 180);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(137, 81);
            btnOpenFile.TabIndex = 3;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = false;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.FromArgb(192, 255, 255);
            btnSaveFile.Font = new Font("한컴 백제 B", 10.1249981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSaveFile.Location = new Point(939, 180);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(137, 81);
            btnSaveFile.TabIndex = 4;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += btnSaveFile_Click_1;
            // 
            // PicCanvas
            // 
            PicCanvas.BackColor = SystemColors.ButtonHighlight;
            PicCanvas.Location = new Point(20, 286);
            PicCanvas.Name = "PicCanvas";
            PicCanvas.Size = new Size(1056, 491);
            PicCanvas.TabIndex = 5;
            PicCanvas.TabStop = false;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("한컴 백제 M", 10.8749981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(880, 122);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(196, 42);
            lblStatus.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 789);
            Controls.Add(lblStatus);
            Controls.Add(PicCanvas);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Simple Paint v2.0";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnOpenFile;
        private Button btnCircle;
        private Button btnRectangle;
        private Button btnLine;
        private ComboBox cmbColor;
        private TrackBar trbLineWidth;
        private Button btnSaveFile;
        private PictureBox PicCanvas;
        private Label lblStatus;
    }
}
