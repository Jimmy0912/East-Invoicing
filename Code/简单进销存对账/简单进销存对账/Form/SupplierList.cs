using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 简单进销存对账.DB;
using 简单进销存对账.Model;

namespace 简单进销存对账
{
    public partial class SupplierList : Form
    {
        public SupplierList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TbSupplier tbSupplier = new TbSupplier();
            tbSupplier.Name = "asfdafdadsa";
            tbSupplier.Contact = "";
            tbSupplier.Tel = "";
            tbSupplier.Address = "";

            ModSupplier modSupplier = new ModSupplier();
            DataTable dtSuppler = modSupplier.searchSupplier();

            dtSupperGroupView.Columns.Clear();
            dtSupperGroupView.Columns.Add("code", "供应商编号");
            dtSupperGroupView.Columns.Add("name" , "供应商名称");
            dtSupperGroupView.Columns.Add("contact", "联系人");
            dtSupperGroupView.Columns.Add("tel", "联系电话");
            dtSupperGroupView.Columns.Add("address", "联系地址");
            //dtSupperGroupView.DataSource = dtSuppler;

            foreach (DataRow supplerDat in dtSuppler.Rows)
            {
                var strCode = supplerDat["code"].ToString();
                var strName = supplerDat["name"].ToString();
                var strContact = supplerDat["contact"].ToString();
                var strTel = supplerDat["tel"].ToString();
                var strAddress = supplerDat["address"].ToString();

                dtSupperGroupView.Rows.Add(strCode, strName, strContact, strTel, strAddress);
            }
            Console.WriteLine("asdf");
        }

        private void dtSupperGroupView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
