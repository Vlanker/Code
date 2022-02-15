using System.Diagnostics;

namespace Instrumenting;

internal static class Program
{
    // dotnet run --configuration Release
    // dotnet run --configuration Debug
    private static void Main()
    {
        // запись в текстовый файл, расположенный в файле проекта
         Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));
         // модуль записи текста буферизируется, поэтому данная опция 
         // вызывает функцию Flush() для всех прослушивателей после записи
         Trace.AutoFlush = true;
        
        Debug.WriteLine("Debug says, I am watching!");
        Trace.WriteLine("Trace says, I am watching!");
    }
}

