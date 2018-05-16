namespace Quiz
{
    partial class QuestionUserControl1
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.TrueChcekBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AnswerTextBox.Location = new System.Drawing.Point(139, 28);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(733, 26);
            this.AnswerTextBox.TabIndex = 0;
            // 
            // TrueChcekBox
            // 
            this.TrueChcekBox.AutoSize = true;
            this.TrueChcekBox.Location = new System.Drawing.Point(13, 35);
            this.TrueChcekBox.Name = "TrueChcekBox";
            this.TrueChcekBox.Size = new System.Drawing.Size(109, 17);
            this.TrueChcekBox.TabIndex = 1;
            this.TrueChcekBox.Text = "Dobra odpowiedź";
            this.TrueChcekBox.UseVisualStyleBackColor = true;
            // 
            // QuestionUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TrueChcekBox);
            this.Controls.Add(this.AnswerTextBox);
            this.Name = "QuestionUserControl1";
            this.Size = new System.Drawing.Size(900, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.CheckBox TrueChcekBox;
    }
}
