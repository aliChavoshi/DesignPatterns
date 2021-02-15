using System;
using DesignPatterns.CommandPattern;
using DesignPatterns.CommandPattern.CompositeCommand;
using DesignPatterns.CommandPattern.fx;
using DesignPatterns.CommandPattern.Undoable;
using DesignPatterns.DependencyInjection;
using DesignPatterns.Mediator;
using DesignPatterns.Observer;
using DesignPatterns.Strategy;
using DesignPatterns.TemplatePattern;
using UiControl = DesignPatterns.Inheritance.UiControl;

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

            /*var doc = new Document();
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
            Console.WriteLine(doc.GetSizeFont());*/

            #endregion

            #region State

            /*
            var canvas = new Canvas(new Eraser());
            canvas.MouseUp();
            canvas.MouseDown();
            */

            #endregion

            #region AbuseStatePattern

            /*var stopwatch = new StopWatch();
            stopwatch.Click();
            stopwatch.Click();*/


            #endregion

            #region IteratorPattern

            /*var history = new BrowserHistory();
            history.Push("a");
            history.Push("b");
            history.Push("c");

            var iterator = history.CreateIterator();
            while (iterator.HasNext())
            {
                var url = iterator.Current();
                Console.WriteLine(url);
                iterator.Next();
            }*/

            #endregion

            #region StartegyPattern

            /*
            var store = new ImageStore();
            store.Store("a",new JpegCompressor(),new BlackAndWhite());
            store.Store("b",new PngCompressor(),new HighContrast());
            */

            #endregion

            #region Template

            /*var task = new TransferMoneyTask();
            task.Execute();*/

            #endregion

            #region Command

            /*var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command, "Add");
            button.Click();*/

            /*var composite = new CompositeCommand();
            composite.Add(new ResizeCommand());
            composite.Add(new BlackAndWhiteCommand());
            composite.Execute();*/

            /*
            var htmlDocument = new HtmlDocument();
            htmlDocument.SetContent("Hello World");

            var history = new History();
            var boldCommand = new BoldCommand(htmlDocument, history);
            var italicCommand = new ItalicCommand(htmlDocument, history);

            italicCommand.Execute();
            Console.WriteLine(htmlDocument.GetContent());

            boldCommand.Execute();
            Console.WriteLine(htmlDocument.GetContent());

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            Console.WriteLine(htmlDocument.GetContent());*/

            #endregion

            #region Observer

            /*var dataSource = new DataSource();

            var chart = new Chart(dataSource);
            var spreadChart = new SpreadSheet(dataSource);

            dataSource.AddObserver(chart);
            dataSource.AddObserver(spreadChart);

            dataSource.SetValue(10);*/

            #endregion

            #region Mediator

            var dialogBox = new ArticlesDialogBox();
            dialogBox.SimulateUserInteraction();

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
