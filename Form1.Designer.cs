namespace Services
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvServices = new System.Windows.Forms.DataGridView();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnStartStop = new System.Windows.Forms.Button();
            this.BtnPauseContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvServices
            // 
            this.DgvServices.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvServices.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvServices.Location = new System.Drawing.Point(4, 32);
            this.DgvServices.MultiSelect = false;
            this.DgvServices.Name = "DgvServices";
            this.DgvServices.ReadOnly = true;
            this.DgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvServices.Size = new System.Drawing.Size(794, 417);
            this.DgvServices.TabIndex = 0;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(4, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 1;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnStartStop
            // 
            this.BtnStartStop.Location = new System.Drawing.Point(85, 3);
            this.BtnStartStop.Name = "BtnStartStop";
            this.BtnStartStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStartStop.TabIndex = 2;
            this.BtnStartStop.Text = "Start/Stop";
            this.BtnStartStop.UseVisualStyleBackColor = true;
            this.BtnStartStop.Click += new System.EventHandler(this.BtnStartStop_Click);
            // 
            // BtnPauseContinue
            // 
            this.BtnPauseContinue.Location = new System.Drawing.Point(167, 3);
            this.BtnPauseContinue.Name = "BtnPauseContinue";
            this.BtnPauseContinue.Size = new System.Drawing.Size(96, 23);
            this.BtnPauseContinue.TabIndex = 3;
            this.BtnPauseContinue.Text = "Pause/Continue";
            this.BtnPauseContinue.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPauseContinue);
            this.Controls.Add(this.BtnStartStop);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.DgvServices);
            this.Name = "FrmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvServices;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnStartStop;
        private System.Windows.Forms.Button BtnPauseContinue;
    }
}

