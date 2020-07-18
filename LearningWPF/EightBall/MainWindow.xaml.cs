using System;
using System.Windows;
using System.Windows.Input;

namespace EightBall
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetAnswerButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (QuestionTextBox.Text.StartsWith("["))
            {
                QuestionTextBox.Text = "[Please enter a question here]";
                return;
            }

            Cursor = Cursors.Wait;
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            AnswerTextBox.Text = AnswerGenerator.GetRandomAnswer();
            Cursor = null;
        }

        private void QuestionTextBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (QuestionTextBox.Text.StartsWith("["))
            {
                QuestionTextBox.Text = string.Empty;
            }
        }
    }
}
