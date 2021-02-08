using System;
using DesignPatterns.DependencyInjection;
using DesignPatterns.Inheritance;
using DesignPatterns.MementoPattern;
using DesignPatterns.MementoPattern.Exercise;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Memento

            /*var editor = new Editor();
            var history = new History();

            editor.SetContent("a");
            history.Push(editor.CreateState());

            editor.SetContent("b");
            history.Push(editor.CreateState());

            editor.SetContent("c");

            editor.Restore(history.Pop());
            editor.Restore(history.Pop());

            Console.WriteLine(editor.GetContent());*/

            #endregion

            #region ExerciseMemento

            var doc = new Document();
            var history = new HistoryDocument();

            doc.SetContent("Ali");
            doc.SetFontName("B Nazanin");
            doc.SetFontSize(10);
            history.Push(doc.CreateState());

            doc.SetContent("Mahshad");
            doc.SetFontName("B Titr");
            doc.SetFontSize(15);
            history.Push(doc.CreateState());

            doc.Restore(history.Pop());
            doc.Restore(history.Pop());

            Console.WriteLine(doc.GetContent());
            Console.WriteLine(doc.GetFontName());
            Console.WriteLine(doc.GetSizeFont());

            #endregion
        }

        static void Drawing(UiControl control)
        {
            control.Draw();
        }

        static ITaxCalculator Calculator()
        {
            return new CalculateTax2019();
        }
    }
}
