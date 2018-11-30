using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Memento memento = new Memento();
            Wiki wikiPage = new Wiki("Lab3 Title", "Lab3 Info", "30.11.2018", "Sytnik"); //create new wiki page
            wikiPage.print(); // print info
            memento.PushState(wikiPage.SaveState()); // save current state
            wikiPage.Info = "Lab3 changed info after saving state"; // change info
            wikiPage.print(); // print info
            wikiPage.RestoreState(memento.PopState()); // restore previous state
            wikiPage.print(); // print info
        }
    }
}