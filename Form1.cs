using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

// column names ContactName,PhoneNumber,Email,ID

namespace Contact_Manager
{
    public partial class Contact_Manager : Form
    {
        public Contact_Manager()
        {
            InitializeComponent();
        }
        private void Contact_Manager_Load(object sender, EventArgs e)
        {
            ViewContacts();
            
        }
        public void ViewContacts()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=izofat\\SQLEXPRESS;Initial Catalog=Contacts;Integrated Security=True")) // add your database path
            {
                connection.Open();
                string query = "SELECT *FROM ContactInfo";
                ContactsInfo.Items.Clear();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader read = command.ExecuteReader();
                    while (read.Read())
                    {
                        ListViewItem add = new ListViewItem();
                        add.Text = read["ContactName"].ToString();
                        add.SubItems.Add(read["PhoneNumber"].ToString());
                        add.SubItems.Add(read["Email"].ToString());
                        ContactsInfo.Items.Add(add);
                    }
                }
                connection.Close();
            }
        }       
        int k = 0;
        private void AddContact()
        {
            k++;
            groupBoxAdd.Visible = true;
            if (k >= 2)
            {
                if (textBoxPhonenum.Text != "" && textBoxName.Text != "" && textBoxEmail.Text != "")
                {
                    if (textBoxPhonenum.Text.Any(char.IsLetter) == false && textBoxPhonenum.Text.Any(char.IsSymbol) == false) 
                    {
                        object maxid;
                        labelsuccess.Visible = false;
                        string name = textBoxName.Text.ToString();
                        string phonenumber = textBoxPhonenum.Text.ToString();
                        string email = textBoxEmail.Text.ToString();
                        using (SqlConnection connection = new SqlConnection("Data Source=izofat\\SQLEXPRESS;Initial Catalog=Contacts;Integrated Security=True")) // add your table name 
                        {
                            connection.Open();
                            string maxidpath = "SELECT MAX(ID) FROM ContactInfo";
                            using (SqlCommand maxidcmd = new SqlCommand(maxidpath, connection))
                            {
                                maxid = maxidcmd.ExecuteScalar();
                                if (maxid == DBNull.Value)
                                {
                                    maxid = 1;
                                }
                            }
                            string path = "INSERT INTO ContactInfo (ContactName,PhoneNumber,Email,ID) VALUES (@name ,  @phonenum , @email, @id )";

                            using (SqlCommand insert = new SqlCommand(path, connection))
                            {
                                insert.Parameters.AddWithValue("@name", name);
                                insert.Parameters.AddWithValue("phonenum", phonenumber);
                                insert.Parameters.AddWithValue("@email", email);
                                insert.Parameters.AddWithValue("@id", maxid.ToString());
                                insert.ExecuteNonQuery();
                            }
                            connection.Close();
                            textBoxEmail.Clear();
                            textBoxName.Clear();
                            textBoxPhonenum.Clear();
                            ViewContacts();
                        }
                        k = 0;
                        groupBoxAdd.Visible = false;
                        labelsuccess.Text = "Added successfully !";
                        labelsuccess.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Phone number can't include letters !");
                    }

                }
                else
                {
                    labelsuccess.Visible = true;
                    labelsuccess.Text = "Textboxes Can't be empty !";
                }
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            labelDelete.Visible = false;
            AddContact();
        }
        
        string selecteditem;
        object id;
        private void DeleteContact()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=izofat\\SQLEXPRESS;Initial Catalog=Contacts;Integrated Security=True"))
            {
                connection.Open();
                if (selecteditem != null)
                {
                    string path = "SELECT ID FROM ContactInfo where ContactName = @name";
                    using (SqlCommand cmd = new SqlCommand(path, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", selecteditem);
                        id = cmd.ExecuteScalar();
                        string delpath = "Delete FROM ContactInfo where ID =@id";
                        using (SqlCommand delcmd = new SqlCommand(delpath, connection))
                        {
                            delcmd.Parameters.AddWithValue("@id", id.ToString());
                            delcmd.ExecuteNonQuery();
                        }                                                 
                    }
                    ViewContacts();                        
                    labelDelete.Text = "Deleted successfully !";
                    
                }
                else
                {
                    MessageBox.Show("Please select a Contact to delete");
                }
                
                connection.Close();
            }
        }
        int m = 0;
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            m++;
            if (m == 1)
            {
                labelDelete.Visible = true;
                labelDelete.Text = "Click delete again after Double click contact name you wanna delete !";
            }
            else if (m == 2)
            {
                DeleteContact();
                m = 0;                
            }           
        }
        int u = 0;
        private void ContactsInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            u++;
            selecteditem = ContactsInfo.SelectedItems[0].SubItems[0].Text.ToString();
            textBoxName.Text = ContactsInfo.SelectedItems[0].SubItems[0].Text.ToString();
            textBoxPhonenum.Text = ContactsInfo.SelectedItems[0].SubItems[1].Text.ToString();
            textBoxEmail.Text = ContactsInfo.SelectedItems[0].SubItems[2].Text.ToString();
        }
        object strid;
        private void UpdateContact()
        {
            string updatedname = textBoxName.Text.ToString();
            string updatedphnum = textBoxPhonenum.Text.ToString();
            string updatedemail = textBoxEmail.Text.ToString();
            groupBoxAdd.Visible = true;
            if (updatedemail != "" && updatedname != "" && updatedphnum != "")
            {
                if (updatedphnum.Any(char.IsLetter) == false && updatedphnum.Any(char.IsSymbol) == false)
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=izofat\\SQLEXPRESS;Initial Catalog=Contacts;Integrated Security=True"))
                    {
                        connection.Open();
                        string pathfind = "SELECT ID FROM ContactInfo where ContactName = @name";
                        using (SqlCommand cmd = new SqlCommand(pathfind, connection))
                        {
                            cmd.Parameters.AddWithValue("@name", selecteditem);
                            strid = cmd.ExecuteScalar();
                        }
                        string path = "UPDATE ContactInfo set ContactName =@name , PhoneNumber = @phonenum , Email = @email  where ID = @id";
                        using (SqlCommand updatecmd = new SqlCommand(path, connection))
                        {

                            updatecmd.Parameters.AddWithValue("@name", updatedname);
                            updatecmd.Parameters.AddWithValue("@phonenum", updatedphnum);
                            updatecmd.Parameters.AddWithValue("@email", updatedemail);
                            updatecmd.Parameters.AddWithValue("@id", strid.ToString());
                            updatecmd.ExecuteNonQuery();
                            ViewContacts();
                        }
                        labelDelete.Text = "Updated successfully !";
                        textBoxEmail.Clear();
                        textBoxName.Clear();
                        textBoxPhonenum.Clear();
                        connection.Close();
                        groupBoxAdd.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Phonenumber Can't Include letter or symbol !");

                }
            }
            else
            {
                MessageBox.Show("Textboxes can't be empty !");
                groupBoxAdd.Visible = false;
            }
        }   
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = true;
            if (u >=1)
            {
                UpdateContact();                
            }                                       
        }
    }
}
