using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //ArrayList aa = new ArrayList();
        //aa.Add(1);
        //aa.Add(2);

        //Console.WriteLine(aa.Count);
        //Console.WriteLine(aa.Capacity);


        //aa.Insert(0, 2);


        //Hashtable ht = new Hashtable();
        //ht.Add(1, "hello");
        //ht.Add(2, "ho");

        ////foreach( Object h in ht)
        ////{
        ////    Console.WriteLine(h);
        ////}


        //foreach(KeyValuePair<object,object> kvp in ht)
        //{
        //    Console.WriteLine(kvp.Key);
        //    Console.WriteLine(kvp.Value);
        //}

        //List<string> ll = new List<string>();
        //ll.Add("riya");
        //ll.Add("nitin");

        //List<string> l = new List<string>();
        //l.Add("rohit");
        //l.AddRange(ll);


        //List<string> list = new List<string>();
        //list.Add("a");
        //list.Add("b");

        //list.Add("c");
        //list.Add("d");

        //string ? itemtodelete = null;
        //foreach (string s  in list)
        //{
        //    if(s == "b")
        //    {
        //        itemtodelete = s;
        //    }
        //}
        //if(itemtodelete != null)
        //{
        //    list.Remove(itemtodelete);

        //}

        //Stack s = new Stack();



        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.TryAdd(1, "Nitin");
        dic.TryAdd(2, "akash");

    


        //to update dictonary 
        if (dic.ContainsKey(1))
        {
            dic[1] = "vika";
        }


        foreach (KeyValuePair<int, string> kvp in dic)
        {
            Console.WriteLine(kvp.Key);
            Console.WriteLine(kvp.Value);
        }


        
        SortedList s = new SortedList();
    }
}