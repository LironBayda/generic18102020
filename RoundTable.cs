using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic19092020
{
    class RoundTable<T>: IEnumerable<T>
    {

       private List<T> _entities=new List<T>();

        public void Add(T item)
        {
            _entities.Add(item);
        }

        public void RemoveAt(int ind)
        {
            _entities.RemoveAt(ind % _entities.Count);
        }

       public void InsertAt(int ind,T item)
        {
            _entities.Insert(ind % _entities.Count,item);
        }

        public void Sort()
        {
            _entities.Sort();
        }
        public List<T> GetRounded(int num)
        {
            List<T> rounded = new List<T>();
            for(int i=0; i<num;i++)
            {
                rounded.Add(_entities[i % _entities.Count]);
            }

            return rounded;
        }

        public T this[int index]
        {
            get { return _entities[index % _entities.Count]; }
        }

        public object this[string name]
        {

            get { foreach (T item in _entities)
                {
                    string itemName=item.ToString().Split()[0];
                    if (name == itemName)
                        return item;
                }

                return null;
                    
                        }
        }





        public IEnumerator<T> GetEnumerator()
        {
            return _entities.GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return _entities.GetEnumerator(); 
       }

        public override string ToString()
        {
            string str= " ";
            _entities.ForEach(item => str += item.ToString() + "\n");
            
            return base.ToString()+str;
        }
    }
}
