namespace WindowsFormsApplication1
{
    partial class Edit_Session
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
            this.components = new System.ComponentModel.Container();
            this.lstNotEdited = new System.Windows.Forms.ListBox();
            this.lstbxEdited = new System.Windows.Forms.ListBox();
            this.btnStartTrim = new System.Windows.Forms.Button();
            this.btnTrimEnd = new System.Windows.Forms.Button();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.tmrProgress = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.trckbProgress = new System.Windows.Forms.TrackBar();
            this.txtTrimStart = new System.Windows.Forms.TextBox();
            this.txtTrimEnd = new System.Windows.Forms.TextBox();
            this.btnTrim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trckbProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // lstNotEdited
            // 
            this.lstNotEdited.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstNotEdited.DisplayMember = "SongName";
            this.lstNotEdited.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNotEdited.FormattingEnabled = true;
            this.lstNotEdited.ItemHeight = 15;
            this.lstNotEdited.Location = new System.Drawing.Point(12, 45);
            this.lstNotEdited.Name = "lstNotEdited";
            this.lstNotEdited.Size = new System.Drawing.Size(188, 394);
            this.lstNotEdited.TabIndex = 0;
            // 
            // lstbxEdited
            // 
            this.lstbxEdited.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstbxEdited.DisplayMember = "SongName";
            this.lstbxEdited.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxEdited.FormattingEnabled = true;
            this.lstbxEdited.ItemHeight = 15;
            this.lstbxEdited.Location = new System.Drawing.Point(243, 45);
            this.lstbxEdited.Name = "lstbxEdited";
            this.lstbxEdited.Size = new System.Drawing.Size(188, 394);
            this.lstbxEdited.TabIndex = 1;
            // 
            // btnStartTrim
            // 
            this.btnStartTrim.BackColor = System.Drawing.Color.Silver;
            this.btnStartTrim.FlatAppearance.BorderSize = 2;
            this.btnStartTrim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartTrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTrim.Location = new System.Drawing.Point(713, 369);
            this.btnStartTrim.Name = "btnStartTrim";
            this.btnStartTrim.Size = new System.Drawing.Size(115, 27);
            this.btnStartTrim.TabIndex = 2;
            this.btnStartTrim.Text = "Trim Start Time";
            this.btnStartTrim.UseVisualStyleBackColor = false;
            this.btnStartTrim.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnTrimEnd
            // 
            this.btnTrimEnd.BackColor = System.Drawing.Color.Silver;
            this.btnTrimEnd.FlatAppearance.BorderSize = 2;
            this.btnTrimEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrimEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrimEnd.Location = new System.Drawing.Point(856, 369);
            this.btnTrimEnd.Name = "btnTrimEnd";
            this.btnTrimEnd.Size = new System.Drawing.Size(115, 27);
            this.btnTrimEnd.TabIndex = 3;
            this.btnTrimEnd.Text = "Trim End Time";
            this.btnTrimEnd.UseVisualStyleBackColor = false;
            this.btnTrimEnd.Click += new System.EventHandler(this.btnTrimEnd_Click);
            // 
            // txtTimer
            // 
            this.txtTimer.BackColor = System.Drawing.Color.White;
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.ForeColor = System.Drawing.Color.Red;
            this.txtTimer.Location = new System.Drawing.Point(623, 169);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ReadOnly = true;
            this.txtTimer.Size = new System.Drawing.Size(144, 21);
            this.txtTimer.TabIndex = 4;
            this.txtTimer.Text = "00:00:00";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrProgress
            // 
            this.tmrProgress.Enabled = true;
            this.tmrProgress.Interval = 1000;
            this.tmrProgress.Tick += new System.EventHandler(this.tmrProgress_Tick);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Silver;
            this.btnPause.FlatAppearance.BorderSize = 2;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(470, 264);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Silver;
            this.btnPlay.FlatAppearance.BorderSize = 2;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(563, 264);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(470, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // trckbProgress
            // 
            this.trckbProgress.Location = new System.Drawing.Point(481, 196);
            this.trckbProgress.Name = "trckbProgress";
            this.trckbProgress.Size = new System.Drawing.Size(425, 45);
            this.trckbProgress.TabIndex = 10;
            this.trckbProgress.Scroll += new System.EventHandler(this.trckbProgress_Scroll);
            // 
            // txtTrimStart
            // 
            this.txtTrimStart.BackColor = System.Drawing.Color.White;
            this.txtTrimStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrimStart.Location = new System.Drawing.Point(713, 342);
            this.txtTrimStart.Name = "txtTrimStart";
            this.txtTrimStart.ReadOnly = true;
            this.txtTrimStart.Size = new System.Drawing.Size(115, 21);
            this.txtTrimStart.TabIndex = 11;
            this.txtTrimStart.Text = "00:00:00";
            this.txtTrimStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTrimEnd
            // 
            this.txtTrimEnd.BackColor = System.Drawing.Color.White;
            this.txtTrimEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrimEnd.Location = new System.Drawing.Point(856, 342);
            this.txtTrimEnd.Name = "txtTrimEnd";
            this.txtTrimEnd.ReadOnly = true;
            this.txtTrimEnd.Size = new System.Drawing.Size(115, 21);
            this.txtTrimEnd.TabIndex = 12;
            this.txtTrimEnd.Text = "00:00:00";
            this.txtTrimEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTrim
            // 
            this.btnTrim.BackColor = System.Drawing.Color.Silver;
            this.btnTrim.FlatAppearance.BorderSize = 2;
            this.btnTrim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrim.Location = new System.Drawing.Point(791, 403);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(115, 27);
            this.btnTrim.TabIndex = 13;
            this.btnTrim.Text = "Trim Sound Audio";
            this.btnTrim.UseVisualStyleBackColor = false;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "UnEdited Songs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Edited Songs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(436, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Edit Trim Session of Pro Tools";
            // 
            // Edit_Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.txtTrimEnd);
            this.Controls.Add(this.txtTrimStart);
            this.Controls.Add(this.trckbProgress);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.btnTrimEnd);
            this.Controls.Add(this.btnStartTrim);
            this.Controls.Add(this.lstbxEdited);
            this.Controls.Add(this.lstNotEdited);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Edit_Session";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                                                                          Edit S" +
    "ession";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Edit_Session_FormClosed);
            this.Load += new System.EventHandler(this.Edit_Session_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trckbProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNotEdited;
        private System.Windows.Forms.ListBox lstbxEdited;
        private System.Windows.Forms.Button btnStartTrim;
        private System.Windows.Forms.Button btnTrimEnd;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Timer tmrProgress;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TrackBar trckbProgress;
        private System.Windows.Forms.TextBox txtTrimStart;
        private System.Windows.Forms.TextBox txtTrimEnd;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}