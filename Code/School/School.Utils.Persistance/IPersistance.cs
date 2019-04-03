using System;

namespace School.Utils.Persistance
{
    public interface IPersistance<T>
    {
        T Create(T item);
        T ReadById(int id);
        T[] Read(string[] fields, string[] values);
        T Update(T item);
        void Delete(int id);        
    }
}
