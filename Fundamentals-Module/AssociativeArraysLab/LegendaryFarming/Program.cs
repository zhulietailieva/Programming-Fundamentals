using System;
using System.Collections.Generic;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            int shards = 0;
            int fragments = 0;
            int motes = 0;
            Dictionary<string, int> junkItems = new Dictionary<string, int>();
          
            while (shards < 250 && fragments < 250 && motes < 250)
            {
                string[] materials = Console.ReadLine().Split();
                for (int i = 1; i < materials.Length; i+=2)
                {
                    int quantity =int.Parse( materials[i - 1]);
                    string material = materials[i].ToLower();
                    if (material== "shards")
                    {
                        shards += quantity;
                        if (shards >= 250)
                        {
                            break;
                        }
                    }
                    else if (material == "fragments")
                    {
                        fragments += quantity;
                        if (fragments >= 250)
                        {
                            break;
                        }
                    }
                    else if (material == "motes")
                    {
                        motes += quantity;
                        if (motes >= 250)
                        {
                            break;
                        }
                    }
                    
                 else
                    {

                            if (junkItems.ContainsKey(material))
                        {
                            junkItems[material] += quantity;
                        }
                        else
                        {
                            junkItems.Add(material, quantity);
                        }
                    }   
                        
                    
                }
            }
            if (shards >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
             //   collectedItemsList.Remove("shards");
                Console.WriteLine("shards: "+(shards-250));
                Console.WriteLine("motes: "+motes);
                Console.WriteLine("fragments: "+fragments);

            }
            else if (fragments >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
             //   collectedItemsList.Remove("fragments");
                Console.WriteLine("shards: " + (shards));
                Console.WriteLine("motes: " + motes);
                Console.WriteLine("fragments: " + (fragments-250));
            }
            else
            {
                Console.WriteLine("Dragonwrath obtained!");
                //   collectedItemsList.Remove("motes");
                Console.WriteLine("shards: " + (shards));
                Console.WriteLine("motes: " + (motes-250));
                Console.WriteLine("fragments: " + fragments);
            }
            foreach (var item in junkItems)
            {
                Console.WriteLine($"{item.Key.ToLower()}: {item.Value}");
            }

        }
    }
}
