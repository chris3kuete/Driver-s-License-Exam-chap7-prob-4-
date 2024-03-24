namespace Driver_s_License_Exam_chap7_prob_4_
{
    partial class Form1
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
            label1 = new Label();
            WrongAnswerslb = new ListBox();
            displayBtn = new Button();
            button2 = new Button();
            label2 = new Label();
            correctlbl = new Label();
            wrong1lbl = new Label();
            wronglbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 9);
            label1.Name = "label1";
            label1.Size = new Size(313, 28);
            label1.TabIndex = 0;
            label1.Text = "Incorrectly Answered Questions";
            // 
            // WrongAnswerslb
            // 
            WrongAnswerslb.FormattingEnabled = true;
            WrongAnswerslb.Location = new Point(166, 55);
            WrongAnswerslb.Name = "WrongAnswerslb";
            WrongAnswerslb.Size = new Size(418, 424);
            WrongAnswerslb.TabIndex = 1;
            // 
            // displayBtn
            // 
            displayBtn.BackColor = SystemColors.Info;
            displayBtn.Location = new Point(631, 210);
            displayBtn.Name = "displayBtn";
            displayBtn.Size = new Size(122, 52);
            displayBtn.TabIndex = 2;
            displayBtn.Text = "Display";
            displayBtn.UseVisualStyleBackColor = false;
            displayBtn.Click += displayBtn_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Location = new Point(631, 316);
            button2.Name = "button2";
            button2.Size = new Size(122, 42);
            button2.TabIndex = 3;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 539);
            label2.Name = "label2";
            label2.Size = new Size(230, 23);
            label2.TabIndex = 4;
            label2.Text = "Number of correct Answers";
            // 
            // correctlbl
            // 
            correctlbl.BorderStyle = BorderStyle.FixedSingle;
            correctlbl.Location = new Point(73, 584);
            correctlbl.Name = "correctlbl";
            correctlbl.Size = new Size(189, 56);
            correctlbl.TabIndex = 5;
            correctlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wrong1lbl
            // 
            wrong1lbl.AutoSize = true;
            wrong1lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wrong1lbl.Location = new Point(456, 539);
            wrong1lbl.Name = "wrong1lbl";
            wrong1lbl.Size = new Size(229, 23);
            wrong1lbl.TabIndex = 6;
            wrong1lbl.Text = "Number of Wrong Answers";
            // 
            // wronglbl
            // 
            wronglbl.BorderStyle = BorderStyle.FixedSingle;
            wronglbl.Location = new Point(480, 584);
            wronglbl.Name = "wronglbl";
            wronglbl.Size = new Size(181, 56);
            wronglbl.TabIndex = 7;
            wronglbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 699);
            Controls.Add(wronglbl);
            Controls.Add(wrong1lbl);
            Controls.Add(correctlbl);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(displayBtn);
            Controls.Add(WrongAnswerslb);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox WrongAnswerslb;
        private Button displayBtn;
        private Button button2;
        private Label label2;
        private Label correctlbl;
        private Label wrong1lbl;
        private Label wronglbl;
    }
}
