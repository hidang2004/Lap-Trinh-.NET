namespace lab04_Su_sung_cong_cu_Treeview
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			treeView1.ImageList = imageIcons;

			TreeNode goc = treeView1.Nodes.Add("Ký Tự DB");
			goc.ImageIndex = 0;
			goc.SelectedImageIndex = 0;

			TreeNode nodeCong = goc.Nodes.Add("+");
			TreeNode nodeTru = goc.Nodes.Add("-");
			TreeNode nodeNhan = goc.Nodes.Add("*");
			TreeNode nodeChia = goc.Nodes.Add("/");

			nodeCong.ImageIndex = 3;
			nodeTru.ImageIndex = 3;
			nodeNhan.ImageIndex = 3;
			nodeChia.ImageIndex = 3;

			nodeCong.SelectedImageIndex = 4;
			nodeTru.SelectedImageIndex = 4;
			nodeNhan.SelectedImageIndex = 4;
			nodeChia.SelectedImageIndex = 4;

			TreeNode gockytu = treeView1.Nodes.Add("Ký Tự");
			gockytu.ImageIndex = 0;
			gockytu.SelectedImageIndex = 0;

			for(char c = 'A'; c <= 'Z'; c++)
			{
				TreeNode nodeKytu = gockytu.Nodes.Add(c.ToString());
				nodeKytu.ImageIndex = 3;
				nodeKytu.SelectedImageIndex = 4;
			}

			TreeNode gocdayso = treeView1.Nodes.Add("Dãy Số");
			gocdayso.ImageIndex = 0;
			gocdayso.SelectedImageIndex = 0;

			for (char c = '0'; c <= '9'; c++)
			{
				TreeNode nodeDayso = gocdayso.Nodes.Add(c.ToString());
				nodeDayso.ImageIndex = 3;
				nodeDayso.SelectedImageIndex = 4;
			}
		}
	}
}
