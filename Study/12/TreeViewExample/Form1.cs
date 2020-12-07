using System.Windows.Forms;

namespace TreeViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            treeView2.Nodes.Add("대한민국");
            treeView2.Nodes[0].Nodes.Add("서울특별시");
            treeView2.Nodes[0].Nodes.Add("경기도");
            treeView2.Nodes[0].Nodes.Add("충청도");
            treeView2.Nodes[0].Nodes.Add("강원도");
            treeView2.Nodes[0].Nodes[0].Nodes.Add("강남구");
            treeView2.Nodes[0].Nodes[1].Nodes.Add("수원시");
            treeView2.Nodes[0].Nodes[1].Nodes.Add("여주시");
            treeView2.Nodes[0].Nodes[1].Nodes[1].Nodes.Add("홍문동");
        }
    }
}
