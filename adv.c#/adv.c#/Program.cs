namespace adv.c_
{
    #region q1

    // Write a generic class Container<T> with Add and Get methods.

    //class Container<T>
    //{
    //    private T item;

    //    public void Add(T value)
    //    {
    //        item = value;
    //    }

    //    public T Get()
    //    {
    //        return item;
    //    }
    //}

    #endregion


    #region q2

    // What are multiple type parameters? Write Pair<TKey, TValue>.
    //Answer: Multiple type parameters allow a generic class to work with two or more types.

    class Pair<TKey, TValue>
    {
        public TKey Key;
        public TValue Value;

        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
    #endregion

}
