namespace SPApplication
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.copyResultButton = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.characterCountLabel = new System.Windows.Forms.Label();
            this.decreaseShiftButton = new System.Windows.Forms.Button();
            this.increaseShiftButton = new System.Windows.Forms.Button();
            this.shiftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.printButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.outputButton = new System.Windows.Forms.Button();
            this.encodeButton = new System.Windows.Forms.Button();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumericUpDown)).BeginInit();
            this.SuspendLayout();

            // mainPanel
            this.mainPanel.Controls.Add(this.resultPanel);
            this.mainPanel.Controls.Add(this.inputPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 600);
            this.mainPanel.TabIndex = 0;

            // resultPanel
            this.resultPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.resultPanel.Controls.Add(this.resultTextBox);
            this.resultPanel.Controls.Add(this.copyResultButton);
            this.resultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPanel.Location = new System.Drawing.Point(0, 350);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Padding = new System.Windows.Forms.Padding(30);
            this.resultPanel.Size = new System.Drawing.Size(800, 250);
            this.resultPanel.TabIndex = 1;

            // resultTextBox
            this.resultTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(30, 30);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(740, 150);
            this.resultTextBox.TabIndex = 0;

            // copyResultButton
            this.copyResultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyResultButton.BackColor = System.Drawing.Color.SteelBlue;
            this.copyResultButton.FlatAppearance.BorderSize = 0;
            this.copyResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyResultButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyResultButton.ForeColor = System.Drawing.Color.White;
            this.copyResultButton.Location = new System.Drawing.Point(620, 190);
            this.copyResultButton.Name = "copyResultButton";
            this.copyResultButton.Size = new System.Drawing.Size(150, 40);
            this.copyResultButton.TabIndex = 1;
            this.copyResultButton.Text = "Copy Result";
            this.copyResultButton.UseVisualStyleBackColor = false;
            this.copyResultButton.Click += new System.EventHandler(this.CopyResultButton_Click);

            // inputPanel
            this.inputPanel.BackColor = System.Drawing.Color.White;
            this.inputPanel.Controls.Add(this.characterCountLabel);
            this.inputPanel.Controls.Add(this.decreaseShiftButton);
            this.inputPanel.Controls.Add(this.increaseShiftButton);
            this.inputPanel.Controls.Add(this.shiftNumericUpDown);
            this.inputPanel.Controls.Add(this.printButton);
            this.inputPanel.Controls.Add(this.sortButton);
            this.inputPanel.Controls.Add(this.outputButton);
            this.inputPanel.Controls.Add(this.encodeButton);
            this.inputPanel.Controls.Add(this.shiftLabel);
            this.inputPanel.Controls.Add(this.inputTextBox);
            this.inputPanel.Controls.Add(this.inputLabel);
            this.inputPanel.Controls.Add(this.welcomeLabel);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Padding = new System.Windows.Forms.Padding(30);
            this.inputPanel.Size = new System.Drawing.Size(800, 350);
            this.inputPanel.TabIndex = 0;

            // characterCountLabel
            this.characterCountLabel.AutoSize = true;
            this.characterCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterCountLabel.ForeColor = System.Drawing.Color.Gray;
            this.characterCountLabel.Location = new System.Drawing.Point(30, 170);
            this.characterCountLabel.Name = "characterCountLabel";
            this.characterCountLabel.Size = new System.Drawing.Size(83, 15);
            this.characterCountLabel.TabIndex = 12;
            this.characterCountLabel.Text = "0/40 characters";

            // decreaseShiftButton
            this.decreaseShiftButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.decreaseShiftButton.FlatAppearance.BorderSize = 0;
            this.decreaseShiftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decreaseShiftButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decreaseShiftButton.Location = new System.Drawing.Point(230, 220);
            this.decreaseShiftButton.Name = "decreaseShiftButton";
            this.decreaseShiftButton.Size = new System.Drawing.Size(50, 35);
            this.decreaseShiftButton.TabIndex = 11;
            this.decreaseShiftButton.Text = "-";
            this.decreaseShiftButton.UseVisualStyleBackColor = false;
            this.decreaseShiftButton.Click += new System.EventHandler(this.DecreaseShiftButton_Click);

            // increaseShiftButton
            this.increaseShiftButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.increaseShiftButton.FlatAppearance.BorderSize = 0;
            this.increaseShiftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseShiftButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increaseShiftButton.Location = new System.Drawing.Point(180, 220);
            this.increaseShiftButton.Name = "increaseShiftButton";
            this.increaseShiftButton.Size = new System.Drawing.Size(50, 35);
            this.increaseShiftButton.TabIndex = 10;
            this.increaseShiftButton.Text = "+";
            this.increaseShiftButton.UseVisualStyleBackColor = false;
            this.increaseShiftButton.Click += new System.EventHandler(this.IncreaseShiftButton_Click);

            // shiftNumericUpDown
            this.shiftNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftNumericUpDown.Location = new System.Drawing.Point(30, 220);
            this.shiftNumericUpDown.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147483648});
            this.shiftNumericUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.shiftNumericUpDown.Name = "shiftNumericUpDown";
            this.shiftNumericUpDown.ReadOnly = true;
            this.shiftNumericUpDown.Size = new System.Drawing.Size(150, 29);
            this.shiftNumericUpDown.TabIndex = 9;

            // printButton
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.BackColor = System.Drawing.Color.SteelBlue;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(620, 280);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(150, 50);
            this.printButton.TabIndex = 8;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);

            // sortButton
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortButton.BackColor = System.Drawing.Color.SteelBlue;
            this.sortButton.FlatAppearance.BorderSize = 0;
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortButton.ForeColor = System.Drawing.Color.White;
            this.sortButton.Location = new System.Drawing.Point(460, 280);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(150, 50);
            this.sortButton.TabIndex = 7;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.SortButton_Click);

            // outputButton
            this.outputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputButton.BackColor = System.Drawing.Color.SteelBlue;
            this.outputButton.FlatAppearance.BorderSize = 0;
            this.outputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputButton.ForeColor = System.Drawing.Color.White;
            this.outputButton.Location = new System.Drawing.Point(300, 280);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(150, 50);
            this.outputButton.TabIndex = 6;
            this.outputButton.Text = "Output";
            this.outputButton.UseVisualStyleBackColor = false;
            this.outputButton.Click += new System.EventHandler(this.OutputButton_Click);

            // encodeButton
            this.encodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.encodeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.encodeButton.FlatAppearance.BorderSize = 0;
            this.encodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encodeButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodeButton.ForeColor = System.Drawing.Color.White;
            this.encodeButton.Location = new System.Drawing.Point(140, 280);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(150, 50);
            this.encodeButton.TabIndex = 5;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = false;
            this.encodeButton.Click += new System.EventHandler(this.EncodeButton_Click);

            // shiftLabel
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftLabel.Location = new System.Drawing.Point(30, 190);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(150, 21);
            this.shiftLabel.TabIndex = 4;
            this.shiftLabel.Text = "Shift Value (-25 to 25):";

            // inputTextBox
            this.inputTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(30, 70);
            this.inputTextBox.MaxLength = 40;
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(740, 100);
            this.inputTextBox.TabIndex = 3;
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            this.inputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);

            // inputLabel
            this.inputLabel.AutoSize = true;
            this.inputLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(30, 40);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(145, 21);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Input Text (A-Z only):";

            // welcomeLabel
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.welcomeLabel.Location = new System.Drawing.Point(30, 30);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(240, 32);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "SP Cipher Application";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 639);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SP Cipher Application";
            this.mainPanel.ResumeLayout(false);
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button copyResultButton;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Label characterCountLabel;
        private System.Windows.Forms.Button decreaseShiftButton;
        private System.Windows.Forms.Button increaseShiftButton;
        private System.Windows.Forms.NumericUpDown shiftNumericUpDown;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label welcomeLabel;
    }
}