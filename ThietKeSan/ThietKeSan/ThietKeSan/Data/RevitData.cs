using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace ThietKeSan
{
    public class RevitData
    { // Định nghĩa các biến thành viên
        private Application application;
        private UIDocument uiDocument;
        private Document document;

        private Selection selection;
        private Transaction transaction;

        public UIApplication UIApplication
        {
            get;
            set;
        }

        public UIControlledApplication UIControlledApplication
        {
            get;
            set;
        }

        public Application Application
        {
            get
            {
                if (application == null) application = UIApplication.Application;
                return application;
            }
        }

        public UIDocument UIDocument
        {
            get
            {
                if (uiDocument == null) uiDocument = UIApplication.ActiveUIDocument;
                return uiDocument;
            }
        }

        public Document Document
        {
            get
            {
                if (document == null) document = UIDocument.Document;
                return document;
            }
        }

        public Selection Selection
        {
            get
            {
                if (selection == null) selection = UIDocument.Selection;
                return selection;
            }
        }

        public Transaction Transaction
        {
            get
            {
                if (transaction == null) transaction = new Transaction(Document, "Add-in");
                return transaction;
            }
        }

        public Transaction Transaction_Sup
        {
            get
            {
                if (transaction == null) transaction = new Transaction(Document, "Support");
                return transaction;
            }
        }
    }
}