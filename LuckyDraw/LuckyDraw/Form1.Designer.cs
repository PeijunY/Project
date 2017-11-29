namespace LuckyDraw
{
    partial class FrmDraw
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.tbxShowPath = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.dgvColleagueInfo = new System.Windows.Forms.DataGridView();
            this.CNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEnglishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboxNum = new System.Windows.Forms.ComboBox();
            this.lblRand01 = new System.Windows.Forms.Label();
            this.lblRand02 = new System.Windows.Forms.Label();
            this.lblRand03 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddName = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.AwardList = new System.Windows.Forms.ListBox();
            this.AbsenceList = new System.Windows.Forms.ListBox();
            this.btnRemoveto = new System.Windows.Forms.Button();
            this.btnSaveName = new System.Windows.Forms.Button();
            this.btnNameload = new System.Windows.Forms.Button();
            this.btnAbsenNameLoad = new System.Windows.Forms.Button();
            this.btnAbsenceNameSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColleagueInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Magenta;
            this.btnStart.Location = new System.Drawing.Point(202, 197);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 25);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAddPath
            // 
            this.btnAddPath.Location = new System.Drawing.Point(27, 12);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(91, 30);
            this.btnAddPath.TabIndex = 1;
            this.btnAddPath.Text = "添加名单";
            this.btnAddPath.UseVisualStyleBackColor = true;
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // tbxShowPath
            // 
            this.tbxShowPath.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbxShowPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxShowPath.ForeColor = System.Drawing.Color.Maroon;
            this.tbxShowPath.Location = new System.Drawing.Point(202, 12);
            this.tbxShowPath.Multiline = true;
            this.tbxShowPath.Name = "tbxShowPath";
            this.tbxShowPath.Size = new System.Drawing.Size(335, 30);
            this.tbxShowPath.TabIndex = 2;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(616, 16);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(103, 25);
            this.btnInput.TabIndex = 3;
            this.btnInput.Text = "导入";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // dgvColleagueInfo
            // 
            this.dgvColleagueInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColleagueInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNum,
            this.CApartment,
            this.CName,
            this.CEnglishName});
            this.dgvColleagueInfo.Location = new System.Drawing.Point(33, 64);
            this.dgvColleagueInfo.Name = "dgvColleagueInfo";
            this.dgvColleagueInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColleagueInfo.Size = new System.Drawing.Size(589, 112);
            this.dgvColleagueInfo.TabIndex = 4;
            // 
            // CNum
            // 
            this.CNum.DataPropertyName = "CNum";
            this.CNum.HeaderText = "序号";
            this.CNum.Name = "CNum";
            // 
            // CApartment
            // 
            this.CApartment.DataPropertyName = "CApartment";
            this.CApartment.HeaderText = "部门";
            this.CApartment.Name = "CApartment";
            // 
            // CName
            // 
            this.CName.DataPropertyName = "CName";
            this.CName.HeaderText = "姓名";
            this.CName.Name = "CName";
            // 
            // CEnglishName
            // 
            this.CEnglishName.DataPropertyName = "CEnglishName";
            this.CEnglishName.HeaderText = "英文名";
            this.CEnglishName.Name = "CEnglishName";
            // 
            // comboxNum
            // 
            this.comboxNum.FormattingEnabled = true;
            this.comboxNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboxNum.Location = new System.Drawing.Point(33, 197);
            this.comboxNum.Name = "comboxNum";
            this.comboxNum.Size = new System.Drawing.Size(104, 21);
            this.comboxNum.TabIndex = 5;
            this.comboxNum.Text = "1";
            // 
            // lblRand01
            // 
            this.lblRand01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRand01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRand01.ForeColor = System.Drawing.Color.Blue;
            this.lblRand01.Location = new System.Drawing.Point(32, 266);
            this.lblRand01.Name = "lblRand01";
            this.lblRand01.Size = new System.Drawing.Size(80, 35);
            this.lblRand01.TabIndex = 7;
            this.lblRand01.Text = "-";
            this.lblRand01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRand02
            // 
            this.lblRand02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRand02.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRand02.ForeColor = System.Drawing.Color.Blue;
            this.lblRand02.Location = new System.Drawing.Point(132, 266);
            this.lblRand02.Name = "lblRand02";
            this.lblRand02.Size = new System.Drawing.Size(81, 35);
            this.lblRand02.TabIndex = 8;
            this.lblRand02.Text = "-";
            this.lblRand02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRand03
            // 
            this.lblRand03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRand03.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRand03.ForeColor = System.Drawing.Color.Blue;
            this.lblRand03.Location = new System.Drawing.Point(233, 266);
            this.lblRand03.Name = "lblRand03";
            this.lblRand03.Size = new System.Drawing.Size(87, 35);
            this.lblRand03.TabIndex = 9;
            this.lblRand03.Text = "-";
            this.lblRand03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(537, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "中奖名单";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(713, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "缺席名单";
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(387, 273);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(89, 25);
            this.btnAddName.TabIndex = 14;
            this.btnAddName.Text = "添加";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Magenta;
            this.btnStop.Location = new System.Drawing.Point(336, 197);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 25);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // AwardList
            // 
            this.AwardList.FormattingEnabled = true;
            this.AwardList.Location = new System.Drawing.Point(518, 248);
            this.AwardList.Name = "AwardList";
            this.AwardList.Size = new System.Drawing.Size(111, 121);
            this.AwardList.TabIndex = 16;
            // 
            // AbsenceList
            // 
            this.AbsenceList.FormattingEnabled = true;
            this.AbsenceList.Location = new System.Drawing.Point(692, 249);
            this.AbsenceList.Name = "AbsenceList";
            this.AbsenceList.Size = new System.Drawing.Size(111, 121);
            this.AbsenceList.TabIndex = 17;
            // 
            // btnRemoveto
            // 
            this.btnRemoveto.Location = new System.Drawing.Point(635, 272);
            this.btnRemoveto.Name = "btnRemoveto";
            this.btnRemoveto.Size = new System.Drawing.Size(51, 26);
            this.btnRemoveto.TabIndex = 18;
            this.btnRemoveto.Text = "移到";
            this.btnRemoveto.UseVisualStyleBackColor = true;
            this.btnRemoveto.Click += new System.EventHandler(this.btnRemoveto_Click);
            // 
            // btnSaveName
            // 
            this.btnSaveName.Location = new System.Drawing.Point(518, 222);
            this.btnSaveName.Name = "btnSaveName";
            this.btnSaveName.Size = new System.Drawing.Size(46, 20);
            this.btnSaveName.TabIndex = 19;
            this.btnSaveName.Text = "保存";
            this.btnSaveName.UseVisualStyleBackColor = true;
            this.btnSaveName.Click += new System.EventHandler(this.btnSaveName_Click);
            // 
            // btnNameload
            // 
            this.btnNameload.Location = new System.Drawing.Point(583, 222);
            this.btnNameload.Name = "btnNameload";
            this.btnNameload.Size = new System.Drawing.Size(46, 20);
            this.btnNameload.TabIndex = 21;
            this.btnNameload.Text = "加载";
            this.btnNameload.UseVisualStyleBackColor = true;
            this.btnNameload.Click += new System.EventHandler(this.btnNameload_Click);
            // 
            // btnAbsenNameLoad
            // 
            this.btnAbsenNameLoad.Location = new System.Drawing.Point(757, 223);
            this.btnAbsenNameLoad.Name = "btnAbsenNameLoad";
            this.btnAbsenNameLoad.Size = new System.Drawing.Size(46, 20);
            this.btnAbsenNameLoad.TabIndex = 23;
            this.btnAbsenNameLoad.Text = "加载";
            this.btnAbsenNameLoad.UseVisualStyleBackColor = true;
            this.btnAbsenNameLoad.Click += new System.EventHandler(this.btnAbsenNameLoad_Click);
            // 
            // btnAbsenceNameSave
            // 
            this.btnAbsenceNameSave.Location = new System.Drawing.Point(692, 223);
            this.btnAbsenceNameSave.Name = "btnAbsenceNameSave";
            this.btnAbsenceNameSave.Size = new System.Drawing.Size(46, 20);
            this.btnAbsenceNameSave.TabIndex = 22;
            this.btnAbsenceNameSave.Text = "保存";
            this.btnAbsenceNameSave.UseVisualStyleBackColor = true;
            this.btnAbsenceNameSave.Click += new System.EventHandler(this.btnAbsenceNameSave_Click);
            // 
            // FrmDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 382);
            this.Controls.Add(this.btnAbsenNameLoad);
            this.Controls.Add(this.btnAbsenceNameSave);
            this.Controls.Add(this.btnNameload);
            this.Controls.Add(this.btnSaveName);
            this.Controls.Add(this.btnRemoveto);
            this.Controls.Add(this.AbsenceList);
            this.Controls.Add(this.AwardList);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRand03);
            this.Controls.Add(this.lblRand02);
            this.Controls.Add(this.lblRand01);
            this.Controls.Add(this.comboxNum);
            this.Controls.Add(this.dgvColleagueInfo);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.tbxShowPath);
            this.Controls.Add(this.btnAddPath);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmDraw";
            this.Text = "LuckyDraw";
            ((System.ComponentModel.ISupportInitialize)(this.dgvColleagueInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAddPath;
        private System.Windows.Forms.TextBox tbxShowPath;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.DataGridView dgvColleagueInfo;
        private System.Windows.Forms.ComboBox comboxNum;
        private System.Windows.Forms.Label lblRand01;
        private System.Windows.Forms.Label lblRand02;
        private System.Windows.Forms.Label lblRand03;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEnglishName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox AwardList;
        private System.Windows.Forms.ListBox AbsenceList;
        private System.Windows.Forms.Button btnRemoveto;
        private System.Windows.Forms.Button btnSaveName;
        private System.Windows.Forms.Button btnNameload;
        private System.Windows.Forms.Button btnAbsenNameLoad;
        private System.Windows.Forms.Button btnAbsenceNameSave;
    }
}

