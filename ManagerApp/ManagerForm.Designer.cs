namespace ManagerApp
{
    partial class ManagerForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStatisticsOutTemplate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnUpdateStatistics = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewRecomendations = new System.Windows.Forms.ListView();
            this.columnMovedFilial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNewAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnLoadRecomendations = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(70, 18);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(523, 353);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(515, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Статистика";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 321);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbStatisticsOutTemplate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 30);
            this.panel1.TabIndex = 0;
            // 
            // cbStatisticsOutTemplate
            // 
            this.cbStatisticsOutTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatisticsOutTemplate.FormattingEnabled = true;
            this.cbStatisticsOutTemplate.Location = new System.Drawing.Point(98, 4);
            this.cbStatisticsOutTemplate.Name = "cbStatisticsOutTemplate";
            this.cbStatisticsOutTemplate.Size = new System.Drawing.Size(508, 21);
            this.cbStatisticsOutTemplate.TabIndex = 1;
            this.cbStatisticsOutTemplate.SelectedIndexChanged += new System.EventHandler(this.cbStatisticsOutTemplate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шаблон вывода:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 39);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnUpdateStatistics);
            this.splitContainer1.Size = new System.Drawing.Size(503, 279);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnUpdateStatistics
            // 
            this.btnUpdateStatistics.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdateStatistics.Location = new System.Drawing.Point(362, 0);
            this.btnUpdateStatistics.Name = "btnUpdateStatistics";
            this.btnUpdateStatistics.Size = new System.Drawing.Size(141, 25);
            this.btnUpdateStatistics.TabIndex = 0;
            this.btnUpdateStatistics.Text = "Обновить статистику";
            this.btnUpdateStatistics.UseVisualStyleBackColor = true;
            this.btnUpdateStatistics.Click += new System.EventHandler(this.btnUpdateStatistics_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Рекомендации по филиалам";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewRecomendations
            // 
            this.listViewRecomendations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMovedFilial,
            this.columnNewAddress});
            this.listViewRecomendations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRecomendations.Location = new System.Drawing.Point(0, 0);
            this.listViewRecomendations.Name = "listViewRecomendations";
            this.listViewRecomendations.Size = new System.Drawing.Size(509, 291);
            this.listViewRecomendations.TabIndex = 0;
            this.listViewRecomendations.UseCompatibleStateImageBehavior = false;
            this.listViewRecomendations.View = System.Windows.Forms.View.Details;
            // 
            // columnMovedFilial
            // 
            this.columnMovedFilial.Text = "Перемещаемый филиал";
            // 
            // columnNewAddress
            // 
            this.columnNewAddress.Text = "Куда переместить";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listViewRecomendations);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnLoadRecomendations);
            this.splitContainer2.Size = new System.Drawing.Size(509, 321);
            this.splitContainer2.SplitterDistance = 291;
            this.splitContainer2.TabIndex = 1;
            // 
            // btnLoadRecomendations
            // 
            this.btnLoadRecomendations.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoadRecomendations.Location = new System.Drawing.Point(347, 0);
            this.btnLoadRecomendations.Name = "btnLoadRecomendations";
            this.btnLoadRecomendations.Size = new System.Drawing.Size(162, 26);
            this.btnLoadRecomendations.TabIndex = 0;
            this.btnLoadRecomendations.Text = "Загрузить рекомендации";
            this.btnLoadRecomendations.UseVisualStyleBackColor = true;
            this.btnLoadRecomendations.Click += new System.EventHandler(this.btnLoadRecomendations_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 353);
            this.Controls.Add(this.tabControl);
            this.Name = "ManagerForm";
            this.Text = "Рабочее место менеджера";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbStatisticsOutTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnUpdateStatistics;
        private System.Windows.Forms.ListView listViewRecomendations;
        private System.Windows.Forms.ColumnHeader columnMovedFilial;
        private System.Windows.Forms.ColumnHeader columnNewAddress;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnLoadRecomendations;
    }
}

