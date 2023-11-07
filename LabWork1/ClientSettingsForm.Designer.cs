namespace LabWork1
{
    partial class ClientSettingsForm
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
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageDisplayMatrix = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDisplayMatrix = new System.Windows.Forms.Label();
            this.comboBoxDisplayMatrix = new System.Windows.Forms.ComboBox();
            this.tabPageBorder = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelBorderType = new System.Windows.Forms.Label();
            this.labelBorderHave = new System.Windows.Forms.Label();
            this.comboBoxBorderHave = new System.Windows.Forms.ComboBox();
            this.comboBoxBorderType = new System.Windows.Forms.ComboBox();
            this.buttonCancelSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveSeettings = new System.Windows.Forms.Button();
            this.buttonApplySettings = new System.Windows.Forms.Button();
            this.tabControlSettings.SuspendLayout();
            this.tabPageDisplayMatrix.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageBorder.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageDisplayMatrix);
            this.tabControlSettings.Controls.Add(this.tabPageBorder);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlSettings.Font = new System.Drawing.Font("Open Sans Semibold", 9F);
            this.tabControlSettings.Location = new System.Drawing.Point(0, 0);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(484, 233);
            this.tabControlSettings.TabIndex = 4;
            // 
            // tabPageDisplayMatrix
            // 
            this.tabPageDisplayMatrix.Controls.Add(this.tableLayoutPanel1);
            this.tabPageDisplayMatrix.Location = new System.Drawing.Point(4, 26);
            this.tabPageDisplayMatrix.Name = "tabPageDisplayMatrix";
            this.tabPageDisplayMatrix.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDisplayMatrix.Size = new System.Drawing.Size(476, 203);
            this.tabPageDisplayMatrix.TabIndex = 0;
            this.tabPageDisplayMatrix.Text = "Среда отображения";
            this.tabPageDisplayMatrix.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.labelDisplayMatrix, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxDisplayMatrix, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.71429F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 33);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelDisplayMatrix
            // 
            this.labelDisplayMatrix.AutoSize = true;
            this.labelDisplayMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDisplayMatrix.Location = new System.Drawing.Point(3, 0);
            this.labelDisplayMatrix.Name = "labelDisplayMatrix";
            this.labelDisplayMatrix.Size = new System.Drawing.Size(182, 33);
            this.labelDisplayMatrix.TabIndex = 0;
            this.labelDisplayMatrix.Text = "Среда Отображения";
            this.labelDisplayMatrix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxDisplayMatrix
            // 
            this.comboBoxDisplayMatrix.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBoxDisplayMatrix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisplayMatrix.FormattingEnabled = true;
            this.comboBoxDisplayMatrix.Items.AddRange(new object[] {
            "Консоль",
            "Графическая панель"});
            this.comboBoxDisplayMatrix.Location = new System.Drawing.Point(280, 3);
            this.comboBoxDisplayMatrix.Name = "comboBoxDisplayMatrix";
            this.comboBoxDisplayMatrix.Size = new System.Drawing.Size(187, 25);
            this.comboBoxDisplayMatrix.TabIndex = 1;
            // 
            // tabPageBorder
            // 
            this.tabPageBorder.Controls.Add(this.tableLayoutPanel2);
            this.tabPageBorder.Location = new System.Drawing.Point(4, 26);
            this.tabPageBorder.Name = "tabPageBorder";
            this.tabPageBorder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBorder.Size = new System.Drawing.Size(476, 203);
            this.tabPageBorder.TabIndex = 1;
            this.tabPageBorder.Text = "Граница";
            this.tabPageBorder.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.labelBorderType, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelBorderHave, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxBorderHave, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxBorderType, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.71429F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(470, 66);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelBorderType
            // 
            this.labelBorderType.AutoSize = true;
            this.labelBorderType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBorderType.Location = new System.Drawing.Point(3, 32);
            this.labelBorderType.Name = "labelBorderType";
            this.labelBorderType.Size = new System.Drawing.Size(182, 34);
            this.labelBorderType.TabIndex = 2;
            this.labelBorderType.Text = "Тип границы";
            this.labelBorderType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBorderHave
            // 
            this.labelBorderHave.AutoSize = true;
            this.labelBorderHave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBorderHave.Location = new System.Drawing.Point(3, 0);
            this.labelBorderHave.Name = "labelBorderHave";
            this.labelBorderHave.Size = new System.Drawing.Size(182, 32);
            this.labelBorderHave.TabIndex = 0;
            this.labelBorderHave.Text = "Наличие границы";
            this.labelBorderHave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxBorderHave
            // 
            this.comboBoxBorderHave.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBoxBorderHave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBorderHave.FormattingEnabled = true;
            this.comboBoxBorderHave.Items.AddRange(new object[] {
            "Без границы",
            "С границей"});
            this.comboBoxBorderHave.Location = new System.Drawing.Point(280, 3);
            this.comboBoxBorderHave.Name = "comboBoxBorderHave";
            this.comboBoxBorderHave.Size = new System.Drawing.Size(187, 25);
            this.comboBoxBorderHave.TabIndex = 1;
            this.comboBoxBorderHave.SelectedIndexChanged += new System.EventHandler(this.comboBoxBorderHave_SelectedIndexChanged);
            // 
            // comboBoxBorderType
            // 
            this.comboBoxBorderType.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBoxBorderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBorderType.FormattingEnabled = true;
            this.comboBoxBorderType.Items.AddRange(new object[] {
            "Обычная граница",
            "Двойная граница"});
            this.comboBoxBorderType.Location = new System.Drawing.Point(280, 35);
            this.comboBoxBorderType.Name = "comboBoxBorderType";
            this.comboBoxBorderType.Size = new System.Drawing.Size(187, 25);
            this.comboBoxBorderType.TabIndex = 3;
            // 
            // buttonCancelSettings
            // 
            this.buttonCancelSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancelSettings.Font = new System.Drawing.Font("Open Sans Semibold", 9F);
            this.buttonCancelSettings.Location = new System.Drawing.Point(409, 0);
            this.buttonCancelSettings.Name = "buttonCancelSettings";
            this.buttonCancelSettings.Size = new System.Drawing.Size(75, 29);
            this.buttonCancelSettings.TabIndex = 5;
            this.buttonCancelSettings.Text = "Отмена";
            this.buttonCancelSettings.UseVisualStyleBackColor = true;
            this.buttonCancelSettings.Click += new System.EventHandler(this.buttonCancelSettings_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSaveSeettings);
            this.panel1.Controls.Add(this.buttonApplySettings);
            this.panel1.Controls.Add(this.buttonCancelSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 29);
            this.panel1.TabIndex = 8;
            // 
            // buttonSaveSeettings
            // 
            this.buttonSaveSeettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSaveSeettings.Font = new System.Drawing.Font("Open Sans Semibold", 9F);
            this.buttonSaveSeettings.Location = new System.Drawing.Point(226, 0);
            this.buttonSaveSeettings.Name = "buttonSaveSeettings";
            this.buttonSaveSeettings.Size = new System.Drawing.Size(85, 29);
            this.buttonSaveSeettings.TabIndex = 7;
            this.buttonSaveSeettings.Text = "Сохранить";
            this.buttonSaveSeettings.UseVisualStyleBackColor = true;
            this.buttonSaveSeettings.Click += new System.EventHandler(this.buttonSaveSeettings_Click);
            // 
            // buttonApplySettings
            // 
            this.buttonApplySettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonApplySettings.Font = new System.Drawing.Font("Open Sans Semibold", 9F);
            this.buttonApplySettings.Location = new System.Drawing.Point(311, 0);
            this.buttonApplySettings.Name = "buttonApplySettings";
            this.buttonApplySettings.Size = new System.Drawing.Size(98, 29);
            this.buttonApplySettings.TabIndex = 6;
            this.buttonApplySettings.Text = "Применить";
            this.buttonApplySettings.UseVisualStyleBackColor = true;
            this.buttonApplySettings.Click += new System.EventHandler(this.buttonApplySettings_Click);
            // 
            // ClientSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.panel1);
            this.Name = "ClientSettingsForm";
            this.Text = "ClientSettingsForm";
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageDisplayMatrix.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageBorder.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageDisplayMatrix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPageBorder;
        private System.Windows.Forms.Label labelDisplayMatrix;
        private System.Windows.Forms.ComboBox comboBoxDisplayMatrix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelBorderType;
        private System.Windows.Forms.Label labelBorderHave;
        private System.Windows.Forms.ComboBox comboBoxBorderHave;
        private System.Windows.Forms.ComboBox comboBoxBorderType;
        private System.Windows.Forms.Button buttonCancelSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSaveSeettings;
        private System.Windows.Forms.Button buttonApplySettings;
    }
}