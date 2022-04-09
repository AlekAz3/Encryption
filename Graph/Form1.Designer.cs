namespace Graph
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseCipher = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChooseAction = new System.Windows.Forms.ComboBox();
            this.ActionButton = new System.Windows.Forms.Button();
            this.FirstRichTExtBox = new System.Windows.Forms.RichTextBox();
            this.SecondRichTextBox = new System.Windows.Forms.RichTextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.KeyTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберете шифр: ";
            // 
            // ChooseCipher
            // 
            this.ChooseCipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseCipher.Items.AddRange(new object[] {
            "A1Z26",
            "Caesar",
            "Morse",
            "Viginere"});
            this.ChooseCipher.Location = new System.Drawing.Point(12, 32);
            this.ChooseCipher.Name = "ChooseCipher";
            this.ChooseCipher.Size = new System.Drawing.Size(161, 28);
            this.ChooseCipher.TabIndex = 1;
            this.ChooseCipher.SelectedIndexChanged += new System.EventHandler(this.ChangeIndex);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(190, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выберете действие: ";
            // 
            // ChooseAction
            // 
            this.ChooseAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseAction.Items.AddRange(new object[] {
            "Зашифровать",
            "Расшифровать"});
            this.ChooseAction.Location = new System.Drawing.Point(194, 32);
            this.ChooseAction.Name = "ChooseAction";
            this.ChooseAction.Size = new System.Drawing.Size(161, 28);
            this.ChooseAction.TabIndex = 1;
            // 
            // ActionButton
            // 
            this.ActionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionButton.Location = new System.Drawing.Point(12, 265);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(107, 28);
            this.ActionButton.TabIndex = 2;
            this.ActionButton.Text = "Выполнить";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // FirstRichTExtBox
            // 
            this.FirstRichTExtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstRichTExtBox.Location = new System.Drawing.Point(12, 140);
            this.FirstRichTExtBox.Name = "FirstRichTExtBox";
            this.FirstRichTExtBox.Size = new System.Drawing.Size(211, 119);
            this.FirstRichTExtBox.TabIndex = 3;
            this.FirstRichTExtBox.Text = "";
            // 
            // SecondRichTextBox
            // 
            this.SecondRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondRichTextBox.Location = new System.Drawing.Point(243, 140);
            this.SecondRichTextBox.Name = "SecondRichTextBox";
            this.SecondRichTextBox.Size = new System.Drawing.Size(211, 119);
            this.SecondRichTextBox.TabIndex = 3;
            this.SecondRichTextBox.Text = "";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyLabel.Location = new System.Drawing.Point(12, 76);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(50, 20);
            this.KeyLabel.TabIndex = 4;
            this.KeyLabel.Text = "Ключ";
            this.KeyLabel.Visible = false;
            // 
            // KeyTextbox
            // 
            this.KeyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyTextbox.Location = new System.Drawing.Point(69, 73);
            this.KeyTextbox.Name = "KeyTextbox";
            this.KeyTextbox.Size = new System.Drawing.Size(104, 26);
            this.KeyTextbox.TabIndex = 5;
            this.KeyTextbox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Исходный текст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(239, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Преобразованный текст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 305);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KeyTextbox);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.SecondRichTextBox);
            this.Controls.Add(this.FirstRichTExtBox);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.ChooseAction);
            this.Controls.Add(this.ChooseCipher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Шифры";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChooseCipher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ChooseAction;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.RichTextBox FirstRichTExtBox;
        private System.Windows.Forms.RichTextBox SecondRichTextBox;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.TextBox KeyTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

