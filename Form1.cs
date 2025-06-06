﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SPApplication
{
    public partial class MainForm : Form
    {
        private string result = "";

        public MainForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // Basic form setup
            this.ClientSize = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SP Cipher Application (Uppercase Only)";
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Icon = SystemIcons.Information;

            // Configure numeric updown
            shiftNumericUpDown.Minimum = -25;
            shiftNumericUpDown.Maximum = 25;
            shiftNumericUpDown.Value = 0;
            shiftNumericUpDown.ReadOnly = true;

            // Initialize character count
            UpdateCharacterCount();
        }

        private void UpdateCharacterCount()
        {
            int count = inputTextBox.Text.Length;
            characterCountLabel.Text = $"{count}/40 characters";
            characterCountLabel.ForeColor = count > 40 ? Color.Red : Color.Gray;
        }

        #region Event Handlers
        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if we've reached the maximum length (and it's not a control key)
            if (inputTextBox.Text.Length >= 40 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            // Uppercase validation
            if (!char.IsControl(e.KeyChar) && !char.IsUpper(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCharacterCount();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(inputTextBox.Text))
            {
                MessageBox.Show("Please enter text to process", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inputTextBox.Focus();
                return false;
            }

            if (inputTextBox.Text.Length > 40)
            {
                MessageBox.Show("Maximum 40 characters allowed", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputTextBox.Focus();
                inputTextBox.SelectAll();
                return false;
            }

            if (inputTextBox.Text.Any(char.IsLower))
            {
                MessageBox.Show("Only uppercase letters (A-Z) are allowed", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputTextBox.Focus();
                inputTextBox.SelectAll();
                return false;
            }

            return true;
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            result = CaesarCipher(inputTextBox.Text, (int)shiftNumericUpDown.Value);
            resultTextBox.Text = result;
            MessageBox.Show($"Text encoded with shift {shiftNumericUpDown.Value}", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            result = new string(inputTextBox.Text.OrderBy(c => c).ToArray());
            resultTextBox.Text = result;
            MessageBox.Show("Text sorted alphabetically", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("No result to print", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Console.WriteLine(result);
                MessageBox.Show("Result sent to debug console", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing result: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyResultButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(resultTextBox.Text))
            {
                MessageBox.Show("No result to copy", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Clipboard.SetText(resultTextBox.Text);
                MessageBox.Show("Result copied to clipboard!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error copying to clipboard: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IncreaseShiftButton_Click(object sender, EventArgs e)
        {
            if (shiftNumericUpDown.Value < shiftNumericUpDown.Maximum)
                shiftNumericUpDown.Value++;
        }

        private void DecreaseShiftButton_Click(object sender, EventArgs e)
        {
            if (shiftNumericUpDown.Value > shiftNumericUpDown.Minimum)
                shiftNumericUpDown.Value--;
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("No result to output", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save Result As";
            saveFileDialog.FileName = "SPCipherResult.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, result);
                    MessageBox.Show($"Result saved to {saveFileDialog.FileName}", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Helper Methods
        private string CaesarCipher(string input, int shift)
        {
            return new string(input.Select(c =>
            {
                if (!char.IsLetter(c)) return c;
                char offset = 'A';
                return (char)(((c + shift - offset + 26) % 26) + offset);
            }).ToArray());
        }
        #endregion
    }
}