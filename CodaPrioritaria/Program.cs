using System.Collections;

class CodaPrioritaria : IComparable
{
    private ArrayList _arrList;

    public ArrayList ArrList
    { 
        get => _arrList;
        set => _arrList = value;
    }

    public CodaPrioritaria()
    {
        ArrList = new ArrayList();
    }

    public CodaPrioritaria(ArrayList arrList)
    {
        ArrList = arrList;
    }

    public CodaPrioritaria(CodaPrioritaria oldCoda)
    {
        ArrList = oldCoda.ArrList;
    }

    public override bool Equals(object obj)
    {
        if (!(obj is CodaPrioritaria) || obj == null)
        {
            return false;
        }

        CodaPrioritaria other = (CodaPrioritaria)obj;
        return ArrList.Equals(other.ArrList);
    }

    public void Aggiunta(object? value)
    {
        int index = 0;

        while (index < ArrList.Count && (ArrList[index]).CompareTo())
        {

        }
    }

    public int Ricerca(object? value)
    {
        return ArrList.IndexOf(value);
    }

    public bool IsEmpty()
    {
        return ArrList.Count == 0;
    }

    public object? Peek()
    {
        if (IsEmpty())
        {
            return null;
        }

        return ArrList[0];
    }

    public object? EstrazPrimo()
    {
        if (IsEmpty())
        {
            return null;
        }

        object? value = ArrList[0];
        ArrList.RemoveAt(0);

        return value;
    }

    public object? EstrazUltimo()
    {
        if (IsEmpty())
        {
            return null;
        }

        int index = ArrList.Count - 1;

        object? value = ArrList[index];
        ArrList.RemoveAt(index);

        return value;
    }
}

class Program
{
    public static void Main()
    {
        // scorri l'arraylist, vedi quale è l'elemento maggiore, metti l'elemento già nella posizione corretta
        CodaPrioritaria coda = new CodaPrioritaria();

        coda.Aggiunta("asaa");

        foreach(var item in coda.ArrList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(coda.Ricerca("asaa"));

        Console.WriteLine(coda.IsEmpty());

        coda.EstrazPrimo();

        Console.WriteLine(coda.IsEmpty());

        for (int i = 0; i < 5; i++)
        {
            coda.Aggiunta(i);
        }

        foreach (var item in coda.ArrList)
        {
            Console.WriteLine(item);
        }

        coda.EstrazUltimo();

        foreach (var item in coda.ArrList)
        {
            Console.WriteLine(item);
        }
    }
}