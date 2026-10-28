using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

    //class Pair<TKey, TValue>
    //{
    //    public TKey Key;
    //    public TValue Value;

    //    public Pair(TKey key, TValue value)
    //    {
    //        Key = key;
    //        Value = value;
    //    }
    //}
    #endregion



    #region q3

    ////    What is a generic method? Write Swap<T> method.
    ////A generic method is a method that works with different data types using a type parameter.

    //static void Swap<T>(ref T a, ref T b)
    //{
    //    T temp = a;
    //    a = b;
    //    b = temp;
    //}

    #endregion

    #region q4
    //    What is a generic interface? Write IRepository<T>.
    //A generic interface is an interface that uses a type parameter to work with different data types.
    //interface IRepository<T>
    //    {
    //        void Add(T item);
    //        T Get();
    //    }



    #endregion





    #region q5
    //    What is the struct constraint? Write an example.
    //The struct constraint requires T to be a non-nullable value type.
    //class Test<T> where T : struct
    //    {
    //        public T Value;
    //    }


    #endregion



    #region q6


    //    Q8: What is the class constraint? Write an example.
    //The class constraint requires T to be a reference type.
    //class Test<T> where T : class
    //    {
    //        public T Value;
    //    }


    #endregion





    #region q7


    //    What is the new () constraint? Write an example.
    //The new () constraint requires T to have a public parameterless constructor.
    //class Test<T> where T : new()
    //    {
    //        public T Create()
    //        {
    //            return new T();
    //        }
    //    }


    #endregion




    #region q8  

//    What is the interface constraint? Write an example.
//The interface constraint requires T to implement a specific interface.
interface IPrintable
    {
        void Print();
    }

    class Test<T> where T : IPrintable
    {
        public void Show(T item)
        {
            item.Print();
        }
    }



    #endregion

}
