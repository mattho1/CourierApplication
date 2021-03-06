﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurierApplication
{
    public class Packages
    {
        public List<Package> packages { get; set; }
        public Packages()
        {
            packages = new List<Package>();
        }
        public Packages(List<Package> packs)
        {
            packages = packs;
        }
        public void Add(Package pack)
        {
            packages.Add(pack);
        }
        public void Add(List<Package> packs)
        {
            foreach(Package pack in packs)
            {
                packages.Add(pack);
            }
        }

        internal void Remove(Package packageToRemove)
        {
            var item = packages.SingleOrDefault(r => r.number == packageToRemove.number);
            packages.Remove(item);
        }
    }
}
