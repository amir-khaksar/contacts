using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactsDataSet.Contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.contactsDataSet.Contacts);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            contactsTableAdapter.InsertQuery(name.Text, phone.Text);
            this.contactsTableAdapter.Fill(this.contactsDataSet.Contacts);
            name.Text = "";
            phone.Text = "";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(search.Text == "")
                this.contactsTableAdapter.Fill(this.contactsDataSet.Contacts);
            else 
                this.contactsTableAdapter.FillBy(this.contactsDataSet.Contacts, search.Text);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            contactsTableAdapter.DeleteQuery(remove.Text);
            this.contactsTableAdapter.Fill(this.contactsDataSet.Contacts);
            remove.Text = "";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            contactsTableAdapter.UpdateQuery(nextName.Text, nextPhone.Text, prevName.Text);
            this.contactsTableAdapter.Fill(this.contactsDataSet.Contacts);
            prevName.Text = "";
            nextName.Text = "";
            nextPhone.Text = "";
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
