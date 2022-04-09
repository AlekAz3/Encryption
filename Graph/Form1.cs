using CryptLib;
using System;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ChooseCipher.SelectedIndex = 0;
            ChooseAction.SelectedIndex = 0;
        }


        private void ChangeIndex(object sender, EventArgs e)
        {
            switch (ChooseCipher.SelectedIndex)
            {
                case 0:
                    KeyLabel.Visible = false;
                    KeyTextbox.Visible = false;
                    break;

                case 1:
                    KeyLabel.Visible = true;
                    KeyTextbox.Visible = true;
                    break;

                case 2:
                    KeyLabel.Visible = false;
                    KeyTextbox.Visible = false;
                    break;

                case 3:
                    KeyLabel.Visible = true;
                    KeyTextbox.Visible = true;
                    break;
            }
        }


        private void ActionButton_Click(object sender, EventArgs e)
        {
            switch (ChooseCipher.SelectedIndex)
            {
                case 0:
                    if (ChooseAction.SelectedIndex == 0)
                        SecondRichTextBox.Text = A1Z26.Encrypt(FirstRichTExtBox.Text);
                    else
                        SecondRichTextBox.Text = A1Z26.Decrypt(FirstRichTExtBox.Text);
                    break;

                case 1:
                    if (ChooseAction.SelectedIndex == 0)
                        SecondRichTextBox.Text = Caesar.Encrypt(FirstRichTExtBox.Text.Trim(), Convert.ToInt32(KeyTextbox.Text));
                    else
                        SecondRichTextBox.Text = Caesar.Decrypt(FirstRichTExtBox.Text.Trim(), Convert.ToInt32(KeyTextbox.Text));
                    break;

                case 2:
                    if (ChooseAction.SelectedIndex == 0)
                        SecondRichTextBox.Text = Morse.Encrypt(FirstRichTExtBox.Text);
                    else
                        SecondRichTextBox.Text = Morse.Decrypt(FirstRichTExtBox.Text);
                    break;
                case 3:
                    if (ChooseAction.SelectedIndex == 0)
                        SecondRichTextBox.Text = Vigenere.Encrypt(FirstRichTExtBox.Text.Trim(), KeyTextbox.Text);
                    else
                        SecondRichTextBox.Text = Vigenere.Decrypt(FirstRichTExtBox.Text.Trim(), KeyTextbox.Text);
                    break;
            }
        }
    }
}
