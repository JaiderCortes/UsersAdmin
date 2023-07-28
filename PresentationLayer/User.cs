using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersAdmin.DataLayer;
using UsersAdmin.LogicLayer;
using System.IO;
using System.Threading;

namespace UsersAdmin.PresentationLayer
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        int UserId;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Thread.Sleep(1000);
                Cursor = Cursors.Default;
                usersPanel.Visible = true;
                usersPanel.Dock = DockStyle.Fill;
                btnSave.Visible = true;
                btnSaveChg.Visible = false;
                txtUsername.Clear();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void icon_Click(object sender, EventArgs e)
        {
            try
            {
                dlg.InitialDirectory = "";
                dlg.Filter = "Imagenes|*.jpg; *.png; *.jpeg";
                dlg.FilterIndex = 2;
                dlg.Title = "Load Icon";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    icon.BackgroundImage = null;
                    icon.Image = new Bitmap(dlg.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Thread.Sleep(1000);
                Cursor = Cursors.Default;
                if (txtUsername.Text != "")
                {
                    if(txtPassword.Text != "")
                    {
                        InsertUser();
                        ShowUsers();
                    }
                    else
                    {
                        MessageBox.Show($"Please fill the Password field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"Please fill the Username field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void ShowUsers()
        {
            try
            {
                DataTable dt = new DataTable();
                dUsers du = new dUsers();
                dt = du.ShowUsers();
                usersList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertUser()
        {
            try
            {
                lUsers lu = new lUsers();
                dUsers du = new dUsers();
                lu.UserName = txtUsername.Text;
                lu.Password = txtPassword.Text;
                MemoryStream ms = new MemoryStream();
                icon.Image.Save(ms, icon.Image.RawFormat);
                lu.Icon = ms.GetBuffer();
                lu.Status = "Active";
                if (du.InsertUser(lu))
                {
                    MessageBox.Show($"User created successfully", "Insert confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usersPanel.Visible = false;
                    usersPanel.Dock = DockStyle.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUser()
        {
            try
            {
                lUsers lu = new lUsers();
                dUsers du = new dUsers();
                lu.UserId = UserId;
                lu.UserName = txtUsername.Text;
                lu.Password = txtPassword.Text;
                MemoryStream ms = new MemoryStream();
                icon.Image.Save(ms, icon.Image.RawFormat);
                lu.Icon = ms.GetBuffer();
                lu.Status = "Active";
                if (du.UpdateUser(lu))
                {
                    MessageBox.Show($"User updated successfully", "Update confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usersPanel.Visible = false;
                    usersPanel.Dock = DockStyle.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUser()
        {
            try
            {
                lUsers lu = new lUsers();
                dUsers du = new dUsers();
                lu.UserId = UserId;
                if (du.DeleteUser(lu))
                {
                    MessageBox.Show($"User deleted successfully", "Delete confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usersPanel.Visible = false;
                    usersPanel.Dock = DockStyle.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UserId = int.Parse(usersList.SelectedCells[2].Value.ToString());
                if (e.ColumnIndex == this.usersList.Columns["Delete"].Index)
                {
                    Cursor = Cursors.WaitCursor;
                    Thread.Sleep(1000);
                    Cursor = Cursors.Default;
                    DialogResult result;
                    result = MessageBox.Show("Are you sure you want to delete this user?", "Delete user confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(result == DialogResult.OK)
                    {
                        DeleteUser();
                        ShowUsers();
                    }
                }
                if (e.ColumnIndex == this.usersList.Columns["Update"].Index)
                {
                    Cursor = Cursors.WaitCursor;
                    Thread.Sleep(1000);
                    Cursor = Cursors.Default;
                    txtUsername.Text = usersList.SelectedCells[3].Value.ToString();
                    txtPassword.Text = usersList.SelectedCells[4].Value.ToString();
                    icon.BackgroundImage = null;
                    byte[] img = (Byte[])usersList.SelectedCells[5].Value;
                    MemoryStream ms = new MemoryStream(img);
                    icon.Image = Image.FromStream(ms);

                    usersPanel.Visible = true;
                    usersPanel.Dock = DockStyle.Fill;
                    btnSave.Visible = false;
                    btnSaveChg.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Thread.Sleep(1000);
                Cursor = Cursors.Default;
                usersPanel.Visible = false;
                usersPanel.Dock = DockStyle.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveChg_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateUser();
                ShowUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchUser()
        {
            try
            {
                DataTable dt;
                dUsers du = new dUsers();
                dt = du.SearchUsers(txtSearch.Text);
                usersList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
