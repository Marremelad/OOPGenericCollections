namespace OOPGenericCollections;

public abstract class Helper<T>
{
    // Method to convert an ICollection<T> into a Stack<T>.
    public static Stack<T> PushToStack(ICollection<T> list)
    {
        Stack<T> stack = new Stack<T>();
        
        foreach (var item in list)
        {
            stack.Push(item);
        }
        
        return stack;
    }
}