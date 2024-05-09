namespace MindBoxTasks.Common.Utils;

public static class MyMath
{
    public static T? Max<T>(params T?[]? objects) where T : IComparable<T>
    {
        var max = default(T);
        var flag = false;

        ArgumentNullException.ThrowIfNull(objects);

        foreach (var obj in objects)
        {
            if (obj != null && (!flag || obj.CompareTo(max) > 0))
            {
                max = obj;
                flag = true;
            }
        }
        
        if (!flag)
        {
            throw new ArgumentNullException(nameof(objects));
        }
        
        return max;
    }
    
    public static T? Min<T>(params T?[]? objects) where T : IComparable<T>
    {
        var min = default(T);
        var flag = false;

        ArgumentNullException.ThrowIfNull(objects);

        foreach (var obj in objects)
        {
            if (obj != null && (!flag || obj.CompareTo(min) < 0))
            {
                min = obj;
                flag = true;
            }
        }

        if (!flag)
        {
            throw new ArgumentNullException(nameof(objects));
        }
        
        return min;
    }
}