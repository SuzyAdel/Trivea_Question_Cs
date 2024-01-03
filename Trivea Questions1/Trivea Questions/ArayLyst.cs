using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivea_Questions
{
    public class ArayLyst
    {
        public string[] array;
        public int size;
        public  int count=0;


        //Constructors
        public ArayLyst(int size)
        {
            this.size = size;
            array = new string[size];
            
        }
        public string Get(int index)//Search by index
        {
            return array[index];
        }
        public int Find(string data)//Search by data
        {
            for (int i = 0; i < size; i++)
            {
                if (data == array[i])
                {
                    return i;
                }
            }
            return -1;
        }
        public bool Add(string data)//ADD
        
        {
            if (count == 0)
            {
                array[0] = data;
                count++;
                return true;
            }
            else
            {
                if (count == size)
                {
                    ResizeArray();
                }
                array[count] = data;
                count++;
                return true;
            }

        }
        public bool Delete(string data)//DELETE
        {
            if (count == 0)
            {
                return false;
            }
            int it = Find(data);
            if (it == -1)
            {
                return false;
            }
            else
            {
                for (int i = it; i < size - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                size--;
                return true;
            }


        }
        public void ResizeArray()
        {
            int newCapacity = array.Length * 2;
            string[] newArray = new string[newCapacity];
            Array.Copy(array, newArray, array.Length);
            array = newArray;
        }

    }
}
