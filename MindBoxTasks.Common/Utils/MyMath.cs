namespace MindBoxTasks.Common.Utils;

public static class MyMath
{
    public static T? Max<T>(params T?[]? objects) where T : IComparable<T>
    {
        T? max = default(T);

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
}