
namespace Przelicznikk
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxUnitType = new System.Windows.Forms.GroupBox();
            this.groupBoxSourceUnit = new System.Windows.Forms.GroupBox();
            this.groupBoxTargetUnit = new System.Windows.Forms.GroupBox();
            this.groupBoxValue = new System.Windows.Forms.GroupBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.comboBoxUnitType = new System.Windows.Forms.ComboBox();
            this.comboBoxSourceUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxTargetUnit = new System.Windows.Forms.ComboBox();
            this.numericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxUnitType.SuspendLayout();
            this.groupBoxSourceUnit.SuspendLayout();
            this.groupBoxTargetUnit.SuspendLayout();
            this.groupBoxValue.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUnitType
            // 
            this.groupBoxUnitType.Controls.Add(this.comboBoxUnitType);
            this.groupBoxUnitType.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxUnitType.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUnitType.Name = "groupBoxUnitType";
            this.groupBoxUnitType.Size = new System.Drawing.Size(792, 67);
            this.groupBoxUnitType.TabIndex = 1;
            this.groupBoxUnitType.TabStop = false;
            this.groupBoxUnitType.Text = "Rodzaj";
            // 
            // groupBoxSourceUnit
            // 
            this.groupBoxSourceUnit.Controls.Add(this.comboBoxSourceUnit);
            this.groupBoxSourceUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSourceUnit.Location = new System.Drawing.Point(0, 67);
            this.groupBoxSourceUnit.Name = "groupBoxSourceUnit";
            this.groupBoxSourceUnit.Size = new System.Drawing.Size(792, 379);
            this.groupBoxSourceUnit.TabIndex = 2;
            this.groupBoxSourceUnit.TabStop = false;
            this.groupBoxSourceUnit.Text = "Jednostka źródłowa";
            this.groupBoxSourceUnit.Enter += new System.EventHandler(this.groupBoxSourceUnit_Enter);
            // 
            // groupBoxTargetUnit
            // 
            this.groupBoxTargetUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTargetUnit.Controls.Add(this.comboBoxTargetUnit);
            this.groupBoxTargetUnit.Location = new System.Drawing.Point(0, 149);
            this.groupBoxTargetUnit.Name = "groupBoxTargetUnit";
            this.groupBoxTargetUnit.Size = new System.Drawing.Size(792, 67);
            this.groupBoxTargetUnit.TabIndex = 3;
            this.groupBoxTargetUnit.TabStop = false;
            this.groupBoxTargetUnit.Text = "Jednostka docelowa";
            this.groupBoxTargetUnit.Enter += new System.EventHandler(this.groupBoxTargetUnit_Enter);
            // 
            // groupBoxValue
            // 
            this.groupBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxValue.Controls.Add(this.buttonConvert);
            this.groupBoxValue.Controls.Add(this.numericUpDownValue);
            this.groupBoxValue.Location = new System.Drawing.Point(0, 222);
            this.groupBoxValue.Name = "groupBoxValue";
            this.groupBoxValue.Size = new System.Drawing.Size(792, 79);
            this.groupBoxValue.TabIndex = 4;
            this.groupBoxValue.TabStop = false;
            this.groupBoxValue.Text = "Wartość";
            this.groupBoxValue.Enter += new System.EventHandler(this.groupBoxValue_Enter);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.labelResult);
            this.groupBoxResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxResult.Location = new System.Drawing.Point(0, 303);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(792, 143);
            this.groupBoxResult.TabIndex = 5;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Wynik";
            // 
            // comboBoxUnitType
            // 
            this.comboBoxUnitType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUnitType.FormattingEnabled = true;
            this.comboBoxUnitType.Location = new System.Drawing.Point(12, 22);
            this.comboBoxUnitType.Name = "comboBoxUnitType";
            this.comboBoxUnitType.Size = new System.Drawing.Size(760, 23);
            this.comboBoxUnitType.TabIndex = 0;
            // 
            // comboBoxSourceUnit
            // 
            this.comboBoxSourceUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSourceUnit.FormattingEnabled = true;
            this.comboBoxSourceUnit.Location = new System.Drawing.Point(12, 22);
            this.comboBoxSourceUnit.Name = "comboBoxSourceUnit";
            this.comboBoxSourceUnit.Size = new System.Drawing.Size(761, 23);
            this.comboBoxSourceUnit.TabIndex = 1;
            // 
            // comboBoxTargetUnit
            // 
            this.comboBoxTargetUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTargetUnit.FormattingEnabled = true;
            this.comboBoxTargetUnit.Location = new System.Drawing.Point(12, 22);
            this.comboBoxTargetUnit.Name = "comboBoxTargetUnit";
            this.comboBoxTargetUnit.Size = new System.Drawing.Size(760, 23);
            this.comboBoxTargetUnit.TabIndex = 1;
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownValue.Location = new System.Drawing.Point(160, 34);
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(228, 23);
            this.numericUpDownValue.TabIndex = 2;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConvert.Location = new System.Drawing.Point(412, 18);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(132, 51);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = "Oblicz";
            this.buttonConvert.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(295, 43);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(34, 54);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = " ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 446);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxValue);
            this.Controls.Add(this.groupBoxTargetUnit);
            this.Controls.Add(this.groupBoxSourceUnit);
            this.Controls.Add(this.groupBoxUnitType);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBoxUnitType.ResumeLayout(false);
            this.groupBoxSourceUnit.ResumeLayout(false);
            this.groupBoxTargetUnit.ResumeLayout(false);
            this.groupBoxValue.ResumeLayout(false);
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUnitType;
        private System.Windows.Forms.GroupBox groupBoxSourceUnit;
        private System.Windows.Forms.GroupBox groupBoxTargetUnit;
        private System.Windows.Forms.GroupBox groupBoxValue;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.ComboBox comboBoxUnitType;
        private System.Windows.Forms.ComboBox comboBoxSourceUnit;
        private System.Windows.Forms.ComboBox comboBoxTargetUnit;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.NumericUpDown numericUpDownValue;
        private System.Windows.Forms.Label labelResult;
    }
}

