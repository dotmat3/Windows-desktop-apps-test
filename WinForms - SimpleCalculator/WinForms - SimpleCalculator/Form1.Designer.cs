namespace TestProject
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.ResultText = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.TimesButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.PercentButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.BackColor = System.Drawing.Color.DarkCyan;
            this.UserInputText.ForeColor = System.Drawing.SystemColors.Control;
            this.UserInputText.Location = new System.Drawing.Point(24, 18);
            this.UserInputText.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(423, 47);
            this.UserInputText.TabIndex = 1;
            // 
            // ResultText
            // 
            this.ResultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultText.ForeColor = System.Drawing.SystemColors.Control;
            this.ResultText.Location = new System.Drawing.Point(24, 74);
            this.ResultText.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(423, 50);
            this.ResultText.TabIndex = 2;
            this.ResultText.Text = "Inserisci un\'espressione e premi invio";
            this.ResultText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.EqualsButton, 3, 4);
            this.ButtonsPanel.Controls.Add(this.DotButton, 2, 4);
            this.ButtonsPanel.Controls.Add(this.ZeroButton, 1, 4);
            this.ButtonsPanel.Controls.Add(this.PlusButton, 3, 3);
            this.ButtonsPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonsPanel.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonsPanel.Controls.Add(this.OneButton, 0, 3);
            this.ButtonsPanel.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonsPanel.Controls.Add(this.SixButton, 2, 2);
            this.ButtonsPanel.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonsPanel.Controls.Add(this.FourButton, 0, 2);
            this.ButtonsPanel.Controls.Add(this.TimesButton, 3, 1);
            this.ButtonsPanel.Controls.Add(this.NineButton, 2, 1);
            this.ButtonsPanel.Controls.Add(this.EightButton, 1, 1);
            this.ButtonsPanel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonsPanel.Controls.Add(this.PercentButton, 3, 0);
            this.ButtonsPanel.Controls.Add(this.DelButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(24, 136);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(423, 405);
            this.ButtonsPanel.TabIndex = 3;
            // 
            // EqualsButton
            // 
            this.EqualsButton.BackColor = System.Drawing.Color.DarkCyan;
            this.EqualsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EqualsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EqualsButton.Location = new System.Drawing.Point(318, 327);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(102, 75);
            this.EqualsButton.TabIndex = 19;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = false;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.BackColor = System.Drawing.Color.DarkCyan;
            this.DotButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DotButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DotButton.Location = new System.Drawing.Point(213, 327);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(99, 75);
            this.DotButton.TabIndex = 18;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = false;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.DarkCyan;
            this.ZeroButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ZeroButton.Location = new System.Drawing.Point(108, 327);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(99, 75);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.DarkCyan;
            this.PlusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PlusButton.Location = new System.Drawing.Point(318, 246);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(102, 75);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.DarkCyan;
            this.ThreeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ThreeButton.Location = new System.Drawing.Point(213, 246);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(99, 75);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.DarkCyan;
            this.TwoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TwoButton.Location = new System.Drawing.Point(108, 246);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(99, 75);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.DarkCyan;
            this.OneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OneButton.Location = new System.Drawing.Point(3, 246);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(99, 75);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.DarkCyan;
            this.MinusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MinusButton.Location = new System.Drawing.Point(318, 165);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(102, 75);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.DarkCyan;
            this.SixButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SixButton.Location = new System.Drawing.Point(213, 165);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(99, 75);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.DarkCyan;
            this.FiveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FiveButton.Location = new System.Drawing.Point(108, 165);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(99, 75);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.DarkCyan;
            this.FourButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FourButton.Location = new System.Drawing.Point(3, 165);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(99, 75);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // TimesButton
            // 
            this.TimesButton.BackColor = System.Drawing.Color.DarkCyan;
            this.TimesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimesButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TimesButton.Location = new System.Drawing.Point(318, 84);
            this.TimesButton.Name = "TimesButton";
            this.TimesButton.Size = new System.Drawing.Size(102, 75);
            this.TimesButton.TabIndex = 7;
            this.TimesButton.Text = "x";
            this.TimesButton.UseVisualStyleBackColor = false;
            this.TimesButton.Click += new System.EventHandler(this.TimesButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.DarkCyan;
            this.NineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineButton.ForeColor = System.Drawing.SystemColors.Control;
            this.NineButton.Location = new System.Drawing.Point(213, 84);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(99, 75);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.DarkCyan;
            this.EightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EightButton.Location = new System.Drawing.Point(108, 84);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(99, 75);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.DarkCyan;
            this.SevenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SevenButton.Location = new System.Drawing.Point(3, 84);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(99, 75);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // PercentButton
            // 
            this.PercentButton.BackColor = System.Drawing.Color.DarkCyan;
            this.PercentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PercentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PercentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PercentButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PercentButton.Location = new System.Drawing.Point(318, 3);
            this.PercentButton.Name = "PercentButton";
            this.PercentButton.Size = new System.Drawing.Size(102, 75);
            this.PercentButton.TabIndex = 3;
            this.PercentButton.Text = "%";
            this.PercentButton.UseVisualStyleBackColor = false;
            this.PercentButton.Click += new System.EventHandler(this.PercentButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.DarkCyan;
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DelButton.Location = new System.Drawing.Point(213, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(99, 75);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.BackColor = System.Drawing.Color.DarkCyan;
            this.CEButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CEButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(99, 75);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = false;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EqualsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(461, 553);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.UserInputText);
            this.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcolatrice";
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label ResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button TimesButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button PercentButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button CEButton;
    }
}

