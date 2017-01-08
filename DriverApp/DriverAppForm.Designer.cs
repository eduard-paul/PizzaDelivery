namespace DriverApp
{
    partial class DriverAppForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.routeToBase = new System.Windows.Forms.Label();
            this.btnDelivered = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.routeToAddress = new System.Windows.Forms.Label();
            this.pizzaType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(128, 13);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(143, 13);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "<свободен | доставка>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Маршрут до базы:";
            // 
            // routeToBase
            // 
            this.routeToBase.AutoSize = true;
            this.routeToBase.Location = new System.Drawing.Point(128, 75);
            this.routeToBase.Name = "routeToBase";
            this.routeToBase.Size = new System.Drawing.Size(107, 13);
            this.routeToBase.TabIndex = 3;
            this.routeToBase.Text = "<маршрут до базы>";
            // 
            // btnDelivered
            // 
            this.btnDelivered.Location = new System.Drawing.Point(12, 137);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Size = new System.Drawing.Size(121, 24);
            this.btnDelivered.TabIndex = 4;
            this.btnDelivered.Text = "Доставлено";
            this.btnDelivered.UseVisualStyleBackColor = true;
            this.btnDelivered.Click += new System.EventHandler(this.btnDelivered_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(471, 137);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Выйти из системы";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Маршрут до адреса:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип пиццы:";
            // 
            // routeToAddress
            // 
            this.routeToAddress.AutoSize = true;
            this.routeToAddress.Location = new System.Drawing.Point(128, 96);
            this.routeToAddress.Name = "routeToAddress";
            this.routeToAddress.Size = new System.Drawing.Size(117, 13);
            this.routeToAddress.TabIndex = 8;
            this.routeToAddress.Text = "<маршрут до адреса>";
            // 
            // pizzaType
            // 
            this.pizzaType.AutoSize = true;
            this.pizzaType.Location = new System.Drawing.Point(128, 53);
            this.pizzaType.Name = "pizzaType";
            this.pizzaType.Size = new System.Drawing.Size(71, 13);
            this.pizzaType.TabIndex = 9;
            this.pizzaType.Text = "<тип пиццы>";
            // 
            // DriverAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 177);
            this.Controls.Add(this.pizzaType);
            this.Controls.Add(this.routeToAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDelivered);
            this.Controls.Add(this.routeToBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DriverAppForm";
            this.Text = "Консоль водителя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label routeToBase;
        private System.Windows.Forms.Button btnDelivered;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label routeToAddress;
        private System.Windows.Forms.Label pizzaType;
    }
}

