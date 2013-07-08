using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Printing;

namespace PrintControl
{
    public partial class Invoice : UserControl
    {
        private PrintDocument printDocumentWithEventsField;

        private PrintDocument PrintDocument
        {
            get { return printDocumentWithEventsField; }
            set
            {
                if (printDocumentWithEventsField != null)
                {
                    printDocumentWithEventsField.PrintPage -= PrintPage;
                }
                printDocumentWithEventsField = value;
                if (printDocumentWithEventsField != null)
                {
                    printDocumentWithEventsField.PrintPage += PrintPage;
                }
            }
        }

        public Invoice()
        {
            InitializeComponent();
            PrintDocument = new PrintDocument();
        }

        private void PrintButtonClick(object sender, RoutedEventArgs e)
        {
            PrintDocument.Print(string.Format("Invoice Date: {0}", DateTime.Today.ToLongDateString()));
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            e.PageVisual = LayoutRoot;
        }
    }
}
