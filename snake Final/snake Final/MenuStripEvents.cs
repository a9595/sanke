using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace snake
{
    public partial class Form1
    {
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAppleAndBombsSettings();
            NewGame(snakeSize: 5, applesCount: _applesCount, bombsCount: _bombsCount, lifesCount: 3);
        }
        /// <summary>
        /// makes the psevdo-radio-check-buttons in menuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsToRadioCheckedToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem; //get the object of clicked item 
            List<ToolStripMenuItem> otherItems = new List<ToolStripMenuItem>(); //list of all items in menu
            otherItems.Add(clickedItem); //add ckicked item (it must be first in list)
            foreach (var item in clickedItem.GetCurrentParent().Items)
            {
                if (!otherItems.Contains((ToolStripMenuItem)item)) //add unique items
                    otherItems.Add((ToolStripMenuItem)item); //after first item ,  there are other menuItems 
            }
            otherItems.First().Checked = true; //check clicked item as CHECKED
            for (int i = 1; i < otherItems.Count; i++) //uncheck other items
                otherItems[i].Checked = false;
        }
        void GetAppleAndBombsSettings()
        {
            var applesParent = Aplles5toolStripMenuItem2.GetCurrentParent();
            var bombsParent = Bombs5toolStripMenuItem5.GetCurrentParent();
            foreach (var item in applesParent.Items)
            {
                ToolStripMenuItem applesTmp = (ToolStripMenuItem)item;
                if (applesTmp.Checked)
                    _applesCount = Convert.ToInt32(applesTmp.Text);
            }
            foreach (var item in bombsParent.Items)
            {
                ToolStripMenuItem bombsTmp = (ToolStripMenuItem)item;
                if (bombsTmp.Checked)
                    _bombsCount = Convert.ToInt32(bombsTmp.Text);
            }

            //get lvl 
            if(amatureToolStripMenuItem.Checked)
                _currentLvl = Lvl.Amature;
            else if(likeAProToolStripMenuItem.Checked)
                _currentLvl = Lvl.LikeAPro;
            else _currentLvl = Lvl.Beginner;


            ApplesCountStatusLabel.Text = "0";
            BombsCountStatusLabel.Text = "0";
        }
    }
}
