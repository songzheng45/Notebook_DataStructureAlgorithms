using System;

namespace P01_LinearList
{
    public abstract class BaseList<T>
    {
        // length of list
        public abstract int Length {get;}

        // clear list
        public abstract void Clear();

        // get an element base on index
        public abstract T Find(int index);

        // search the element which matches specified element and return its index
        public abstract int IndexOf(T elem);

        // insert a new element at specified index
        public abstract void Insert(int index, T newElem);

        // delete an element base on its index
        public abstract T Delete(int index);
    }
}