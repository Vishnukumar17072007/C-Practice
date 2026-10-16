using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Dictionaries
{
    class PersonalDetails
    {
        public void run()
        {
            Dictionary<string, string> datas = new Dictionary<string, string>();
            datas.Add("Name", "Vishnu");
            datas.Add("Email", "vk2579789@gmail.com");
            datas.Add("Phone", "9043375496");

            foreach(var data in datas.Keys)
            {
                Console.WriteLine(data + ": " + datas[data]);
            }
        }
    }
}
