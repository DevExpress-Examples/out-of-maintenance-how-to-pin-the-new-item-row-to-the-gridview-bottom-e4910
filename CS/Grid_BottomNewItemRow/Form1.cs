using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grid_BottomNewItemRow
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Fields...
        DataTable _TestTable;
        
        private void CreateTestTable()
        {
            _TestTable = new DataTable("TestTable");
            CreateTableColumns();
            CreateCustomerRow(0, "Test0",0);
            CreateCustomerRow(1, "Test1",1);
            CreateCustomerRow(2, "Test2",2);
            CreateCustomerRow(3, "Test3",3);
            CreateCustomerRow(4, "Test4",4);
            CreateCustomerRow(5, "Test5",5);
            CreateCustomerRow(6, "Test6",6);
            CreateCustomerRow(7, "Test7",7);
            CreateCustomerRow(8, "Test8",8);
            CreateCustomerRow(9, "Test9",9);
            CreateCustomerRow(10, "Test10",10);
            CreateCustomerRow(11, "Test11",11);
            CreateCustomerRow(12, "Test12",12);
            CreateCustomerRow(13, "Test13",13);
            CreateCustomerRow(14, "Test14",14);
            CreateCustomerRow(15, "Test15",15);
            CreateCustomerRow(16, "Test16",16);
            CreateCustomerRow(17, "Test17",17);
            CreateCustomerRow(18, "Test18",18);

        }

        private void CreateTableColumns()
        {
            DataColumn[] columns = new DataColumn[3]
            {
                new DataColumn("ID",typeof(int)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Number", typeof(int))
            };

            _TestTable.Columns.AddRange(columns);

        }

        private void CreateCustomerRow(int id, string name, int number)
        {
            DataRow row = _TestTable.NewRow();

            row["ID"] = id;
            row["Name"] = name;
            row["Number"] = number;

            _TestTable.Rows.Add(row);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTestTable();
            
            gridSplitContainerDescendant1.Grid.DataSource = _TestTable;

            BottomNewItemRowEx ex = new BottomNewItemRowEx(gridSplitContainerDescendant1);
     
        }
          
     }
}
