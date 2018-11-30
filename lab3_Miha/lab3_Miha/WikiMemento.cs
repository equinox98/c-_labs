namespace lab3
{
    public class WikiMemento //class to save state of Wiki page
    {
        public WikiMemento(string title, string info, string date, string author)
        {
            _author = author;
            _date = date;
            _info = info;
            _title = title;
        }

        private string _title;
        private string _info;
        private string _author;
        private string _date;

        public string Title
        {
            get => _title;
        }

        public string Info
        {
            get => _info;
            
        }

        public string Author
        {
            get => _author;
        }

        public string Date
        {
            get => _date;
        }
    }
}