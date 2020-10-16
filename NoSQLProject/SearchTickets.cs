using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoSQLProject
{
    class SearchTickets
    {
        public SearchTickets(TextBox searchBox, ListView listViewTickets, ListView allTickets)
        {
            string[] searchBoxOptions = searchBox.Text.Split(' ');

            List<ListViewItem> items = new List<ListViewItem>();

            if (searchBoxOptions.Length >= 3)
            {
                if (searchBoxOptions[1] == "|")
                {
                    foreach (ListViewItem item in allTickets.Items)
                    {
                        for (int i = 0; i < searchBoxOptions.Length; i++)
                        {
                            if (i == 1) continue;

                            for (int j = 0; j < item.SubItems.Count; j++)
                                if (item.SubItems[j].Text.ToLower().Contains(searchBoxOptions[i].ToLower()))
                                {
                                    if (!items.Contains(item))
                                        items.Add(item);
                                    break;
                                }
                        }
                    }
                }
                else if (searchBoxOptions[1] == "&")
                {
                    foreach (ListViewItem item in allTickets.Items)
                    {
                        for (int i = 0; i < searchBoxOptions.Length; i++)
                        {
                            bool containsFirst = false;
                            if (i == 1) continue;

                            for (int j = 0; j < item.SubItems.Count; j++)
                            {
                                if (item.SubItems[j].Text.ToLower().Contains(searchBoxOptions[i].ToLower()))
                                {
                                    containsFirst = true;
                                }
                                else if (item.SubItems[j].Text.ToLower().Contains(searchBoxOptions[2].ToLower()))
                                {
                                    if (containsFirst)
                                    {
                                        if (!items.Contains(item))
                                            items.Add(item);
                                        break;

                                    }
                                }

                            }

                        }
                    }
                }
            }
            else
            {
                foreach (ListViewItem item in allTickets.Items)
                {
                    for (int j = 0; j < item.SubItems.Count; j++)
                        if (item.SubItems[j].Text.ToLower().Contains(searchBox.Text.ToLower()))
                        {
                            if (!items.Contains(item))
                                items.Add(item);
                            break;
                        }
                }
            }

            listViewTickets.Items.Clear();
            foreach (ListViewItem item in items)
                listViewTickets.Items.Add((ListViewItem)item.Clone());

        }
    }
}
