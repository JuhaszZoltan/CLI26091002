using System;
using System.Collections.Generic;
using System.Text;

namespace CLI26091002
{
    internal class Category
    {
        public string Name { get; set; }
        public int Survivors { get; set; }
        public int Missing { get; set; }

        public Category(string name, int survivors, int missing)
        {
            Name = name;
            Survivors = survivors;
            Missing = missing;
        }

        public Category(string row)
        {
            var tmp = row.Split(';');

            Name = tmp[0];
            Survivors = int.Parse(tmp[1]);
            Missing = int.Parse(tmp[2]);
        }
    }
}
