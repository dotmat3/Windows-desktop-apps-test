using System;
using System.Windows.Forms;

namespace TestProject {
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Form1 : Form {

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1() {
            InitializeComponent();
        }

        #endregion

        #region Operator Functions

        private void TimesButton_Click(object sender, EventArgs e) {
            this.InsertTextAtSelection("*");
            this.FocusInputText();
        }

        private void MinusButton_Click(object sender, EventArgs e) {
            this.InsertTextAtSelection("-");
            this.FocusInputText();
        }

        private void PlusButton_Click(object sender, EventArgs e) {
            this.InsertTextAtSelection("+");
            this.FocusInputText();
        }

        private void EqualsButton_Click(object sender, EventArgs e) {
            this.ExecuteCalculation();
            this.FocusInputText();
        }

        private void PercentButton_Click(object sender, EventArgs e) {
            this.InsertTextAtSelection("%");
            this.FocusInputText();
        }

        private void DotButton_Click(object sender, EventArgs e) {
            this.InsertTextAtSelection(".");
            this.FocusInputText();
        }

        #endregion

        #region Clearing Methods

        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event aguments</param>
        private void CEButton_Click(object sender, EventArgs e) {
            this.UserInputText.Clear();
            this.FocusInputText();
        }

        private void DelButton_Click(object sender, EventArgs e) {
            this.DeleteTextAtSelection();
            this.FocusInputText();
        }

        #endregion

        #region Numbers

        private void ZeroButton_Click(object sender, EventArgs e) {
            this.InsertTextAtSelection("0");
            this.FocusInputText();
        }
        private void OneButton_Click(object sender, EventArgs e) {
            this.InsertTextAtSelection("1");
            this.FocusInputText();
        }

        private void TwoButton_Click(object sender, EventArgs e) {
            this.InsertTextAtSelection("2");
            this.FocusInputText();
        }

        private void ThreeButton_Click(object sender, EventArgs e) {
            this.InsertTextAtSelection("3");
            this.FocusInputText();
        }

        private void FourButton_Click(object sender, EventArgs e) {
            this.InsertTextAtSelection("4");
            this.FocusInputText();
        }

        private void FiveButton_Click(object sender, EventArgs e) {
            this.InsertTextAtSelection("5");
            this.FocusInputText();
        }

        private void SixButton_Click(object sender, EventArgs e) {
            this.InsertTextAtSelection("6");
            this.FocusInputText();
        }

        private void SevenButton_Click(object sender, EventArgs e) {
            this.InsertTextAtSelection("7");
            this.FocusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e) {
            this.InsertTextAtSelection("8");
            this.FocusInputText();
        }

        private void NineButton_Click(object sender, EventArgs e) {
            this.InsertTextAtSelection("9");
            this.FocusInputText();
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText() {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Insert text in the user input text at the selection position
        /// </summary>
        /// <param name="value">The string to insert</param>
        private void InsertTextAtSelection(string value) {
            int cursor = this.UserInputText.SelectionStart;
            this.UserInputText.Text = this.UserInputText.Text.Insert(cursor, value);
            this.UserInputText.SelectionStart = cursor + value.Length;
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Delete a character in the user input text at the selection position
        /// </summary>
        /// <param name="value">The string to insert</param>
        private void DeleteTextAtSelection() {
            int cursor = this.UserInputText.SelectionStart;
            
            if (this.UserInputText.TextLength < cursor + 1)
                return;

            this.UserInputText.Text = this.UserInputText.Text.Remove(cursor, 1);
            this.UserInputText.SelectionStart = cursor;
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Execute the final calculation
        /// </summary>
        private void ExecuteCalculation() {

        }
        #endregion

    }
}
