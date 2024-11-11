namespace ConsoleApp1;

public static class Functions
{

    public static int Aggregation(this List<int> list, int seed, Func<int, int, int> function)
    {
        int result = seed;
        foreach (var item in list)
        {
            result = function(result, item);
        }
        return result;

    }
    public static decimal AggregationForPrices(this List<decimal> list, int seed, Func<decimal, decimal,decimal> function)
    {
        var result = 0m;
        foreach (var item in list)
        {
            result = function(result, item);
        }
        return result;

    }
    
    public static List<T> AggregationForLists<T>(this List<T> list, Func<T, bool> function)
    {
        List<T> result = new List<T>();
        foreach (var item in list)
        {
            if (function(item))
            {
                result.Add(item);

            }
        }
        return result;
    }
        
   

        public static List<TResult> Transform <TSource,TResult>(this List<TSource> list, Func<TSource, TResult> selector)
    {
        var result = new List<TResult>();
        foreach (var item in list)
        {
            TResult value = selector(item);
                result.Add(value);
        }
        return result;
    }

    public static int CycleFromEndToStart<T>(this List<T> collection, T sadzebni, Func<T, T, bool> ragaca)
    {

        for (int i = collection.Count-1; i>=0; i--)
        {
            if (ragaca(collection[i], sadzebni)) { return i; }
        }
        return -1;
    }
        public static int CycleFromStartToEnd<T>(this List<T> collection, T sadzebni, Func<T, T, bool> ragaca)
    {

        for (int i = 0; i < collection.Count; i++)
        {
            if (ragaca(collection[i], sadzebni)) { return i; }
        }
        return -1;
    }

    public static T Find<T>(this List<T> sourse, Func<T, bool> match)
    {
         
        foreach (var item in sourse)
        {
            if (match(item))
            {
                return item;
            };
        }
        return default;
    }
}
