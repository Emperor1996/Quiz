namespace Quiz
{
    partial class View
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionUserControl11 = new Quiz.QuestionUserControl1();
            this.questionUserControl12 = new Quiz.QuestionUserControl1();
            this.questionUserControl13 = new Quiz.QuestionUserControl1();
            this.questionUserControl14 = new Quiz.QuestionUserControl1();
            this.questionUserControl15 = new Quiz.QuestionUserControl1();
            this.ClearButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.QuestionContenttextBox = new System.Windows.Forms.TextBox();
            this.NameofFiletextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // questionUserControl11
            // 
            this.questionUserControl11.AnswerContent = "";
            this.questionUserControl11.Location = new System.Drawing.Point(-4, 105);
            this.questionUserControl11.Name = "questionUserControl11";
            this.questionUserControl11.Size = new System.Drawing.Size(885, 80);
            this.questionUserControl11.TabIndex = 0;
            this.questionUserControl11.TrueCheckBox = false;
            // 
            // questionUserControl12
            // 
            this.questionUserControl12.AnswerContent = "";
            this.questionUserControl12.Location = new System.Drawing.Point(-4, 191);
            this.questionUserControl12.Name = "questionUserControl12";
            this.questionUserControl12.Size = new System.Drawing.Size(885, 80);
            this.questionUserControl12.TabIndex = 1;
            this.questionUserControl12.TrueCheckBox = false;
            // 
            // questionUserControl13
            // 
            this.questionUserControl13.AnswerContent = "";
            this.questionUserControl13.Location = new System.Drawing.Point(-2, 272);
            this.questionUserControl13.Name = "questionUserControl13";
            this.questionUserControl13.Size = new System.Drawing.Size(885, 80);
            this.questionUserControl13.TabIndex = 2;
            this.questionUserControl13.TrueCheckBox = false;
            // 
            // questionUserControl14
            // 
            this.questionUserControl14.AnswerContent = "";
            this.questionUserControl14.Location = new System.Drawing.Point(-2, 358);
            this.questionUserControl14.Name = "questionUserControl14";
            this.questionUserControl14.Size = new System.Drawing.Size(885, 80);
            this.questionUserControl14.TabIndex = 3;
            this.questionUserControl14.TrueCheckBox = false;
            // 
            // questionUserControl15
            // 
            this.questionUserControl15.AnswerContent = "";
            this.questionUserControl15.Location = new System.Drawing.Point(-4, 435);
            this.questionUserControl15.Name = "questionUserControl15";
            this.questionUserControl15.Size = new System.Drawing.Size(885, 80);
            this.questionUserControl15.TabIndex = 4;
            this.questionUserControl15.TrueCheckBox = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearButton.Location = new System.Drawing.Point(229, 542);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(170, 35);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Wyczyść";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NextButton.Location = new System.Drawing.Point(504, 542);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(170, 35);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Następne pytanie";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuestionLabel.Location = new System.Drawing.Point(15, 47);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(111, 39);
            this.QuestionLabel.TabIndex = 7;
            this.QuestionLabel.Text = "Treść:";
            // 
            // QuestionContenttextBox
            // 
            this.QuestionContenttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuestionContenttextBox.Location = new System.Drawing.Point(143, 55);
            this.QuestionContenttextBox.Name = "QuestionContenttextBox";
            this.QuestionContenttextBox.Size = new System.Drawing.Size(726, 32);
            this.QuestionContenttextBox.TabIndex = 8;
            // 
            // NameofFiletextBox
            // 
            this.NameofFiletextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameofFiletextBox.Location = new System.Drawing.Point(143, 12);
            this.NameofFiletextBox.Name = "NameofFiletextBox";
            this.NameofFiletextBox.Size = new System.Drawing.Size(726, 32);
            this.NameofFiletextBox.TabIndex = 9;
            this.NameofFiletextBox.Visible = false;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 625);
            this.Controls.Add(this.NameofFiletextBox);
            this.Controls.Add(this.QuestionContenttextBox);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.questionUserControl15);
            this.Controls.Add(this.questionUserControl14);
            this.Controls.Add(this.questionUserControl13);
            this.Controls.Add(this.questionUserControl12);
            this.Controls.Add(this.questionUserControl11);
            this.Name = "View";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuestionUserControl1 questionUserControl11;
        private QuestionUserControl1 questionUserControl12;
        private QuestionUserControl1 questionUserControl13;
        private QuestionUserControl1 questionUserControl14;
        private QuestionUserControl1 questionUserControl15;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.TextBox QuestionContenttextBox;
        private System.Windows.Forms.TextBox NameofFiletextBox;
    }
}

