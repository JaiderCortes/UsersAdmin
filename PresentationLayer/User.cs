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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Thread.Sleep(1000);
                Cursor = Cursors.Default;
                usersPanel.Visible = true;
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
                    MessageBox.Show($"User created successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
