using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rating2011
{
    public partial class BookingForm : Form
    {

        public string ForemanName { get; private set; }
        public DateTime DateFrom { get; private set; }
        public DateTime DateTo { get; private set; }

        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today.AddDays(1);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtForeman.Text))
            {
                MessageBox.Show("Введите имя прораба!");
                return;
            }

            if (dtpTo.Value < dtpFrom.Value)
            {
                MessageBox.Show("Дата возврата не может быть раньше даты начала!");
                return;
            }

            ForemanName = txtForeman.Text;
            DateFrom = dtpFrom.Value;
            DateTo = dtpTo.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
