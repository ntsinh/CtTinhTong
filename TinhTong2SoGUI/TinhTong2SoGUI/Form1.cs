namespace TinhTong2SoGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int soThuNhat = Convert.ToInt32(txtSoThuNhat.Text);
            int soThuHai = Convert.ToInt32(txtSoThuHai.Text);
            int ketQua = soThuNhat + soThuHai;
            txtKetQua.Text = ketQua.ToString();

        }
    }
}