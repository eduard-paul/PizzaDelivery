namespace ManagerApp
{
    partial class StatisticsFull
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
            this.listViewStatistics = new System.Windows.Forms.ListView();
            this.columnOrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDeliveryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPizzaType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDriver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.listViewStatistics.Size = new System.Drawing.Size(426, 240);
            this.listViewStatistics.TabIndex = 2;
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
            // StatisticsFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(426, 240);
            this.Controls.Add(this.listViewStatistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsFull";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewStatistics;
        private System.Windows.Forms.ColumnHeader columnOrderDate;
        private System.Windows.Forms.ColumnHeader columnDeliveryDate;
        private System.Windows.Forms.ColumnHeader columnPizzaType;
        private System.Windows.Forms.ColumnHeader columnDriver;
        private System.Windows.Forms.ColumnHeader columnFilial;
        private System.Windows.Forms.ColumnHeader columnAddress;
    }
}