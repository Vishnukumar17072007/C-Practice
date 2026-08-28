using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Array
{
    class Duplicate
    {
        public string[] Find(string[] arr)
        {
            int len = arr.Length;
            List<string> NonDuplicateArr = new List<string> ();

            for(int i = 0; i<arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < NonDuplicateArr.Count; j++)
                {
                    if (arr[i] == NonDuplicateArr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if(!isDuplicate)
                {
                    NonDuplicateArr.Add(arr[i]);
                }
            }

            string[] ResultArr = NonDuplicateArr.ToArray();

            return ResultArr;
        }
    }
}
