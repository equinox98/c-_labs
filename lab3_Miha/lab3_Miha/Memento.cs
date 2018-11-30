using System.Collections.Generic;

namespace lab3
{
    public class Memento
    {
        public Memento()
        {
            History = new Stack<WikiMemento>();
        }

        private Stack<WikiMemento> History;

        public WikiMemento PopState() // get state from stack
        {
            return History.Pop(); 
        }

        public void PushState(WikiMemento wikiMemento) // push state to stack
        {
            History.Push(wikiMemento);
        }
    }
}