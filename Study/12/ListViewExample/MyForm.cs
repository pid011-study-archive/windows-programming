using System;
using System.Windows.Forms;

namespace ListViewExample
{
    public partial class MyForm : Form
    {
        private struct City
        {
            public string Name;
            public int Area;
            public int Population;

            public City(string name, int area, int population)
            {
                Name = name;
                Area = area;
                Population = population;
            }
        }

        private readonly City[] _cities =
        {
            new City("서울", 605, 1026),
            new City("부산", 758, 381),
            new City("용인", 591, 583),
            new City("춘천", 1116, 25),
            new City("홍천", 1817, 7)
        };

        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            foreach (var city in _cities)
            {
                string[] data = { city.Name, city.Area.ToString(), city.Population.ToString() };
                listView2.Items.Add(new ListViewItem(data));
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                return;
            }

            Text = listView2.SelectedItems[0].Text;
        }

        private void listView2_ItemActivate(object sender, EventArgs e)
        {
            MessageBox.Show(listView2.SelectedItems[0].Text);
        }
    }
}
