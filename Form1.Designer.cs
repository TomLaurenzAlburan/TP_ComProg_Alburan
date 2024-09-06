namespace Word_Guessing_Game_Alburan
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
            lb_mystery_word = new Label();
            tb_guess = new TextBox();
            tb_check = new Button();
            label2 = new Label();
            wrong_guess_list = new ListBox();
            SuspendLayout();
            // 
            // lb_mystery_word
            // 
            lb_mystery_word.AutoSize = true;
            lb_mystery_word.Font = new Font("Century", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_mystery_word.Location = new Point(109, 116);
            lb_mystery_word.Name = "lb_mystery_word";
            lb_mystery_word.Size = new Size(163, 25);
            lb_mystery_word.TabIndex = 0;
            lb_mystery_word.Text = "Mystery Word";
            // 
            // tb_guess
            // 
            tb_guess.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_guess.Location = new Point(42, 185);
            tb_guess.Name = "tb_guess";
            tb_guess.Size = new Size(311, 22);
            tb_guess.TabIndex = 1;
            // 
            // tb_check
            // 
            tb_check.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_check.Location = new Point(125, 242);
            tb_check.Name = "tb_check";
            tb_check.Size = new Size(124, 52);
            tb_check.TabIndex = 2;
            tb_check.Text = "Check";
            tb_check.UseVisualStyleBackColor = true;
            tb_check.Click += tb_check_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(573, 141);
            label2.Name = "label2";
            label2.Size = new Size(112, 16);
            label2.TabIndex = 3;
            label2.Text = "Wrong Guesses";
            // 
            // wrong_guess_list
            // 
            wrong_guess_list.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wrong_guess_list.FormattingEnabled = true;
            wrong_guess_list.Location = new Point(492, 185);
            wrong_guess_list.Name = "wrong_guess_list";
            wrong_guess_list.Size = new Size(284, 164);
            wrong_guess_list.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(wrong_guess_list);
            Controls.Add(label2);
            Controls.Add(tb_check);
            Controls.Add(tb_guess);
            Controls.Add(lb_mystery_word);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_mystery_word;
        private TextBox tb_guess;
        private Button tb_check;
        private Label label2;
        private ListBox wrong_guess_list;
    }
}
