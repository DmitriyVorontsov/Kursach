using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            foreach(DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Width = dataGridView1.Width / dataGridView1.Columns.Count;
            }
        }

        private void LftButton_Click(object sender, EventArgs e)
        {

        }
    }
}
