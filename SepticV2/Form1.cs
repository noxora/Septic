using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SepticV2
{
    public partial class Form1 : Form 
    {
        string compareCBstring;
        string testString;
        string descripRule;
        string actionRule;
        public int numberrules = 0;
        string descrip;
        string descripstring;
        string actionstring;
        string actionRed;
        string actionBlue;
        string actionGreen;
        List<Item> ruleList = new List<Item>();
        List<String> testList = new List<String>();

        Dictionary<string, string[]> DescripDic = new Dictionary<string, string[]>()
        {
            {"Rarity", new string[] //Add the Rarities to Dictionary
             {
                "Normal",
                "Magic",
                "Rare",
                "Unique",
             }
            },

            {"Class", new string[] //Adding the Vaious Classes to the Dictionary
             {
                 "Life Flask",
                 "Mana Flask",
                 "Hybrid Flask",
                 "Currency",
                 "Amulet",
                 "Ring",
                 "Claw",
                 "Dagger",
                 "Wand",
                 "One Hand Sword",
                 "Thrusting One Hand Sword",
                 "One Hand Axe",
                 "One Hand Mace",
                 "Bow",
                 "Staves",
                 "Two Hand Swords",
                 "Two Hand Axes",
                 "Two Hand Maces",
                 "Active Skill Gems",
                 "Support Skill Gems",
                 "Quivers",
                 "Belt",
                 "Gloves",
                 "Boots",
                 "Body Armours",
                 "Helmets",
                 "Shield",
                 "Stackable Currency",
                 "Quest Items",
                 "Sceptres",
                 "Utility Flasks",
                 "Maps",
                 "Fishing Rods",
                 "Map Fragments",
                 "Hideout Doodads",
                 "Microtransactions",
                 "Jewel",
                 "Card"
             }

            },
            {"Socket Group", new string[] //socket groups
            {
                "R",
                "B",
                "G",
                "RR",
                "RB",
                "RG",
                "BB",
                "BG",
                "GG",
                "RGB"
            }
        }
        };
        Dictionary<string, string> FormatDic = new Dictionary<string, string>()
        //As the name implies, it formats things
        { {"Item Level", "ItemLevel"},
          {"Drop Level", "DropLevel"},
          {"Quality","Quality"},
          {"Rarity", "Rarity"},
          {"Class","Class"},
          {"Sockets","Sockets"},
          {"Linked Sockets", "LinkedSockets"},
          {"Socket Group", "SocketGroup"},
          {"Height","Height"},
          {"Width","Width"},
          {"Set Border Color","SetBorderColor"},
          {"Set Text Color", "SetTextColor"},
          {"Set Background Color", "SetBackgroundColor"},
          {"Play Alert Sound", "PlayAlertSound"},
          {"Set Font Size","Set Font Size"}
        };
        public Form1()
        {
            InitializeComponent();
            //adding the number arrays to the dictionary
            string[] level = new string[100];
            for (int i = 0; i < 100; i++)
            {
                level[i] = (i + 1).ToString();
            }
            string[] quality = level.Take(20).ToArray();
            string[] sockets = level.Take(6).ToArray();
            string[] links = new string[] { "0", "2", "3", "4", "5", "6" };
            string[] height = new string[] { "1", "2", "3", "4", "5", "6" };
            string[] width = new string[] { "1", "2" };
            DescripDic.Add("Item Level", level);
            DescripDic.Add("Drop Level", level);
            DescripDic.Add("Quality", quality);
            DescripDic.Add("Sockets", sockets);
            DescripDic.Add("Linked Sockets", links);
            DescripDic.Add("Height", height);
            DescripDic.Add("Width", width);
        }
        
        private void Form1_Load(object sender, EventArgs e)
            //Disables the boxes that will cause error if used before
            //a  rulelist option is selected
        {
            descripCB.Enabled = false;
            compareCB.Enabled = false;
            specificCB.Enabled = false;
            actionCB.Enabled = false;
            addDescripButton.Enabled = false;
            addActionButton.Enabled = false;
            actionColorButton.Hide();
            volumeL.Hide();
            volumeTB.Hide();
            alertL.Hide();
            alertTB.Hide();
            sizeL.Hide();
            sizeTB.Hide();
        }

        private void AddButton1_Click(object sender, EventArgs e)
            //Adds the rule to rulelistLB + rulelist
            //clears the textbox above it
        {
            Item itm = new Item(ruleNametb.Text);
            ruleList.Add(itm);
            RuleListLB.Items.Add(itm);
            ruleNametb.Clear();
        }

        private void addDescripButton_Click(object sender, EventArgs e)
            //concatinates descripstring
            //casts the selected item
            //adds to + refreshes descripLB
        {
            descripLB.Items.Clear();
            descripstring = (FormatDic[descripCB.SelectedItem.ToString()] + " " + compareCBstring  + " " + specificCB.SelectedItem.ToString());
            Item temp = RuleListLB.SelectedItem as Item;
            temp.descriptor.Add(descripstring);
            foreach (string element in temp.descriptor)
            {
                descripLB.Items.Add(element);
            }
            descripstring = "";
        }

        private void descripCB_SelectedIndexChanged(object sender, EventArgs e)
            //Selection for descrip LB changed
            //Fills the specificCB
            //Show/Hide the comparator CB
        {
            compareCB.Hide();
            compareCBstring = "";
            descrip = this.descripCB.Text;
            specificCB.Items.Clear();
            foreach (string element in DescripDic[descrip])
            {
                specificCB.Items.Add(element);
            }
            if(descripCB.SelectedItem.ToString() == "Class" || descripCB.SelectedItem.ToString() == "Socket Group")
            {

            }
            else
            {
                compareCB.Show();
                compareCBstring = "";
                compareCB.SelectedIndex = 0;
            }

        }

        private void compareCB_SelectedIndexChanged(object sender, EventArgs e)
            //selection for compareCB changed
        {
            compareCBstring = compareCB.SelectedItem.ToString();
        }

        private void RuleListLB_SelectedIndexChanged(object sender, EventArgs e)
            //Things that happen when you change Rulelist LB
            //Im getting an error when I initially click null 
        {
            descripLB.Items.Clear();
            actionLB.Items.Clear();
            if (RuleListLB.SelectedItem != null)
            {
                Item temp = RuleListLB.SelectedItem as Item;
                foreach (string element in temp.descriptor)
                {
                    descripLB.Items.Add(element);
                }
                foreach (string element in temp.action)
                {
                    actionLB.Items.Add(element);
                }
                descripCB.Enabled = true;
                compareCB.Enabled = true;
                specificCB.Enabled = true;
                actionCB.Enabled = true;
                addDescripButton.Enabled = true;
                addActionButton.Enabled = true;
            }
        }

        private void actionCB_SelectedIndexChanged(object sender, EventArgs e)
            //deals with showing/hiding things for the actionrule
        {
            actionColorButton.Hide();
            alertL.Hide();
            alertTB.Hide();
            alertTB.Clear();
            volumeL.Hide();
            volumeTB.Hide();
            volumeTB.Clear();
            sizeL.Hide();
            sizeTB.Hide();
            sizeTB.Clear();
            actionRed = "";
            actionBlue = "";
            actionGreen = "";
            

            if (actionCB.SelectedItem.ToString() == "Set Text Color" || actionCB.SelectedItem.ToString() == "Set Border Color" ||
                actionCB.SelectedItem.ToString() == "Set Background Color")
            {
                actionColorButton.Show();
            }
            else if (actionCB.SelectedItem.ToString() == "Play Alert Sound")
            {
                alertTB.Show();
                alertL.Show();
                volumeTB.Show();
                volumeL.Show();
            }
            else if (actionCB.SelectedItem.ToString() == "Set Font Size")
            {
                sizeL.Show();
                sizeTB.Show();
            }
        }

        private void actionColorButton_Click(object sender, EventArgs e)
            //Displays colordialog, records the user's input
        {
            actionCD.ShowDialog();
            actionBlue = actionCD.Color.B.ToString();
            actionGreen = actionCD.Color.G.ToString();
            actionRed = actionCD.Color.R.ToString();
        }

        private void addActionButton_Click(object sender, EventArgs e)
            //concatinates actionstring
            //casts selected item
            //adds to + refreshes actionLB
        {
            actionLB.Items.Clear();
            actionstring = FormatDic[actionCB.SelectedItem.ToString()] + " " + actionRed + alertTB.Text.ToString() + sizeTB.Text.ToString() + " " + actionGreen +
                volumeTB.Text.ToString() + " " + actionBlue;
            Item temp = RuleListLB.SelectedItem as Item;
            temp.action.Add(actionstring);
            foreach (string element in temp.action)
            {
                actionLB.Items.Add(element);
            }
            actionstring = "";
            
        }

        private void testButton_Click(object sender, EventArgs e)
            //concatinates all the descriptions, then all the actions
            //then puts it all together and shows it to the user in a messageBox
        {
            foreach (Item element in ruleList)
            {
                descripRule = descripRule + element.ConcatinateDescrip();
                actionRule = actionRule + element.ConcatinateAction();
                testList.Add("Show\n" + descripRule + actionRule);
                descripRule = "";
                actionRule = "";
            }
            foreach(string element in testList)
            {
                testString = testString + element;
            }
            MessageBox.Show(testString);
            testString = "";
            testList.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
            //going to be the button that actually saves the string
            //to the file
        {
            foreach (Item element in ruleList)
            {
                descripRule = descripRule + element.ConcatinateDescrip();
                actionRule = actionRule + element.ConcatinateAction();
                testList.Add("Show\n" + descripRule + actionRule);
                descripRule = "";
                actionRule = "";
            }
            foreach (string element in testList)
            {
                testString = testString + element;
            }
            WriteToFile.write(testString);
            testString = "";
            testList.Clear();
        }

        private void descripRemoveButton_Click(object sender, EventArgs e)
        {
            Item temp = RuleListLB.SelectedItem as Item;
            temp.descriptor.Remove(descripLB.SelectedItem.ToString());
            descripLB.Items.Remove(descripLB.SelectedItem);         
        }

        private void removeActionButton_Click(object sender, EventArgs e)
        {
            Item temp = RuleListLB.SelectedItem as Item;
            temp.descriptor.Remove(actionLB.SelectedItem.ToString());
            actionLB.Items.Remove(actionLB.SelectedItem);
        }

        private void ruleRemoveButton_Click(object sender, EventArgs e)
        {
            Item temp = RuleListLB.SelectedItem as Item;
            ruleList.Remove(temp);
            RuleListLB.Items.Remove(RuleListLB.SelectedItem);

        }
    }
}
