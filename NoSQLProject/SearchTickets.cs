using System.Collections.Generic;
using System.Windows.Forms;

namespace NoSQLProject
{
    class SearchTickets
    {
        private List<ListViewItem> items;
        private ListView listViewTickets;
        private ListView allTickets;
        public SearchTickets(TextBox searchBox, ListView listViewTickets, ListView allTickets) // I will add comments later
        {
            this.listViewTickets = listViewTickets;
            this.allTickets = allTickets;
            string[] searchBoxOptions = searchBox.Text.Split(' ');

            items = new List<ListViewItem>();

            if (searchBoxOptions.Length >= 3)
            {
                if (searchBoxOptions[1] == "|")
                {
                    foreach (ListViewItem item in allTickets.Items)
                    {
                        for (int i = 0; i < searchBoxOptions.Length; i++)
                        {
                            if (i == 1) continue;
                            CheckIfSubitemContainsText(item, searchBoxOptions[i]);
                        }
                    }
                }
                else if (searchBoxOptions[1] == "&")
                    CheckIfSubitemContainsBothFilters(searchBoxOptions);
            }
            else
            {
                foreach (ListViewItem item in allTickets.Items)
                    CheckIfSubitemContainsText(item, searchBox.Text);
            }

            FillTicketList();

        }
        private void CheckIfSubitemContainsText(ListViewItem item, string text)
        {

            for (int j = 0; j < item.SubItems.Count; j++)
                if (item.SubItems[j].Text.ToLower().Contains(text.ToLower()))
                {
                    if (!items.Contains(item))
                        items.Add(item);
                    break;
                }
        }
        private void FillTicketList()
        {
            listViewTickets.Items.Clear();
            foreach (ListViewItem item in items)
                listViewTickets.Items.Add((ListViewItem)item.Clone());
        }
        private void CheckIfSubitemContainsBothFilters(string[] searchBoxOptions)
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
                            containsFirst = true;
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
}
