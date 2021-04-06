using System;

namespace Lab_02_OOP
{
    
    public interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }
}