using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepticV2
{
    class Item
    {
        public bool show;
        public List<string> descriptor;
        public List<string> action;
        private string name;

        public Item(string name)
        {
            this.show = true;
            descriptor = new List<string>();
            action = new List<string>();
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }

        public string ConcatinateDescrip()
        {
            var descripRule = "";
            foreach (string element in this.descriptor)
            {
                descripRule = descripRule + element + "\n";           
            }
            return (descripRule);
        }

        public string ConcatinateAction()
        {
            var actionRule = "";
            foreach(string element in this.action)
            {
                actionRule = actionRule + element + "\n";
            }
            return (actionRule);
        }
    }
}
