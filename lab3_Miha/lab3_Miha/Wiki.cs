using System;
using System.Runtime.InteropServices;

namespace lab3
{
    public class Wiki
    {
        public Wiki()
        {
            
        }
        public Wiki(string title, string info, string date, string author)
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
            set => _title = value;
        }

        public string Info
        {
            get => _info;
            set => _info = value;
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public string Date
        {
            get => _date;
            set => _date = value;
        }

       

        public WikiMemento SaveState() // save state to new WikiMemento object
        {
            if (_author.Equals("") || _date.Equals("") || _info.Equals("") || _title.Equals(""))
            {
                Console.WriteLine("!Warning: current page is empty or some information is absent");
            }
            
            return new WikiMemento(_title, _info, _date, _author);
        }

        public void RestoreState(WikiMemento memento) // restore info from WikiMemento object
        {
            _author = memento.Author;
            _date = memento.Date;
            _info = memento.Info;
            _title = memento.Title;
        }

        public void print() // print info about page
        {
            Console.WriteLine("Page: " + _title + "\nAuthor: " + _author + "\nDate: " + _date + "\nText: " + _info);
        }
    }
}