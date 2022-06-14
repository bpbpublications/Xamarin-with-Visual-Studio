using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    public class EventsDemo
    {
        public event EventHandler<OperationCompletedEventArgs> FileCompleted;

        public void OpenFile(string fileName)
        {
            string result = System.IO.File.ReadAllText(fileName);
            var eventArgs = new OperationCompletedEventArgs(fileName);
            FileCompleted?.Invoke(this, eventArgs);
        }
    }

    public class OperationCompletedEventArgs: EventArgs
    {
        public string FileName { get; set; }

        public OperationCompletedEventArgs(string fileName)
        {
            FileName = fileName;
        }
    }

    public class SubscribingForEvents
    {
        public SubscribingForEvents()
        {
            var demo = new EventsDemo();
            demo.FileCompleted += Demo_FileCompleted;
            demo.OpenFile(@"c:\myfile.txt");

        }

        private void Demo_FileCompleted(object sender, OperationCompletedEventArgs e)
        {
            string fileName = e.FileName;
        }
    }
}
