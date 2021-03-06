﻿using System.Collections.Generic;

namespace PaintApplication.Model.MementoItems
{
    class Caretaker
    {
        private readonly Stack<Memento> _mementoes;

        public Caretaker()
        {
            _mementoes = new Stack<Memento>();
        }
        public void SaveMemento(Originator originator)
        {
            _mementoes.Push(originator.CreateMemento());
        }

        public void RestoreMemento(Originator originator)
        {
            if (_mementoes.Count > 0)
            {
                Memento lastMemento = _mementoes.Pop();
                originator.SetMemento(lastMemento);
            }
        }
    }
}
