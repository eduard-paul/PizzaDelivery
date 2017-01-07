namespace ManagerApp
{
    partial class StatisticsDates
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewStatistics = new System.Windows.Forms.ListView();
            this.columnOrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDeliveryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPizzaType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDriver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dateTimeEnd);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimeStart);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewStatistics);
            this.splitContainer1.Size = new System.Drawing.Size(421, 240);
            this.splitContainer1.SplitterDistance = 64;
            this.splitContainer1.TabIndex = 0;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEnd.Location = new System.Drawing.Point(110, 35);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(96, 20);
            this.dateTimeEnd.TabIndex = 2;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeStart.Location = new System.Drawing.Point(110, 9);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(96, 20);
            this.dateTimeStart.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конец периода";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начало периода:";
            // 
            // listViewStatistics
            // 
            this.listViewStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOrderDate,
            this.columnDeliveryDate,
            this.columnPizzaType,
            this.columnDriver,
            this.columnFilial,
            this.columnAddress});
            this.listViewStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewStatistics.Location = new System.Drawing.Point(0, 0);
            this.listViewStatistics.Name = "listViewStatistics";
            this.listViewStatistics.Size = new System.Drawing.Size(421, 172);
            this.listViewStatistics.TabIndex = 1;
            this.listViewStatistics.UseCompatibleStateImageBehavior = false;
            this.listViewStatistics.View = System.Windows.Forms.View.Details;
            // 
            // columnOrderDate
            // 
            this.columnOrderDate.Text = "Дата заказа";
            // 
            // columnDeliveryDate
            // 
            this.columnDeliveryDate.Text = "Дата доставки";
            // 
            // columnPizzaType
            // 
            this.columnPizzaType.Text = "Тип пиццы";
            // 
            // columnDriver
            // 
            this.columnDriver.Text = "Водитель";
            // 
            // columnFilial
            // 
            this.columnFilial.Text = "Филиал";
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "Адрес доставки";
            // 
            // StatisticsDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(421, 240);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsDates";
            this.Text = "Form2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.ListView listViewStatistics;
        private System.Windows.Forms.ColumnHeader columnOrderDate;
        private System.Windows.Forms.ColumnHeader columnDeliveryDate;
        private System.Windows.Forms.ColumnHeader columnPizzaType;
        private System.Windows.Forms.ColumnHeader columnDriver;
        private System.Windows.Forms.ColumnHeader columnFilial;
        private System.Windows.Forms.ColumnHeader columnAddress;
    }
}