namespace adv.c_
{
    #region q1

    // Write a generic class Container<T> with Add and Get methods.

    class Container<T>
    {
        private T item;

        public void Add(T value)
        {
            item = value;
        }

        public T Get()
        {
            return item;
        }
    }

    #endregion



}
