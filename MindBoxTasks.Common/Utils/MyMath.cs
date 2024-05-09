namespace MindBoxTasks.Common.Utils;

public static class MyMath
{
    public static T? Max<T>(params T?[]? objects) where T : IComparable<T>
    {
        var max = default(T);

        if (objects == null)
        {
            return max;
        }
        
        foreach (var obj in objects)
        {
            if (obj != null && (max == null || obj.CompareTo(max) > 0))
            {
                max = obj;
            }
        }
        
        return max;
    }
    
    public static T? Min<T>(params T?[]? objects) where T : IComparable<T>
    {
        var min = default(T);

        if (objects == null)
        {
            return min;
        }
        
        foreach (var obj in objects)
        {
            if (obj != null && (min == null || obj.CompareTo(min) < 0))
            {
                min = obj;
            }
        }
        
        return min;
    }
}