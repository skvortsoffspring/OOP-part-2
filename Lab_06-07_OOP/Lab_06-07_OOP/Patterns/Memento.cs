using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Lab_06_07_OOP.Patterns
{

    class Memento
    {
        private List<product> _mementos = new ();
        private int _position;
        private product _memento;
        private product _first;
        public Memento(product SelectedProduct)
        {
            _memento = SelectedProduct;
        }

        public void Backup(object state)
        {
            _memento = MainWindow.ViewModel.SelectedProduct; 
            if(string.IsNullOrEmpty(_memento.ProductName))
                return;
            
            if(_mementos.Count != 0)
            if (_first!= _memento)
            {
                _mementos.Clear();
                _position = 0;
            }
            
            if (_mementos.Count() == 0)
            {
                _first = _memento;
                var _product =  _memento.ShallowCopy();
                _mementos.Add(_product);
            }

            if (!_memento.Check(_mementos[_position]))
            {
                var _product = _memento.ShallowCopy();
                _position++;
                _mementos.Insert(_position,_product);
            }
        }

        public void Undo()
        {
            if (_position == 0)
            {
                return;
            }
            
            MainWindow.ViewModel.SelectedProduct = _mementos[_position-1];
            _first = _mementos[_position-1];
            if(_position>0)
                _position--;
        }

        public void Redo()
        {
            if ((_position) != _mementos.Count - 1)
            {
                _position++;
                _first = _mementos[_position-1];
                MainWindow.ViewModel.SelectedProduct = _mementos[_position-1];
            }
        }
    }
}