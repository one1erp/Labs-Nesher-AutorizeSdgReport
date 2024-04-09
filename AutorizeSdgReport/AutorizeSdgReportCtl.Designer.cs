namespace AutorizeSdgReport
{
    partial class AutorizeSdgReportCtl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.toDateTimePicker2 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.fromDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            this.radChartView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateTimePicker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // radChartView1
            // 
            this.radChartView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            cartesianArea2.ShowGrid = true;
            this.radChartView1.AreaDesign = cartesianArea2;
            this.radChartView1.Controls.Add(this.listBox1);
            this.radChartView1.Location = new System.Drawing.Point(90, 3);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.ShowLegend = true;
            this.radChartView1.ShowTitle = true;
            this.radChartView1.ShowToolTip = true;
            this.radChartView1.ShowTrackBall = true;
            this.radChartView1.Size = new System.Drawing.Size(826, 651);
            this.radChartView1.TabIndex = 0;
            this.radChartView1.Text = "radChartView1";
            this.radChartView1.SelectedPointChanged += new Telerik.WinControls.UI.ChartViewSelectedChangedEventHandler(this.selectionController_SelectedPointChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(145, 165);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 251);
            this.listBox1.TabIndex = 0;
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel1.Controls.Add(this.button1);
            this.radPanel1.Controls.Add(this.radButton1);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.toDateTimePicker2);
            this.radPanel1.Controls.Add(this.fromDateTimePicker);
            this.radPanel1.Location = new System.Drawing.Point(919, 3);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radPanel1.Size = new System.Drawing.Size(200, 222);
            this.radPanel1.TabIndex = 1;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(45, 175);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 4;
            this.radButton1.Text = "סנן";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = true;
            this.radLabel2.Location = new System.Drawing.Point(125, 91);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(55, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "עד תאריך";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = true;
            this.radLabel1.Location = new System.Drawing.Point(135, 25);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(45, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "מתאריך";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // toDateTimePicker2
            // 
            this.toDateTimePicker2.Location = new System.Drawing.Point(16, 115);
            this.toDateTimePicker2.Name = "toDateTimePicker2";
            this.toDateTimePicker2.Size = new System.Drawing.Size(164, 20);
            this.toDateTimePicker2.TabIndex = 1;
            this.toDateTimePicker2.TabStop = false;
            this.toDateTimePicker2.Text = "יום ראשון 04 מאי 2014";
            this.toDateTimePicker2.Value = new System.DateTime(2014, 5, 4, 11, 6, 13, 656);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(16, 49);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(164, 20);
            this.fromDateTimePicker.TabIndex = 0;
            this.fromDateTimePicker.TabStop = false;
            this.fromDateTimePicker.Text = "יום ראשון 04 מאי 2014";
            this.fromDateTimePicker.Value = new System.DateTime(2014, 5, 4, 11, 6, 13, 656);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(45, 18);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(110, 24);
            this.radButton2.TabIndex = 5;
            this.radButton2.Text = "הזמנות לפי סטטוס";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radPanel2
            // 
            this.radPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel2.Controls.Add(this.radButton2);
            this.radPanel2.Location = new System.Drawing.Point(919, 231);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(200, 60);
            this.radPanel2.TabIndex = 2;
            // 
            // radPanel3
            // 
            this.radPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel3.Controls.Add(this.radButton3);
            this.radPanel3.Location = new System.Drawing.Point(919, 297);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(200, 58);
            this.radPanel3.TabIndex = 3;
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(45, 18);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(110, 24);
            this.radButton3.TabIndex = 5;
            this.radButton3.Text = "סטטוסים במעבדה";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // radPanel4
            // 
            this.radPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel4.Controls.Add(this.radButton4);
            this.radPanel4.Location = new System.Drawing.Point(919, 361);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(200, 77);
            this.radPanel4.TabIndex = 6;
            // 
            // radButton4
            // 
            this.radButton4.Location = new System.Drawing.Point(45, 40);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(110, 24);
            this.radButton4.TabIndex = 5;
            this.radButton4.Text = "Area";
            this.radButton4.Click += new System.EventHandler(this.radButton4_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(45, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AutorizeSdgReportCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel4);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radChartView1);
            this.Name = "AutorizeSdgReportCtl";
            this.Size = new System.Drawing.Size(1122, 571);
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            this.radChartView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateTimePicker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDateTimePicker toDateTimePicker2;
        private Telerik.WinControls.UI.RadDateTimePicker fromDateTimePicker;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private Telerik.WinControls.UI.RadButton radButton4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;

    }
}
