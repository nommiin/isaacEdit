using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    isaacEdit, by Nommiin
    ----------------------
    Feel free to modify, just please give credit. Thanks!
    Also, this was my first C# program, so sorry if it's bad/messy! I'll be better at this thing soon.
 */

namespace isaacEdit {
    public partial class isaacEditForm : Form {
        List<string> itemData = new List<string>();
        String filePath = "";

        public isaacEditForm() {
            InitializeComponent();
        }

        private void isaacEditForm_Load(object sender, EventArgs e) {
            //itemType.Items.Add("active");
            //itemType.Items.Add("passive");
            //itemType.Items.Add("familiar");
            System.Windows.Forms.ToolTip toolTips = new System.Windows.Forms.ToolTip();
            toolTips.SetToolTip(itemCache, "(Unknown)");
            toolTips.SetToolTip(itemID, "The ID that is used by the game engine to identify each item.");
            toolTips.SetToolTip(itemType, "The type of item.");
            toolTips.SetToolTip(itemName, "The name of the item shown upon picking it up and in the stats menu.");
            toolTips.SetToolTip(itemDescription, "The text that displays upon picking up the item and in the stats menu.");
            toolTips.SetToolTip(itemSprite, "The name of the .png image used for the item (Format: resources/gfx/<value>)");
            toolTips.SetToolTip(itemDevil, "The amount of health required to pickup the item in a deal with the devil. (If this value is 2, then it will require 1 whole heart to buy)");
            toolTips.SetToolTip(itemAchievement, "The ID of the achievement that is needed to unlock the item.");
            toolTips.SetToolTip(itemCharges, "The amount of charges required to use the item.");
            toolTips.SetToolTip(itemCooldown, "The amount of frames until the item recharges (If this value is 60, then it will recharge in 1 second)");
            toolTips.SetToolTip(itemCoins, "The amount of coins given upon picking up.");
            toolTips.SetToolTip(itemBombs, "The amount of bombs given upon picking up.");
            toolTips.SetToolTip(itemKeys, "The amount of keys given upon picking up.");
            toolTips.SetToolTip(itemHearts, "The amount of half red-hearts given upon picking up. If this value is 2, then 1 whole red-heart fills the next available heart container.");
            toolTips.SetToolTip(itemMaxHearts, "The amount of half heart containers given upon picking up. If this value is 2, then 1 whole heart cointainer is rewarded.");
            toolTips.SetToolTip(itemBlackHearts, "The amount of half black-hearts given upon picking up. If this value is 2, then 1 whole black-heart is rewarded.");
            toolTips.SetToolTip(itemBlackHearts, "The amount of half soul-hearts given upon picking up. If this value is 2, then 1 whole soul-heart is rewarded.");
        }

        public void setTextbox(string itemData, System.Windows.Forms.TextBox itemName) {
            if (itemData != null) {
                itemName.Text = itemData;
                itemName.Enabled = true;
            } else {
                itemName.Text = "";
                itemName.Enabled = false;
            }
        }

        public void setCombo(string itemData, System.Windows.Forms.ComboBox itemName) {
            if (itemData != null) {
                itemName.Text = itemData;
                itemName.Enabled = true;
            } else {
                itemName.Text = "";
                itemName.Enabled = false;
            }
        }

        public void setNumeric(string itemData, System.Windows.Forms.NumericUpDown itemName) {
            if (itemData != null) {
                itemName.Value = Int32.Parse(itemData);
                itemName.Enabled = true;
            } else {
                itemName.Value = 0;
                itemName.Enabled = false;
            }
        }

        public void storeTextbox(int i, System.Windows.Forms.TextBox itemName) {
            if (itemData[i] != null) {
                itemData[i] = itemName.Text;
            }
        }

        public void storeNumeric(int i, System.Windows.Forms.NumericUpDown itemName) {
            if (itemData[i] != null) {
                itemData[i] = itemName.Value.ToString();
            }
        }

        public void storeCombo(int i, System.Windows.Forms.ComboBox itemName) {
            if (itemData[i] != null) {
                itemData[i] = itemName.Text;
            }
        }

        public static XmlNode RenameNode(XmlNode node, string qualifiedName) {
            //if (node.NodeType == XmlNodeType.Element) {
                XmlElement oldElement = (XmlElement)node;
                XmlElement newElement = node.OwnerDocument.CreateElement(qualifiedName);
                while (oldElement.HasAttributes) {
                    newElement.SetAttributeNode(oldElement.RemoveAttributeNode(oldElement.Attributes[0]));
                }
                while (oldElement.HasChildNodes) {
                    newElement.AppendChild(oldElement.FirstChild);
                }
                if (oldElement.ParentNode != null) {
                    oldElement.ParentNode.ReplaceChild(newElement, oldElement);
                }
                return newElement;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult itemOpenResult = itemOpen.ShowDialog();
            if (itemOpenResult == DialogResult.OK) {
                if (itemOpen.CheckFileExists == true) {
                    filePath = itemOpen.FileName;
                    itemData.Clear();
                    itemList.Items.Clear();
                    XmlTextReader xmlReader = new XmlTextReader(itemOpen.FileName);
                    int maxSize = 0;
                    while (xmlReader.Read()) {
                        if (xmlReader.NodeType == XmlNodeType.Element) {
                            if (xmlReader.Name != "trinket") {
                                String attributeGet = xmlReader.GetAttribute("name");
                                if (attributeGet != null) {
                                    maxSize++;
                                    itemList.Items.Add(attributeGet);
                                    itemData.Add(xmlReader.GetAttribute("name"));
                                    itemData.Add(xmlReader.GetAttribute("description"));
                                    itemData.Add(xmlReader.GetAttribute("cache"));
                                    itemData.Add(xmlReader.GetAttribute("gfx"));
                                    itemData.Add(xmlReader.GetAttribute("id"));
                                    itemData.Add(xmlReader.GetAttribute("achievement"));
                                    itemData.Add(xmlReader.GetAttribute("maxcharges"));
                                    itemData.Add(xmlReader.GetAttribute("cooldown"));
                                    itemData.Add(xmlReader.GetAttribute("special"));
                                    itemData.Add(xmlReader.GetAttribute("devilprice"));
                                    itemData.Add(xmlReader.GetAttribute("coins"));
                                    itemData.Add(xmlReader.GetAttribute("bombs"));
                                    itemData.Add(xmlReader.GetAttribute("keys"));
                                    itemData.Add(xmlReader.GetAttribute("hearts"));
                                    itemData.Add(xmlReader.GetAttribute("maxhearts"));
                                    itemData.Add(xmlReader.GetAttribute("blackhearts"));
                                    itemData.Add(xmlReader.GetAttribute("soulhearts"));
                                    itemData.Add(xmlReader.Name);
                                }
                            }
                        }
                    }

                    xmlReader.Close();
                    itemID.Maximum = maxSize + 8;
                    if (maxSize > 0) {
                        buttonStore.Enabled = true;
                    }
                    itemList.Sorted = true;
                    itemList.Sorted = false;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (filePath != "") {
                File.SetAttributes(filePath, FileAttributes.Normal);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);
                XmlNode xmlNode = xmlDoc.DocumentElement;
                for(var n = 0; n < xmlNode.ChildNodes.Count; n++) {
                    var nodeRead = xmlNode.ChildNodes[n];
                    if (nodeRead.Name != "trinket") {
                        int itemFindID = -1;
                        foreach (XmlNode nodeReadChild in nodeRead.Attributes) {
                            if (nodeReadChild.Name == "id") {
                                for (var i = 0; i < itemData.Count; i += 18) {
                                    if (itemData[i + 4] == nodeReadChild.InnerText) {
                                        itemFindID = i;
                                        break;
                                    }
                                }
                            }
                        }

                        if (itemFindID != -1) {
                            RenameNode(nodeRead, itemData[itemFindID + 17]);
                            foreach (XmlNode nodeReadChild in nodeRead.Attributes) {
                                switch (nodeReadChild.Name) {
                                    case "name":
                                        nodeReadChild.InnerText = itemData[itemFindID];
                                        break;
                                    case "description":
                                        nodeReadChild.InnerText = itemData[itemFindID + 1];
                                        break;
                                    case "cache":
                                        nodeReadChild.InnerText = itemData[itemFindID + 2];
                                        break;
                                    case "gfx":
                                        nodeReadChild.InnerText = itemData[itemFindID + 3];
                                        break;
                                    case "id":
                                        nodeReadChild.InnerText = itemData[itemFindID + 4];
                                        break;
                                    case "achievement":
                                        nodeReadChild.InnerText = itemData[itemFindID + 5];
                                        break;
                                    case "maxcharges":
                                        nodeReadChild.InnerText = itemData[itemFindID + 6];
                                        break;
                                    case "cooldown":
                                        nodeReadChild.InnerText = itemData[itemFindID + 7];
                                        break;
                                    case "special":
                                        //nodeReadChild.InnerText = itemData[itemID + 8];
                                        break;
                                    case "devilprice":
                                        nodeReadChild.InnerText = itemData[itemFindID + 9];
                                        break;
                                    case "coins":
                                        nodeReadChild.InnerText = itemData[itemFindID + 10];
                                        break;
                                    case "bombs":
                                        nodeReadChild.InnerText = itemData[itemFindID + 11];
                                        break;
                                    case "keys":
                                        nodeReadChild.InnerText = itemData[itemFindID + 12];
                                        break;
                                    case "hearts":
                                        nodeReadChild.InnerText = itemData[itemFindID + 13];
                                        break;
                                    case "maxhearts":
                                        nodeReadChild.InnerText = itemData[itemFindID + 14];
                                        break;
                                    case "blackhearts":
                                        nodeReadChild.InnerText = itemData[itemFindID + 15];
                                        break;
                                    case "soulhearts":
                                        nodeReadChild.InnerText = itemData[itemFindID + 16];
                                        break;
                                }
                            }
                        }
                    }
                }
                xmlDoc.Save(filePath);
            }
        }

        private void itemList_SelectedIndexChanged(object sender, EventArgs e) {
            if (itemList.SelectedItem != null) {
                String itemGetName = itemList.GetItemText(itemList.SelectedItem);
                for (int i = 0; i < itemData.Count; i += 18) {
                    if (itemData[i] == itemGetName) {
                        setTextbox(itemData[i], itemName);
                        setTextbox(itemData[i + 1], itemDescription);
                        setTextbox(itemData[i + 2], itemCache);
                        setTextbox(itemData[i + 3], itemSprite);
                        itemID.Value = Int32.Parse(itemData[i + 4]);
                        setNumeric(itemData[i + 5], itemAchievement);
                        setNumeric(itemData[i + 6], itemCharges);
                        setNumeric(itemData[i + 7], itemCooldown);
                        setNumeric(itemData[i + 9], itemDevil);
                        setNumeric(itemData[i + 10], itemCoins);
                        setNumeric(itemData[i + 11], itemBombs);
                        setNumeric(itemData[i + 12], itemKeys);
                        setNumeric(itemData[i + 13], itemHearts);
                        setNumeric(itemData[i + 14], itemMaxHearts);
                        setNumeric(itemData[i + 15], itemBlackHearts);
                        setNumeric(itemData[i + 16], itemSoulHearts);
                        setCombo(itemData[i + 17], itemType);
                        break;
                    }
                }
            }
        }

        private void buttonStore_Click(object sender, EventArgs e) {
            if (itemList.SelectedIndex != -1) {
                String itemGetName = itemList.GetItemText(itemList.SelectedItem);
                var itemFindPos = -1;
                for (int i = 0; i < itemData.Count; i += 18) {
                    if (itemData[i] == itemGetName) {
                        storeTextbox(i, itemName);
                        storeTextbox(i + 1, itemDescription);
                        storeTextbox(i + 2, itemCache);
                        storeTextbox(i + 3, itemSprite);
                        storeNumeric(i + 4, itemID);
                        storeNumeric(i + 5, itemAchievement);
                        storeNumeric(i + 6, itemCharges);
                        storeNumeric(i + 7, itemCooldown);
                        //setTextbox(i + 8, itemSpecial);
                        storeNumeric(i + 9, itemDevil);
                        storeNumeric(i + 10, itemCoins);
                        storeNumeric(i + 11, itemBombs);
                        storeNumeric(i + 12, itemKeys);
                        storeNumeric(i + 13, itemHearts);
                        storeNumeric(i + 14, itemMaxHearts);
                        storeNumeric(i + 15, itemBlackHearts);
                        storeNumeric(i + 16, itemSoulHearts);
                        storeCombo(i + 17, itemType);
                        itemFindPos = i;
                        break;
                    }
                }

                var itemPos = itemList.SelectedIndex;
                itemList.Items.RemoveAt(itemPos);
                itemList.Items.Insert(itemPos, itemData[itemFindPos]);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("issacEdit was developed by Nommiin - v0.4\nIcon drawn by Stewartisme");
        }
    }
}