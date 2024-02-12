namespace A2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeValuesGroup(ListViewGroup item)
        {
            item.Header = groupHeader.Text;
            item.Subtitle = groupSubTitle.Text;
            item.Footer = groupFooter.Text;

            item.HeaderAlignment = groupHeaderAlign.Text switch
            {
                "Right" => HorizontalAlignment.Right,
                "Center" => HorizontalAlignment.Center,
                _ => HorizontalAlignment.Left,
            };

            item.FooterAlignment = groupFooterAlign.Text switch
            {
                "Right" => HorizontalAlignment.Right,
                "Center" => HorizontalAlignment.Center,
                _ => HorizontalAlignment.Left,
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = new ListViewGroup();

            ChangeValuesGroup(item);

            listView1.Groups.Add(item);
            groupItems.Items.Add(item);
            itemGroup.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = groupItems.SelectedItem as ListViewGroup;
            if (item != null && listView1.Groups.Contains(item))
            {
                listView1.Groups.Remove(item);
                groupItems.Items.Remove(item);
                itemGroup.Items.Remove(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var item = groupItems.SelectedItem as ListViewGroup;
            if (item != null && listView1.Groups.Contains(item))
            {
                ChangeValuesGroup(item);
                groupItems.Refresh();
                listView1.Refresh();
                itemGroup.Refresh();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var item = new ListViewItem();

            item.Group = itemGroup.SelectedItem as ListViewGroup;
            item.Text = itemText.Text;

            listView1.Items.Add(item);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                var item = listView1.SelectedItems[0];
                var subItem = new ListViewItem.ListViewSubItem();

                item.Text = subItemText.Text;
                item.SubItems.Add(subItem);

                listBox1.Items.Add(subItem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                var item = listView1.SelectedItems[0];
                var subItems = item.SubItems;
                listBox1.Items.Clear();

                foreach (var subItem in subItems)
                {
                    listBox1.Items.Add(subItem);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                var item = listView1.SelectedItems[0];
                listBox1.Items.Clear();
                listView1.Items.Remove(item);
            }
        }

        private void groupItems_SelectedValueChanged(object sender, EventArgs e)
        {
            var item = groupItems.SelectedItem as ListViewGroup;
            if (item != null)
            {
                groupHeader.Text = item.Header;
                groupFooter.Text = item.Footer;
                groupSubTitle.Text = item.Subtitle;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var subItem = listBox1.SelectedItem as ListViewItem.ListViewSubItem;
            if (subItem != null && listView1.SelectedItems.Count == 1)
            {
                var item = listView1.SelectedItems[0];
                listBox1.Items.Remove(subItem);
                subItemText.Text = "";
                item.SubItems.Remove(subItem);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var subItem = listBox1.SelectedItem as ListViewItem.ListViewSubItem;
            if (subItem != null)
            {
                subItemText.Text = subItem.Text;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Alignment = listViewAlignment.Text switch
            {
                "Default" => ListViewAlignment.Default,
                "Top" => ListViewAlignment.Top,
                "Left" => ListViewAlignment.Left,
                "SnapToGrid" => ListViewAlignment.SnapToGrid,
                _ => ListViewAlignment.Top
            };
        }
    }
}
