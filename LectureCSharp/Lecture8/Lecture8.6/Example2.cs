using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8._6
{
    class Example2
    {
        static void Main(string[] args)
        {
            //string json = File.ReadAllText("_telegram.json");
            //Console.WriteLine(json);
            //Console.ReadLine();
            //Console.Clear();

            //var massage = JObject.Parse(json)["models"].ToArray();
            //foreach (var item in massage)
            //{
            //    Console.WriteLine(item["params"]["optional"].ToString());
            //}

            //Console.WriteLine(JObject.Parse(json)["params"]["optional"].ToString());
            //Console.ReadLine();
            //var massage = JObject.Parse(json)

            JArray jArray = new JArray();

            JObject mainTree = new JObject();
            mainTree["ok"] = true;

            JObject o = new JObject();
            o["update_id"] = 188978;
            o["massage_id"] = 886;

            jArray.Add(o);
            jArray.Add(o);
            jArray.Add(o);

            mainTree["masasage"] = jArray;

            JObject userObj = new JObject();
            userObj["id"] = 22345157;
            userObj["first_name"] = "Jony";
            userObj["username"] = "Braun";

            mainTree["user"] = userObj;

            string json = mainTree.ToString();
            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}
