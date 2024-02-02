using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace EzCheckme
{
    public partial class History : ContentPage
    {
        public ObservableCollection<AttendanceRecordViewModel> WeeklyAttendance { get; set; }

        public History()
        {
            InitializeComponent();

            WeeklyAttendance = new ObservableCollection<AttendanceRecordViewModel>();
            LoadWeeklyAttendance();

            // Bind the ObservableCollection to the ListView or any other UI element
            // For example, you can display the weekly attendance in a ListView in the History.xaml
            // historyListView.ItemsSource = WeeklyAttendance;
        }

        private void LoadWeeklyAttendance()
        {
            // Load weekly attendance records (dummy data for demonstration)
            DateTime currentDate = DateTime.Now;
            for (int i = 6; i >= 0; i--)
            {
                DateTime attendanceDate = currentDate.AddDays(-i);
                WeeklyAttendance.Add(new AttendanceRecordViewModel { Date = attendanceDate.ToString("yyyy-MM-dd"), AttendanceStatus = "Present" });
            }
        }
    }

    public class AttendanceRecordViewModel
    {
        public string Date { get; set; }
        public string AttendanceStatus { get; set; }
    }
}
