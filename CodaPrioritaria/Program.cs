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
        if (ArrList.Count == 0)
        {
            ArrList.Add(value);
            return;
        }

        for (int i = 0; i < ArrList.Count; i++)
        {
            int fabietto = ((IComparable)ArrList[i]).CompareTo(value);

            if (fabietto == 1)
            {
                if (i == ArrList.Count - 1)
                {
                    ArrList.Add(value);
                }
            }
            else if (fabietto == -1)
            {
                ArrList.Insert(i, value);
                break;
            }
            else if (fabietto == 0)
            {
                ArrList.Insert(i, ArrList[i]);
            }
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

    public int CompareTo(object? value)
    {
        IComparable other = (IComparable)value;
        // se primo > secondo == 1; else if secondo > primo == -1; else == 0

        return CompareTo(other);
    }
}

class Program
{
    public static void Main()
    {
        // scorri l'arraylist, vedi quale è l'elemento maggiore, metti l'elemento già nella posizione corretta
        CodaPrioritaria coda = new CodaPrioritaria();

        coda.Aggiunta(4522222);
        coda.Aggiunta(298765);
        coda.Aggiunta(154);

        foreach(var item in coda.ArrList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(coda.Ricerca("asaa"));

        Console.WriteLine(coda.IsEmpty());

        coda.EstrazPrimo();

        Console.WriteLine(coda.IsEmpty());

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