using DemoCenter.Maui.ViewModels;
using DevExpress.Maui.Scheduler;
using Microsoft.Maui.Controls;

namespace DemoCenter.Maui.Views {
    public partial class ReceptionDesk : ContentPage {
        bool inNavigation = false;

        public ReceptionDesk() {
            InitializeComponent();
            BindingContext = new ReceptionDeskDemoViewModel();
        }

        async void WorkWeekView_OnTap(object sender, SchedulerGestureEventArgs e) {
            if (inNavigation)
                return;
            Page appointmentPage = storage.CreateAppointmentPageOnTap(e, true);
            if (appointmentPage != null) {
                inNavigation = true;
                await Navigation.PushAsync(appointmentPage);
            }
        }
        protected override void OnAppearing() {
            base.OnAppearing();
            inNavigation = false;
        }
    }
}
