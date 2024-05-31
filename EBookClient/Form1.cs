using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут будуть зберігатись ваші книги які ви читаєте та пропоновані", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут книги будуть сортуватись за категоріями", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNewRelises_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут будуть нові релізи книг", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPopular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут популярні книги", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
