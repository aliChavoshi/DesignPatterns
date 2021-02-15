using System;

namespace DesignPatterns.Mediator
{
    //Concrete Mediator
    public class ArticlesDialogBox
    {
        private static readonly TextBox TitleTextBox = new();
        private static readonly Button SaveButton = new();
        private static readonly ListBox ArticlesListBox = new();

        public ArticlesDialogBox()
        {
            ArticlesListBox.AddEventHandler(new ArticleSelect());
            TitleTextBox.AddEventHandler(new TitleChange());
        }
        public void SimulateUserInteraction()
        {
            ArticlesListBox.Selection = "Article1";
            TitleTextBox.Content = "";
            Console.WriteLine("TextBox : " + TitleTextBox.Content);
            Console.WriteLine("Button : " + SaveButton.IsEnabled);
        }
        private class ArticleSelect : IEventHandler
        {
            private void ArticleSelected()
            {
                TitleTextBox.Content = ArticlesListBox.Selection;
                SaveButton.IsEnabled = true;
            }
            public void Handle()
            {
                ArticleSelected();
            }
        }
        private class TitleChange : IEventHandler
        {
            private void TitleChanged()
            {
                SaveButton.IsEnabled = true;
                if (string.IsNullOrEmpty(TitleTextBox.Content))
                    SaveButton.IsEnabled = false;
            }
            public void Handle()
            {
                TitleChanged();
            }
        }
    }

}