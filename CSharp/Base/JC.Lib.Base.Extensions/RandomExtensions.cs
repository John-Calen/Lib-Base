namespace Base.Extensions
{
    public static class RandomExtensions
    {
        public static T_Item Next<T_Item>(this Random random, IReadOnlyCollection<T_Item> collection)
        {
            return random.Next(collection, 0, collection.Count);
        }

        public static T_Item Next<T_Item>(this Random random, IReadOnlyCollection<T_Item> collection, int start, int count)
        {
            var index = random.Next(count);
            if (collection is IReadOnlyList<T_Item> list)
                return list[start + index];

            else
            {
                var collectionIndex = 0;
                foreach (var item in collection)
                {
                    if (collectionIndex == index)
                        return item;

                    ++collectionIndex;
                }

                throw new Exception("Unreachable code");
            }
        }

        public static int NextInt(this Random random, int startInclusive, int endExclusive)
        {
            return random.Next(endExclusive - startInclusive) + startInclusive;
        }

        public static double NextDouble(this Random random, float startInclusive, float endExclusive)
        {
            return random.NextDouble() * (endExclusive - startInclusive) + startInclusive;
        }
    }
}
