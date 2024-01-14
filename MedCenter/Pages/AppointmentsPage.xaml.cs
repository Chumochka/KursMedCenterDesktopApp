using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MedCenter.Models;
using Newtonsoft.Json;

namespace MedCenter.Pages
{
    public partial class AppointmentsPage : Page
    {
        Worker user = new Worker();
        List<Appointment> appointments = new List<Appointment>();
        fetchData request_client = new fetchData();
        public AppointmentsPage(Worker currentUser)
        {
            try
            {
                InitializeComponent();
                user = currentUser;
                if(user.id_role==1)
                    user.Specialization = JsonConvert.DeserializeObject<Specialization>(request_client.GetRequest("spec?id=" + user.id_specialization));
            }catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить данные о вашей специальности. Подробности: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
        public void UpdateData()
        {
            string search_string = tbSearch.Text.ToLower();
            var result = appointments.Where(a => a.patient_fullname.ToLower().Contains(search_string) || a.doctor_fullname.ToLower().Contains(search_string));
            switch (cmbFilter.SelectedIndex)
            {
                case 1: result = result.Where(a => a.date.HasValue).ToList(); break;
                case 2: result = result.Where(a => a.date is null).ToList(); break;
            }
            switch(cmbSorting.SelectedIndex)
            {
                case 1: result = result.OrderBy(a => a.patient_fullname).ToList(); break;
                case 2: result = result.OrderBy(a => a.doctor_fullname).ToList(); break;
                case 3: result = result.OrderBy(a => a.date).ToList(); break;
                case 4: result = result.OrderBy(a => a.cabinet).ToList(); break;
            }
            LViewAppointment.ItemsSource = result;
            txtResultAmount.Text = result.Count().ToString();
        }
        public void UpdateList()
        {
            try
            {
                appointments = JsonConvert.DeserializeObject<List<Appointment>>(request_client.GetRequest("appointmentsdoctor?id=" + user.id_worker));
                txtAllAmount.Text = appointments.Count().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось загрузить список записей на прием. Подробности: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(IsInitialized)
                UpdateData();
        }

        private void cmbSorting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsInitialized)
                UpdateData();
        }

        private void cmbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsInitialized)
                UpdateData();
        }

        private void btnAddAppointment_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddAppointmentPage(user, null));
        }

        private void btnEditAppointment_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var appointment = LViewAppointment.SelectedItem as Appointment;
                appointment.Patient = JsonConvert.DeserializeObject<Patient>(request_client.GetRequest("patient?id=" + appointment.id_patient));
                if (user.id_role == 1)
                    appointment.Doctor = user;
                else
                    appointment.Doctor = JsonConvert.DeserializeObject<Worker>(request_client.GetRequest("worker?id=" + appointment.id_doctor));
                appointment.Doctor.Specialization = JsonConvert.DeserializeObject<Specialization>(request_client.GetRequest("spec?id=" + appointment.Doctor.id_specialization));
                NavigationService.Navigate(new AddAppointmentPage(user, appointment));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось получить данные о записи на прием. Подробности: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void btnDeleteAppointment_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var appointment = LViewAppointment.SelectedItem as Appointment;
                string response = request_client.DeleteRequest("appointment?id=" + appointment.id_appointment);
                MessageBox.Show(response);
                UpdateList();
                UpdateData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось удалить запись на прием. Подробности: " + ex.Message , "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
