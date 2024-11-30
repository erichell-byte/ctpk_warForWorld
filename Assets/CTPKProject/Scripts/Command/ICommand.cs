using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
    void Execute();

    void Undo();
}

public class AddCommand : ICommand
{
    public void Execute()
    {
        
    }

    public void Undo()
    {
    }
}

public class SubtractCommand : ICommand
{
    public void Execute()
    {
        
    }

    public void Undo()
    {
        
    }
}