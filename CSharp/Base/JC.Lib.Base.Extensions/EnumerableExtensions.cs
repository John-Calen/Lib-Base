namespace Base.Extensions
{
    public static class EnumerableExtensions
    {
        public static T_Item[] ToArray<T_Item>(this IEnumerable<T_Item> enumerable, CancellationToken cancellationToken)
        {
            return enumerable.ToList(cancellationToken).ToArray();
        }

        public static List<T_Item> ToList<T_Item>(this IEnumerable<T_Item> enumerable, CancellationToken cancellationToken)
        {
            var list = new List<T_Item>();
            foreach (var item in enumerable)
            {
                if (cancellationToken.IsCancellationRequested is true)
                    break;

                list.Add(item);
            }

            return list;
        }
    }
}
