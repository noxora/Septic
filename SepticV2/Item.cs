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
        private string descripRule = "";
        private string actionRule = "";
        public List<string> descriptor;
        public List<string> action;
        private string name;

        /*public string Name
        {
            get
            {
                return name; 
            }
            set
            {
                if (value == "")
                {
                    name = "potato";
                }
                else name = value;
            }
        }*/

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
            foreach(string element in this.descriptor)
            {
                this.descripRule = descripRule + element + "\n";              
            }
            return (this.descripRule);
        }

        public string ConcatinateAction()
        {
            foreach(string element in this.action)
            {
                this.actionRule = actionRule + element + "\n";
            }
            return (this.actionRule);
        }
    }
}
