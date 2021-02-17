using System.Collections;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.DependencyInjection;
using DesignPatterns.Mediator;
using DesignPatterns.State.Abuse;
using DesignPatterns.Visitor;
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
            stopwatch.Click();//Running
            stopwatch.Click();//Stopped*/


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

            dataSource.Attach(chart);
            dataSource.Attach(spreadChart);

            dataSource.SetValue(10);*/

            #endregion

            #region Mediator

            /*
            var dialogBox = new ArticlesDialogBox();
            dialogBox.SimulateUserInteraction();
            */

            #endregion

            #region ChainOfResponsibility

            //authenticator -> logger -> compressor = Last Task
            /*var compressor = new Compressor(null);
            var logger = new Logger(next: compressor);
            var authenticator = new Authenticator(next: logger);

            var webServer = new WebServer(handler: authenticator);
            webServer.Handle(new HttpRequest("admin", "1234"));*/

            #endregion

            #region VisitorPattern

            var document = new HtmlDocument();
            document.Add(new AnchorNode());
            document.Add(new HeadingNode());
            document.Execute(new HighlightOperation());
            document.Execute(new PlainTextOperation());

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
