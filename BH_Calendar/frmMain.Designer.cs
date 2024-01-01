namespace BH_Calendar
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bhCalendar = new BH_Core.Controls.BhCalrendar.BhCalendar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ctlEventGroup1 = new BH_Calendar.Event.Group.ctlEventGroup();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.bhEventViwer1 = new BhCalrendar.Event.BhEventViwer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bhCalendar
            // 
            this.bhCalendar.AllowEditingEvents = true;
            this.bhCalendar.BackColor = System.Drawing.Color.White;
            this.bhCalendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bhCalendar.CalendarDate = new System.DateTime(2018, 7, 27, 15, 47, 22, 546);
            this.bhCalendar.CalendarView = BH_Core.Controls.BhCalrendar.CalendarViews.Month;
            this.bhCalendar.DateHeaderFont = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.bhCalendar.DayOfWeekFont = new System.Drawing.Font("굴림", 12F);
            this.bhCalendar.DaysFont = new System.Drawing.Font("굴림", 12F);
            this.bhCalendar.DayViewTimeFont = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.bhCalendar.DimDisabledEvents = true;
            this.bhCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bhCalendar.HighlightCurrentDay = true;
            //this.bhCalendar.LoadPresetHolidays = true;
            this.bhCalendar.Location = new System.Drawing.Point(0, 0);
            this.bhCalendar.Name = "bhCalendar";
            this.bhCalendar.ShowArrowControls = true;
            this.bhCalendar.ShowDashedBorderOnDisabledEvents = true;
            this.bhCalendar.ShowDateInHeader = true;
            this.bhCalendar.ShowDisabledEvents = false;
            this.bhCalendar.ShowEventTooltips = true;
            this.bhCalendar.ShowTodayButton = true;
            this.bhCalendar.Size = new System.Drawing.Size(614, 291);
            this.bhCalendar.TabIndex = 0;
            this.bhCalendar.TodayFont = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.bhCalendar.DateSelectChangedEvent += new BH_Core.Controls.BhCalrendar.BhCalendar.DateSelectChangedEventHandler(this.bhCalendar_DateSelectChangedEvent);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitter2);
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bhEventViwer1);
            this.splitContainer1.Size = new System.Drawing.Size(927, 600);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoving += new System.Windows.Forms.SplitterCancelEventHandler(this.splitContainer2_SplitterMoving);
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 288);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(927, 3);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ctlEventGroup1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitter1);
            this.splitContainer2.Panel2.Controls.Add(this.bhCalendar);
            this.splitContainer2.Size = new System.Drawing.Size(927, 291);
            this.splitContainer2.SplitterDistance = 309;
            this.splitContainer2.TabIndex = 1;
            this.splitContainer2.SplitterMoving += new System.Windows.Forms.SplitterCancelEventHandler(this.splitContainer2_SplitterMoving);
            // 
            // ctlEventGroup1
            // 
            this.ctlEventGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlEventGroup1.Location = new System.Drawing.Point(0, 0);
            this.ctlEventGroup1.Name = "ctlEventGroup1";
            this.ctlEventGroup1.Size = new System.Drawing.Size(309, 291);
            this.ctlEventGroup1.TabIndex = 1;
            this.ctlEventGroup1.SelectGroupChangeEvent += new BH_Calendar.Event.Group.ctlEventGroup.SelectGroupChangeEventHandler(this.ctlEventGroup1_SelectGroupChangeEvent);
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 291);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // bhEventViwer1
            // 
            this.bhEventViwer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bhEventViwer1.Location = new System.Drawing.Point(0, 0);
            this.bhEventViwer1.MinimumSize = new System.Drawing.Size(560, 300);
            this.bhEventViwer1.Name = "bhEventViwer1";
            this.bhEventViwer1.SelectDate = new System.DateTime(((long)(0)));
            this.bhEventViwer1.Size = new System.Drawing.Size(927, 305);
            this.bhEventViwer1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(927, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 622);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BH_Core.Controls.BhCalrendar.BhCalendar bhCalendar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private Event.Group.ctlEventGroup ctlEventGroup1;
        private BhCalrendar.Event.BhEventViwer bhEventViwer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

