namespace NumberSystemsExerciser
{
    partial class frmMain
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
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbdSecondsCountdown = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbRandSystem = new System.Windows.Forms.ComboBox();
            this.tbGeneratedNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbInputSystem = new System.Windows.Forms.ComboBox();
            this.tbEnteredNum = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnGenerateNumber = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(686, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.lbdSecondsCountdown, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.23656F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.16129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(686, 374);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lbdSecondsCountdown
            // 
            this.lbdSecondsCountdown.AutoSize = true;
            this.lbdSecondsCountdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbdSecondsCountdown.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbdSecondsCountdown.Location = new System.Drawing.Point(237, 82);
            this.lbdSecondsCountdown.Margin = new System.Windows.Forms.Padding(3);
            this.lbdSecondsCountdown.Name = "lbdSecondsCountdown";
            this.lbdSecondsCountdown.Size = new System.Drawing.Size(209, 163);
            this.lbdSecondsCountdown.TabIndex = 4;
            this.lbdSecondsCountdown.Text = "30";
            this.lbdSecondsCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cbRandSystem, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbGeneratedNum, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 79);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(214, 169);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // cbRandSystem
            // 
            this.cbRandSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRandSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRandSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRandSystem.FormattingEnabled = true;
            this.cbRandSystem.Items.AddRange(new object[] {
            "Binary",
            "Octal",
            "Decimal",
            "Hex"});
            this.cbRandSystem.Location = new System.Drawing.Point(3, 45);
            this.cbRandSystem.Name = "cbRandSystem";
            this.cbRandSystem.Size = new System.Drawing.Size(208, 37);
            this.cbRandSystem.TabIndex = 0;
            // 
            // tbGeneratedNum
            // 
            this.tbGeneratedNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGeneratedNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGeneratedNum.Location = new System.Drawing.Point(3, 129);
            this.tbGeneratedNum.Name = "tbGeneratedNum";
            this.tbGeneratedNum.ReadOnly = true;
            this.tbGeneratedNum.Size = new System.Drawing.Size(208, 34);
            this.tbGeneratedNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Generated number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbInputSystem, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbEnteredNum, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(449, 79);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(214, 169);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbInputSystem
            // 
            this.cbInputSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbInputSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInputSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbInputSystem.FormattingEnabled = true;
            this.cbInputSystem.Items.AddRange(new object[] {
            "Binary",
            "Octal",
            "Decimal",
            "Hex"});
            this.cbInputSystem.Location = new System.Drawing.Point(3, 45);
            this.cbInputSystem.Name = "cbInputSystem";
            this.cbInputSystem.Size = new System.Drawing.Size(208, 37);
            this.cbInputSystem.TabIndex = 0;
            // 
            // tbEnteredNum
            // 
            this.tbEnteredNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEnteredNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEnteredNum.Location = new System.Drawing.Point(3, 129);
            this.tbEnteredNum.Name = "tbEnteredNum";
            this.tbEnteredNum.Size = new System.Drawing.Size(208, 34);
            this.tbEnteredNum.TabIndex = 2;
            this.tbEnteredNum.TextChanged += new System.EventHandler(this.tbEnteredNum_TextChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnCheck, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnGenerateNumber, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(234, 248);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.85185F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.81482F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(215, 126);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // btnCheck
            // 
            this.btnCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheck.Location = new System.Drawing.Point(3, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(209, 35);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnGenerateNumber
            // 
            this.btnGenerateNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateNumber.Location = new System.Drawing.Point(30, 84);
            this.btnGenerateNumber.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.btnGenerateNumber.Name = "btnGenerateNumber";
            this.btnGenerateNumber.Size = new System.Drawing.Size(155, 39);
            this.btnGenerateNumber.TabIndex = 6;
            this.btnGenerateNumber.Text = "Generate number";
            this.btnGenerateNumber.UseVisualStyleBackColor = true;
            this.btnGenerateNumber.Click += new System.EventHandler(this.btnGenerateNumber_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 399);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number System Simulator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbdSecondsCountdown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbRandSystem;
        private System.Windows.Forms.TextBox tbGeneratedNum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbInputSystem;
        private System.Windows.Forms.TextBox tbEnteredNum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnGenerateNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

