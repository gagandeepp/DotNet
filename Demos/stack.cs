using System;
using System.Collections.Generic;

public class TextEditor
{
    private Stack<string> undoStack = new Stack<string>();
    private string currentText = string.Empty;

    public void TypeText(string text)
    {
        undoStack.Push(currentText);
        currentText += text;
        Console.WriteLine($"Current Text: {currentText}");
    }

    public void Undo()
    {
        if (undoStack.Count > 0)
        {
            currentText = undoStack.Pop();
            Console.WriteLine($"Undo: {currentText}");
        }
        else
        {
            Console.WriteLine("Nothing to undo.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        TextEditor editor = new TextEditor();
        editor.TypeText("Hello");
        editor.TypeText(" World");
        editor.Undo();
        editor.Undo();
        editor.Undo();
    }
}
