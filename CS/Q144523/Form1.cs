using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace Q144523 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            foreach (Control c in Controls) {
                if (c.Tag != null && c.Tag is string) {
                    BaseEdit be = c as BaseEdit;
                    if (be == null) continue;
                    RepositoryItem ri = persistentRepository1.Items[(string)be.Tag];
                    if (ri != null) be.Properties.Assign(ri);
                }
            }
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.categoriesTableAdapter.Update(this.nwindDataSet.Categories);

        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
            // TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);

        }
    }
}