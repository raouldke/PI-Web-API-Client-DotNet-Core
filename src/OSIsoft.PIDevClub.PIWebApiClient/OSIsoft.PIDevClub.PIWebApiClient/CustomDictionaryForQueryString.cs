using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSIsoft.PIDevClub.PIWebApiClient
{
    public class CustomDictionaryForQueryString
    {
        private List<KeyValuePair<String, String>> items = new List<KeyValuePair<String, String>>();
        public void Add(string key, string value)
        {
            //
            string[] queryStringWords = value.Split(',');
            foreach (var item in queryStringWords)
            {
                items.Add(new KeyValuePair<string, string>(key, item));
            }
        }

        public int Count
        {
            get
            {
                return items.Count;
            }
        }


        public MyEnumerator GetEnumerator()
        {
            return new MyEnumerator(this);
        }

        public class MyEnumerator
        {
            int nIndex;
            CustomDictionaryForQueryString collection;
            public MyEnumerator(CustomDictionaryForQueryString coll)
            {
                collection = coll;
                nIndex = -1;
            }

            public bool MoveNext()
            {
                nIndex++;
                return (nIndex < collection.items.Count);
            }

            public KeyValuePair<String, String> Current
            {
                get
                {
                    return (collection.items[nIndex]);
                }
            }
        }
    }
}
