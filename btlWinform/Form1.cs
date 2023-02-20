using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

//Họ tên: Nguyễn Quang Huy
//Lớp: 62TH2
//MSV: 2051063734

namespace btlWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //General code
        connection connect = new connection();
        private void Form1_Load(object sender, EventArgs e)
        {
            connect.myOpen();
            LoadCCB();
            LoadData();
            dgtProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtProduct.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgtProduct.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgtProduct.Columns[2].HeaderText = "Giá Sản Phẩm(VND)";
            dgtProduct.Columns[3].HeaderText = "Thương hiệu";
            dgtProduct.Columns[4].HeaderText = "Số lượng";
            dgtProduct.Columns[5].HeaderText = "Giảm giá(%)";
            dgtProduct.Columns[0].Width = 70;
            dgtProduct.Columns[2].Width = 70;
            dgtProduct.Columns[3].Width = 70;
            dgtProduct.Columns[4].Width = 70;
            dgtProduct.Columns[5].Width = 70;
            dgtProduct.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgtProduct.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgtProduct.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            LoadBill();
            dgtProduct.RowHeadersVisible = false;
            dgtProduct2.RowHeadersVisible = false;
            dgtBill.RowHeadersVisible = false;
            dgtStatis.RowHeadersVisible = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn kết thúc phiên làm việc không?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                connect.myClose();
                this.Close();
            }
        }
        public Boolean checkInput(GroupBox name)
        {
            foreach (Control c in name.Controls)
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox))
                {
                    if (c.Text.Trim() == "")
                        return false;
                }
            }
            return true;
        }
        public void returnInput(Control name)
        {
            foreach (Control c in name.Controls)
            {
                if (c.Text.Trim() == "" && c.TabStop == true)
                {
                    MessageBox.Show("Hãy nhập đữ liệu của " + c.Tag, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    c.Focus();
                    break;
                }
            }
        }
        //Product Management Code
        private void txtCodePro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số\nKhông được nhập số âm!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LoadData()
        {
            string sql = "Select maSP,tenSP,giaSP,hangSP,soLuongCon,giamgia from SanPham";
            dgtProduct.DataSource = connect.createTable(sql);
        }
        public void LoadCCB()
        {
            string sql = "select hangSP from SanPham group by hangSP";
            cbbBrand.DataSource = connect.createTable(sql);
            cbbBrand.DisplayMember = "hangSP";
            cbbBrand.ValueMember = "hangSP";
            cbbBrand.ResetText();
            cbbStatis.DataSource = connect.createTable(sql);
            cbbStatis.DisplayMember = "hangSP";
            cbbStatis.ValueMember = "hangSP";
            cbbStatis.ResetText();
            string sqlStatis = "select maHD from HoaDon";
            cbbStatisCode.DataSource = connect.createTable(sqlStatis);
            cbbStatisCode.DisplayMember = "maHD";
            cbbStatisCode.ValueMember = "maHD";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc thêm không", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string s = "select maSP from SanPham where maSP='" + txtCodePro.Text.Trim() + "'";
                DataTable dt = new DataTable();
                dt = connect.createTable(s);
                if (dt.Rows.Count == 0)
                {
                    try
                    {
                        if (checkInput(grbProduct) == false)
                        {
                            throw new Myexception();
                        }
                        connect.AddProduct(txtCodePro.Text.Trim(), txtNamePro.Text.Trim(), Convert.ToDouble(txtPrice.Text.Trim()), cbbBrand.Text.Trim(), Convert.ToInt32(nudCount.Value), Convert.ToInt32(nudSale.Value));
                    }
                    catch (Myexception)
                    {
                        //MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        returnInput(grbProduct);
                        return;
                    }
                    txtCodePro.ResetText();
                    txtNamePro.ResetText();
                    txtPrice.ResetText();
                    cbbBrand.ResetText();
                    nudCount.ResetText();
                    nudSale.ResetText();
                    txtCodePro.Focus();
                    LoadData();
                    LoadCCB();
                    LoadBill();
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại\nVui lòng nhập lại mã Sản phẩm!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodePro.Clear();
                    txtCodePro.Focus();
                }
            }
        }
        private void dgtProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = e.RowIndex;
            if(num >= 0)
            {
                txtCodePro.Text = dgtProduct.Rows[num].Cells[0].Value.ToString();
                txtNamePro.Text = dgtProduct.Rows[num].Cells[1].Value.ToString();
                txtPrice.Text = dgtProduct.Rows[num].Cells[2].Value.ToString();
                cbbBrand.Text = dgtProduct.Rows[num].Cells[3].Value.ToString();
                nudCount.Value = Convert.ToDecimal(dgtProduct.Rows[num].Cells[4].Value);
                nudSale.Value = Convert.ToDecimal(dgtProduct.Rows[num].Cells[5].Value);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc xóa không","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                string s = "select maSP from SanPham where maSP='" + txtCodePro.Text + "'";
                DataTable dt = new DataTable();
                dt = connect.createTable(s);
                if (dt.Rows.Count != 0)
                {
                    connect.DelProduct(txtCodePro.Text.Trim(), txtNamePro.Text.Trim(), Convert.ToDouble(txtPrice.Text.Trim()), cbbBrand.Text.Trim(), Convert.ToInt32(nudCount.Value), Convert.ToInt32(nudSale.Value));
                    txtCodePro.ResetText();
                    txtNamePro.ResetText();
                    txtPrice.ResetText();
                    cbbBrand.ResetText();
                    nudCount.ResetText();
                    nudSale.ResetText();
                    txtCodePro.Focus();
                    LoadData();
                    LoadCCB();
                    LoadBill();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm muốn xóa!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodePro.Focus();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc sửa không", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string s = "select maSP from SanPham where maSP='" + txtCodePro.Text + "'";
                DataTable dt = new DataTable();
                dt = connect.createTable(s);
                if (dt.Rows.Count != 0)
                {
                    try
                    {
                        if (!checkInput(grbProduct))
                            throw new Myexception();
                        connect.EditProduct(txtCodePro.Text.Trim(), txtNamePro.Text.Trim(), Convert.ToDouble(txtPrice.Text.Trim()), cbbBrand.Text.Trim(), Convert.ToInt32(nudCount.Value), Convert.ToInt32(nudSale.Value));
                    }
                    catch (Myexception)
                    {
                        returnInput(grbProduct);
                        return;
                    }
                    txtCodePro.ResetText();
                    txtNamePro.ResetText();
                    txtPrice.ResetText();
                    cbbBrand.ResetText();
                    nudCount.ResetText();
                    nudSale.ResetText();
                    txtCodePro.Focus();
                    LoadData();
                    LoadCCB();
                    LoadBill();
                }
                else
                {
                    MessageBox.Show("Sản phẩm muốn sửa không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodePro.Focus();
                }
            }    
        }

        private void btnFil_Click(object sender, EventArgs e)
        {
            string sql = "select maSP,tenSP,giaSP,hangSP,soLuongCon,giamgia from SanPham where hangSP='" + cbbBrand.Text.Trim() + "'";
            DataTable dt = new DataTable();
            dt = connect.createTable(sql);
            if(dt.Rows.Count != 0)
            {
                dgtProduct.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có thương hiệu bạn cần tìm!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadCCB();
            txtCodePro.Clear();
            txtNamePro.Clear();
            txtPrice.Clear();
            nudCount.ResetText();
            nudSale.ResetText();
        }
        // Create bill Code
        DataTable bill;
        DataTable product;
        DataTable codeProduct;
        double total = 0;
        int indexBill;
        int indexPro;
        private void txtNameCus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên khách hàng không có sô và ký tự đặc biệt", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Đây là ô Số điện thoại\nNhập số thôi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgtProduct2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexPro = e.RowIndex;
        }

        private void dgtBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexBill = e.RowIndex;
        }
        public void LoadBill()
        {
            string sql = "Select maSP,giaSP,hangSP,soLuongCon,giamGia from SanPham";
            product = connect.createTable(sql);
            dgtProduct2.DataSource = product;
            dgtProduct2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtProduct2.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgtProduct2.Columns[1].HeaderText = "Giá Sản Phẩm(VND)";
            dgtProduct2.Columns[2].HeaderText = "Thương hiệu";
            dgtProduct2.Columns[3].HeaderText = "Số lượng còn lại";
            dgtProduct2.Columns[4].HeaderText = "Giảm giá(%)";
            dgtProduct2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgtProduct2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgtProduct2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            bill = new DataTable();
            DataColumn col = bill.Columns.Add("Mã sản phẩm", typeof(string));
            col.AllowDBNull = false;
            col.Unique = true;
            bill.Columns.Add("Tên sản phẩm", typeof(string));
            bill.Columns.Add("Số lượng", typeof(Int32));
            dgtBill.DataSource = bill;
            dgtBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            int num = indexPro;
            if(num == -1)
            {
                MessageBox.Show("Chọn sản phẩm muốn thêm", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int temp = Convert.ToInt32(dgtProduct2.Rows[num].Cells[3].Value.ToString());
            DataRow row = bill.NewRow();
            row[0] = dgtProduct2.Rows[num].Cells[0].Value.ToString();
            row[1] = dgtProduct2.Rows[num].Cells[1].Value.ToString();
            row[2] = 1;
            try
            {
                bill.Rows.Add(row);
            }
            catch (Exception)
            {
                foreach(DataRow dr in bill.Rows)
                {
                    string s = dr[0].ToString();
                    if (product.Rows[num][0].ToString() == s)
                    {
                        if (temp <= 0)
                        {
                            return;
                        }  
                        int a = Convert.ToInt32(dr[2]);
                        a++;
                        dr[2] = a;
                        break;
                    }
                }
            }
            finally
            {
                if (temp>0)
                {
                    temp--;
                    dgtProduct2.Rows[num].Cells[3].Value = temp;
                }
                else
                {
                    MessageBox.Show("Không đủ số lượng hàng trong kho!","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            //dgtBill.DataSource = bill;
            this.btnDelOne.Enabled = true;
            this.btnDelAll.Enabled = true;
            this.btnClearBill.Enabled = true;
            double price = Convert.ToDouble(dgtProduct2.Rows[num].Cells[1].Value.ToString());
            int sale = Convert.ToInt32(dgtProduct2.Rows[num].Cells[4].Value.ToString());
            total =  total + price - (price * sale) / 100;
            txtTotal.Text = total.ToString();
        }
        private void btnDelOne_Click(object sender, EventArgs e)
        {
            int temp;
            int num = indexBill;
            try
            {
                temp = Convert.ToInt32(dgtBill.Rows[num].Cells[2].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn sản phẩm muốn xóa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string code = dgtBill.Rows[num].Cells[0].Value.ToString();
            foreach (DataRow dr in product.Rows)
            {
                string s = dr[0].ToString();
                if (dgtBill.Rows[num].Cells[0].Value.ToString() == s)
                {
                    int a = Convert.ToInt32(dr[3]);
                    a++;
                    dr[3] = a;
                    break;
                }
            }
            if (temp == 1)
            {
                bill.Rows.RemoveAt(num);
            }
            else
            {
                temp--;
                dgtBill.Rows[num].Cells[2].Value = temp;
            }
            if (bill.Rows.Count == 0)
            {
                this.btnDelOne.Enabled = false;
                this.btnDelAll.Enabled = false;
                this.btnClearBill.Enabled = false;
            }
            string sql = "select giaSP,giamGia from SanPham where maSP='" + code + "'";
            codeProduct = new DataTable();
            codeProduct = connect.createTable(sql);
            double price = Convert.ToDouble(codeProduct.Rows[0][0]);
            int sale = Convert.ToInt32(codeProduct.Rows[0][1]);
            total -= (price - ((price * sale) / 100));
            txtTotal.Text = total.ToString();
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            int num = indexBill;
            string code;
            try
            {
                code = dgtBill.Rows[num].Cells[0].Value.ToString();
            }catch (Exception)
            {
                MessageBox.Show("Chọn sản phẩm muốn xóa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int temp = Convert.ToInt32(dgtBill.Rows[num].Cells[2].Value);
            foreach (DataRow dr in product.Rows)
            {
                string s = dr[0].ToString();
                if (dgtBill.Rows[num].Cells[0].Value.ToString() == s)
                {
                    int a = Convert.ToInt32(dr[3]);
                    a+=temp;
                    dr[3] = a;
                    break;
                }
            }
            bill.Rows.RemoveAt(num);
            if (bill.Rows.Count == 0)
            {
                this.btnDelAll.Enabled = false;
                this.btnDelOne.Enabled = false;
                this.btnClearBill.Enabled = false;
            }
            string sql = "select giaSP,giamGia from SanPham where maSP='" + code + "'";
            codeProduct = new DataTable();
            codeProduct = connect.createTable(sql);
            double price = Convert.ToDouble(codeProduct.Rows[0][0]);
            int sale = Convert.ToInt32(codeProduct.Rows[0][1]);
            total -= (price - ((price * sale)/100)) * temp;
            txtTotal.Text = total.ToString();
        }
        public string createBillCode()
        {
            string code = "";
            Random rd = new Random();
            for(int i = 0; i < 4; i++)
            {
                code += rd.Next(9).ToString();
            }
            return code;
        }
        public Boolean CheckBillCode(string code)
        {
            string sql = "select maHD from HoaDon";
            DataTable codeBill = connect.createTable(sql);
            foreach (DataRow row in codeBill.Rows)
            {
                if (row[0].ToString() == code)
                {
                    code = createBillCode();
                    return false;
                }
            }
            return true;
        }
        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thông tin Hóa đơn không", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string code;
                do
                {
                    code = createBillCode();
                } while (!CheckBillCode(code));
                try
                {
                    if (bill.Rows.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn bất kỳ sản phẩm nào!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!checkInput(grbBill))
                    {
                        throw new Myexception();
                    }
                    if(txtPhone.Text.Trim().Length < 10)
                    {
                        MessageBox.Show("Số điện thoại phải đủ 10 chữ số");
                        return;
                    }
                    connect.AddBill(code, txtNameCus.Text.Trim(), txtPhone.Text.Trim(), total, dtpBill.Value);
                }
                catch (Myexception)
                {
                    returnInput(grbBill);
                    return;
                }
                foreach (DataRow row in bill.Rows)
                {
                    connect.AddBillDetail(code, row[0].ToString(), Convert.ToInt32(row[2]));
                    connect.EditBillSell(row[0].ToString(), Convert.ToInt32(row[2]));
                }
                foreach (DataRow row in product.Rows)
                {
                    connect.EditBill(row[0].ToString(), Convert.ToInt32(row[3]));
                }
                LoadData();
                LoadBill();
                LoadCCB();
                total = 0;
                txtTotal.Clear();
                txtNameCus.Clear();
                txtPhone.Clear();
                dtpBill.ResetText();
                bill.Rows.Clear();
                MessageBox.Show("Thêm hóa đơn mới thành công!\nMã Hóa đơn là: "+code,"", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearBill_Click(object sender, EventArgs e)
        {
            total = 0;
            txtTotal.Text = "0";
            bill.Rows.Clear();
            LoadBill();
            this.btnDelAll.Enabled = false;
            this.btnDelOne.Enabled = false;
            this.btnClearBill.Enabled = false;
        }
        //Statis Code
        DataTable statis;
        DataTable totalDate;
        double totalstatis = 0;

        public void LoadStatic(string sql)
        {
            statis = new DataTable();
            statis = connect.createTable(sql);
            dgtStatis.DataSource = statis;
            dgtStatis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnStatis_Click(object sender, EventArgs e)
        {
            grbStatis.ForeColor = Color.Red;
            grbStatis.Text = "Thống kê toàn bộ Hóa Đơn";
            dgtStatis.DataSource = null;
            totalstatis = 0;
            string sql = "select * from HoaDon";
            LoadStatic(sql);
            dgtStatis.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgtStatis.Columns[1].HeaderText = "Tên Khách hàng";
            dgtStatis.Columns[2].HeaderText = "Số điện thoại Khách hàng";
            dgtStatis.Columns[3].HeaderText = "Tổng tiền Hóa đơn(VND)";
            dgtStatis.Columns[4].HeaderText = "Ngày đặt hàng";
            dgtStatis.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgtStatis.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgtStatis.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            foreach(DataRow dr in statis.Rows)
            {
                double temp = Convert.ToDouble(dr["tongTien"]);
                totalstatis += temp;
            }
            txtTotalStatis.Text = totalstatis.ToString();
            txtStaticBrand.Visible = false;
            lblBrand.Visible = false;
        }
        private void btnStatisBrand_Click(object sender, EventArgs e)
        {
            grbStatis.ForeColor = Color.Red;
            grbStatis.Text = "Thống kê hãng:  " + cbbStatis.Text.Trim();
            dgtStatis.DataSource = null;
            totalstatis = 0;
            int count = 0;
            string sql = "select SP.maSP as 'Mã sản phẩm',tenSP as 'Tên sản phẩm',hangSP as 'Hãng sản phẩm',ngaymua as 'Ngày mua hàng',soLuongMua as 'Số Lượng Mua',maHD as 'Mã Hóa Đơn' from SanPham SP,(select HD.maHD,maSP,ngaymua,soLuongMua from HoaDon HD, ChiTietHD CHD where HD.maHD = CHD.maHD) SP1 where SP.maSP = SP1.maSP and hangSP = '" + cbbStatis.Text+"'";
            LoadStatic(sql);
            lblStatisTotal.Text = "Tổng Doanh thu của " + cbbStatis.Text;
            lblBrand.Visible = true;
            lblBrand.Text = "Tổng số lượng đã bán của " + cbbStatis.Text;
            txtStaticBrand.Visible = true;
            foreach (DataRow dr in statis.Rows)
            {
                string s = "select giaSP,giamGia from SanPham where maSP='" + dr[0].ToString() + "'";
                codeProduct = new DataTable();
                codeProduct = connect.createTable(s);
                double price = Convert.ToDouble(codeProduct.Rows[0][0]);
                int sale = Convert.ToInt32(codeProduct.Rows[0][1]);
                totalstatis += (price - ((price * sale)/100)) * Convert.ToInt32(dr[4]);
                count += Convert.ToInt32(dr[4]);
            }
            txtTotalStatis.Text = totalstatis.ToString();
            txtStaticBrand.Text = count.ToString();
        }

        private void btnStatisDate_Click(object sender, EventArgs e)
        {
            grbStatis.ForeColor = Color.Red;
            grbStatis.Text = "Thống kê trong ngày:  " + dtpStatis.Value.ToShortDateString();
            dgtStatis.DataSource = null;
            totalstatis = 0;
            string sql = "select SP.maSP as 'Mã sản phẩm',tenSP as 'Tên sản phẩm',hangSP as 'Hãng sản phẩm',ngaymua as 'Ngày mua hàng',soLuongMua as 'Số Lượng Mua',maHD as 'Mã Hóa Đơn' from SanPham SP,(select HD.maHD,maSP,ngaymua,soLuongMua from HoaDon HD, ChiTietHD CHD where HD.maHD = CHD.maHD) SP1 where SP.maSP = SP1.maSP and ngaymua = '" + dtpStatis.Value + "'";
            LoadStatic(sql);
            lblStatisTotal.Text = "Tổng Doanh thu trong ngày";
            string sql2 = "select HD.maHD, tongTien from HoaDon HD, (select maHD from SanPham SP,(select HD.maHD, maSP, ngaymua, soLuongMua from HoaDon HD, ChiTietHD CHD where HD.maHD = CHD.maHD) SP1 where SP.maSP = SP1.maSP and ngaymua = '" + dtpStatis.Value + "' group by maHD) HD1 where HD.maHD = HD1.maHD";
            totalDate = new DataTable();
            totalDate = connect.createTable(sql2);
            foreach(DataRow dr in totalDate.Rows)
            {
                totalstatis += Convert.ToDouble(dr[1]);
            }
            txtTotalStatis.Text = totalstatis.ToString();
            txtStaticBrand.Visible = false;
            lblBrand.Visible = false;
        }

        private void btnStatisCode_Click(object sender, EventArgs e)
        {
            grbStatis.ForeColor = Color.Red;
            dgtStatis.DataSource = null;
            totalstatis = 0;
            string s = "select maHD,tenKH,tongTien from HoaDon where maHD='"+cbbStatisCode.Text+"'";
            totalDate = new DataTable();
            totalDate = connect.createTable(s);
            string sql = "select SP.maSP as 'Mã sản phẩm',tenSP as 'Tên sản phẩm',giaSP as 'Giá sản phẩm',hangSP as 'Hãng',soLuongMua as 'Số Lượng' from SanPham SP,ChiTietHD CHD where SP.maSP=CHD.maSP and maHD = '" + cbbStatisCode.Text + "'";
            LoadStatic(sql);
            try
            {
                grbStatis.Text = "Thông tin hóa đơn: " + cbbStatisCode.Text + "   ---   Tên khách hàng: " + totalDate.Rows[0][1].ToString().Trim();
            }
            catch (Exception)
            {
                grbStatis.Text = "Không có thông tin Hóa Đơn";
                return;
            }
            lblStatisTotal.Text = "Tổng Doanh thu của Hóa Đơn";
            txtTotalStatis.Text = totalDate.Rows[0][2].ToString();
            txtStaticBrand.Visible = false;
            lblBrand.Visible = false;
        }

        private void btnStatisPro_Click(object sender, EventArgs e)
        {
            grbStatis.ForeColor = Color.Red;
            grbStatis.Text = "Thống kê các sản phẩm:";
            dgtStatis.DataSource = null;
            string sql = "select maSP as 'Mã sản phẩm',tenSP as 'Tên sản phẩm',hangSP as 'Hãng sản phẩm',slBan as 'Số lượng đã bán',giamGia as 'Khuyến mãi(%)' from SanPham";
            LoadStatic(sql);
            lblStatisTotal.Visible = false;
            txtTotalStatis.Visible = false;
            txtStaticBrand.Visible = false;
            lblBrand.Visible = false;
        }

        private void dgtProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
