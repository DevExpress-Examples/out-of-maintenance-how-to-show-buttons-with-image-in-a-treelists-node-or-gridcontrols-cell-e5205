using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace GridSample
{
    public partial class Form1 : Form
    {
        List<Customer> list = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
            FillTable();

        }

        private void FillTable()
        {
            for (int i = 0; i < 10; i++)
            {
                Customer customer = new Customer();
                customer.Name = "John";
                customer.Age = 20 + i;
                customer.Weight = 100 - i;
                list.Add(customer);
            }
            treeList1.DataSource = list;
            gridControl1.DataSource = list;

            RepositoryItemButtonEdit edit = new RepositoryItemButtonEdit();
            edit.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            edit.Buttons[0].Image = imageCollection1.Images[0];
            edit.ButtonClick += edit_ButtonClick; 

            treeList1.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowAlways;
            gridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways; 

            treeList1.Columns["Age"].ColumnEdit = edit;
            gridView1.Columns["Age"].ColumnEdit = edit;
        }

        void edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog(); 
        }
    }
}
