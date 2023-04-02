using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker
{
    public partial class EditOwnershipGroupsForm : Form
    {
        private EditTasksForm _editTasksForm;

        public EditOwnershipGroupsForm(EditTasksForm editTasksForm)
        {
            InitializeComponent();

            _editTasksForm = editTasksForm;

            lbOwnershipGroups.DataSource = _editTasksForm.ownershipGroups;
        }

        private void RefreshListBox()
        {
            lbOwnershipGroups.DataSource = null;
            lbOwnershipGroups.DataSource = _editTasksForm.ownershipGroups;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _editTasksForm.ownershipGroups.Add(tbName.Text);
            _editTasksForm.ownershipGroups.Sort();
            _editTasksForm.SaveOwnershipGroupsToFile();
            RefreshListBox();
            _editTasksForm.RefreshOwnershipGroupsComboBox();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (lbOwnershipGroups.SelectedIndex != -1)
            {
                _editTasksForm.ownershipGroups.RemoveAt(lbOwnershipGroups.SelectedIndex);
                _editTasksForm.ownershipGroups.Sort();
                _editTasksForm.SaveOwnershipGroupsToFile();
                RefreshListBox();
                _editTasksForm.RefreshOwnershipGroupsComboBox();
            }
        }
    }
}
