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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateAvailableDisplay();
            UpdateBookingsDisplay();
        }

        private List<Equipment> _equipmentList = new List<Equipment>
        {
            new Equipment("Экскаватор", "CAT", 3),
            new Equipment("Кран", "Liebherr", 2),
            new Equipment("Бульдозер", "Komatsu", 5)
        };

        private List<Booking> _bookingsList = new List<Booking>();

        private void UpdateAvailableDisplay()
        {
            listBoxAvailable.DataSource = null;
            listBoxAvailable.DataSource = _equipmentList.Where(x => x.AvailableCount > 0).ToList();
        }

        private void UpdateBookingsDisplay()
        {
            listBoxBookings.DataSource = null;
            listBoxBookings.DataSource = _bookingsList;
        }

        private void listBoxAvailable_Click(object sender, EventArgs e)
        {
            if (listBoxAvailable.SelectedItem is Equipment selectedEq)
            {
                using (BookingForm f2 = new BookingForm())
                {
                    if (f2.ShowDialog() == DialogResult.OK)
                    {
                        selectedEq.AvailableCount--;

                        Booking newBooking = new Booking
                        {
                            Eq = selectedEq,
                            ForemanName = f2.ForemanName,
                            DateFrom = f2.DateFrom,
                            DateTo = f2.DateTo
                        };

                        _bookingsList.Add(newBooking);

                        UpdateAvailableDisplay();
                        UpdateBookingsDisplay();
                    }
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            _bookingsList = _bookingsList.Where(b => b.DateTo.Date <= DateTime.Today).ToList();

            foreach (var booking in _bookingsList)
            {
                booking.Eq.AvailableCount++;
            }

            UpdateBookingsDisplay();
            UpdateAvailableDisplay();

            MessageBox.Show("Проверка выполнена. Просроченная техника возвращена на базу.");
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {

        }
    }
}
