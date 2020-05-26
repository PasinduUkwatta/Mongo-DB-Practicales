using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Demo_Mongo
{
    public class DemoSet1
    {
        public static void main()
        {
            MongoClient client = new MongoClient();
            var db_list = client.ListDatabases().ToList();

            foreach (var db in db_list)
            {
                Console.WriteLine(db.ToJson());
            }

            Console.ReadKey();
        }


    }
}