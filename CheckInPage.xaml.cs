using Microsoft.Maui.Controls;
using System;

namespace EzCheckme
{
    public partial class CheckInPage : ContentPage
    {
        private int totalCheckIns = 0;
        private int successfulCheckIns = 0;

        public CheckInPage()
        {
            InitializeComponent();
        }

        private void OnCheckInButtonClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string studentNumber = studentNumberEntry.Text;

            // For demonstration purposes, let's assume a successful check-in for any input
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(studentNumber))
            {
                totalCheckIns++;
                successfulCheckIns++;

                // Update the UI
                UpdateAttendancePercentage();
            }
            else
            {
                DisplayAlert("Error", "Please enter both username and student number.", "OK");
            }
        }

        private void UpdateAttendancePercentage()
        {
            if (totalCheckIns > 0)
            {
                double attendancePercentage = ((double)successfulCheckIns / totalCheckIns) * 100;
                attendancePercentageLabel.Text = $"Attendance: {attendancePercentage:F2}%";
            }
            else
            {
                attendancePercentageLabel.Text = "No check-ins recorded yet.";
            }
        }

        private void OnHistoryButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new History());
        }
    }
}
