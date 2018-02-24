namespace Arac_takip
{
    partial class ConfigurationDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationDialogForm));
            this.m_groupBoxCom = new System.Windows.Forms.GroupBox();
            this.m_comboBoxBaudRateList = new System.Windows.Forms.ComboBox();
            this.m_comboBoxCOMList = new System.Windows.Forms.ComboBox();
            this.m_labelBaudRate = new System.Windows.Forms.Label();
            this.m_labelCom = new System.Windows.Forms.Label();
            this.m_buttonCancel = new System.Windows.Forms.Button();
            this.m_buttonRefresh = new System.Windows.Forms.Button();
            this.m_buttonSave = new System.Windows.Forms.Button();
            this.m_groupBoxCom.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_groupBoxCom
            // 
            this.m_groupBoxCom.Controls.Add(this.m_comboBoxBaudRateList);
            this.m_groupBoxCom.Controls.Add(this.m_comboBoxCOMList);
            this.m_groupBoxCom.Controls.Add(this.m_labelBaudRate);
            this.m_groupBoxCom.Controls.Add(this.m_labelCom);
            this.m_groupBoxCom.Location = new System.Drawing.Point(28, 21);
            this.m_groupBoxCom.Name = "m_groupBoxCom";
            this.m_groupBoxCom.Size = new System.Drawing.Size(258, 96);
            this.m_groupBoxCom.TabIndex = 12;
            this.m_groupBoxCom.TabStop = false;
            this.m_groupBoxCom.Text = "COM Settings";
            // 
            // m_comboBoxBaudRateList
            // 
            this.m_comboBoxBaudRateList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBoxBaudRateList.FormattingEnabled = true;
            this.m_comboBoxBaudRateList.Location = new System.Drawing.Point(114, 59);
            this.m_comboBoxBaudRateList.Name = "m_comboBoxBaudRateList";
            this.m_comboBoxBaudRateList.Size = new System.Drawing.Size(121, 21);
            this.m_comboBoxBaudRateList.TabIndex = 1;
            // 
            // m_comboBoxCOMList
            // 
            this.m_comboBoxCOMList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBoxCOMList.FormattingEnabled = true;
            this.m_comboBoxCOMList.Location = new System.Drawing.Point(114, 27);
            this.m_comboBoxCOMList.Name = "m_comboBoxCOMList";
            this.m_comboBoxCOMList.Size = new System.Drawing.Size(121, 21);
            this.m_comboBoxCOMList.TabIndex = 1;
            this.m_comboBoxCOMList.SelectedIndexChanged += new System.EventHandler(this.m_comboBoxCOMList_SelectedIndexChanged);
            // 
            // m_labelBaudRate
            // 
            this.m_labelBaudRate.AutoSize = true;
            this.m_labelBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.m_labelBaudRate.Location = new System.Drawing.Point(24, 62);
            this.m_labelBaudRate.Name = "m_labelBaudRate";
            this.m_labelBaudRate.Size = new System.Drawing.Size(79, 13);
            this.m_labelBaudRate.TabIndex = 0;
            this.m_labelBaudRate.Text = "Baud Rate : ";
            // 
            // m_labelCom
            // 
            this.m_labelCom.AutoSize = true;
            this.m_labelCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.m_labelCom.Location = new System.Drawing.Point(24, 30);
            this.m_labelCom.Name = "m_labelCom";
            this.m_labelCom.Size = new System.Drawing.Size(46, 13);
            this.m_labelCom.TabIndex = 0;
            this.m_labelCom.Text = "COM : ";
            // 
            // m_buttonCancel
            // 
            this.m_buttonCancel.Location = new System.Drawing.Point(201, 135);
            this.m_buttonCancel.Name = "m_buttonCancel";
            this.m_buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.m_buttonCancel.TabIndex = 11;
            this.m_buttonCancel.Text = "Cancel";
            this.m_buttonCancel.UseVisualStyleBackColor = true;
            this.m_buttonCancel.Click += new System.EventHandler(this.m_buttonSave_Click);
            // 
            // m_buttonRefresh
            // 
            this.m_buttonRefresh.Location = new System.Drawing.Point(39, 135);
            this.m_buttonRefresh.Name = "m_buttonRefresh";
            this.m_buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.m_buttonRefresh.TabIndex = 9;
            this.m_buttonRefresh.Text = "Refresh";
            this.m_buttonRefresh.UseVisualStyleBackColor = true;
            this.m_buttonRefresh.Click += new System.EventHandler(this.m_buttonRefresh_Click);
            // 
            // m_buttonSave
            // 
            this.m_buttonSave.Location = new System.Drawing.Point(120, 135);
            this.m_buttonSave.Name = "m_buttonSave";
            this.m_buttonSave.Size = new System.Drawing.Size(75, 23);
            this.m_buttonSave.TabIndex = 10;
            this.m_buttonSave.Text = "Save";
            this.m_buttonSave.UseVisualStyleBackColor = true;
            this.m_buttonSave.Click += new System.EventHandler(this.m_buttonSave_Click);
            // 
            // ConfigurationDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(318, 181);
            this.Controls.Add(this.m_groupBoxCom);
            this.Controls.Add(this.m_buttonCancel);
            this.Controls.Add(this.m_buttonRefresh);
            this.Controls.Add(this.m_buttonSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigurationDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigurationDialogForm";
            this.Load += new System.EventHandler(this.ConfigurationDialogForm_Load);
            this.m_groupBoxCom.ResumeLayout(false);
            this.m_groupBoxCom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox m_groupBoxCom;
        public System.Windows.Forms.ComboBox m_comboBoxBaudRateList;
        public System.Windows.Forms.ComboBox m_comboBoxCOMList;
        private System.Windows.Forms.Label m_labelBaudRate;
        private System.Windows.Forms.Label m_labelCom;
        private System.Windows.Forms.Button m_buttonCancel;
        private System.Windows.Forms.Button m_buttonRefresh;
        public System.Windows.Forms.Button m_buttonSave;
    }
}