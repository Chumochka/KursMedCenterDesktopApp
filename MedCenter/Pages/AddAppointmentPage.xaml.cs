using MedCenter.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace MedCenter.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddAppointmentPage.xaml
    /// </summary>
    public partial class AddAppointmentPage : Page
    {
        Worker user = new Worker();
        Appointment appointment = new Appointment();
        fetchData request_client = new fetchData();
        public AddAppointmentPage(Worker currentUser, Appointment currentAppointment)
        {
            InitializeComponent();
            try
            {
                cbPatient.ItemsSource = JsonConvert.DeserializeObject<List<Patient>>(request_client.GetRequest("patients"));
                cbSpecialization.ItemsSource = JsonConvert.DeserializeObject<List<Specialization>>(request_client.GetRequest("specs"));
            }catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить списки пациентов и специальностей. Подробности: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            user = currentUser;
            if(currentAppointment != null)
            {
                appointment = currentAppointment;
                try
                {
                    cbDoctor.IsEnabled = true;
                    cbDoctor.ItemsSource = JsonConvert.DeserializeObject<List<Worker>>(request_client.GetRequest("doctorspecialization?id_specialization="+appointment.Doctor.id_specialization));
                    if(appointment.date != null)
                        tbTime.Text = ((DateTime)appointment.date).ToString("HH:mm");
                }catch (Exception ex)
                {
                    MessageBox.Show("Не удалось загрузить список докторов. Подробности: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }
            DataContext = appointment;
            if (user.id_role == 1)
            {
                appointment.Doctor = user;
                appointment.Doctor.Specialization = user.Specialization;
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnSaveAppointment_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (cbPatient.SelectedItem == null)
                errors.AppendLine("Выберите пациента.");
            if (cbDoctor.SelectedItem == null)
                errors.AppendLine("Выберите доктора.");
            if (datePicker.SelectedDate == null)
                errors.AppendLine("Введите дату приема.");
            if (tbTime.Text == null)
                errors.AppendLine("Введите время приема.");
            DateTime date = new DateTime();
            if (!Regex.IsMatch(tbTime.Text, @"^\d\d:\d\d$"))
                errors.AppendLine("Некорректное время приема. Формат времени - ЧЧ:ММ.");
            try
            {
                DateTime time = DateTime.Parse(tbTime.Text.Replace(" ",""));
                date = datePicker.SelectedDate.Value.Date.Add(time.TimeOfDay);
            }
            catch
            {
                errors.AppendLine("Некорректные дата или время приема. Формат времени - ЧЧ:ММ.");
            }
            if (tbCabinet.Text == null)
                errors.AppendLine("Введите кабинет");
            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(),"Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Appointment appoint = new Appointment()
            {
                id_patient = (cbPatient.SelectedItem as Patient).id_patient,
                id_doctor = (cbDoctor.SelectedItem as Worker).id_worker,
                date_wish = null,
                date = date,
                cabinet = tbCabinet.Text
            };
            var json = JsonConvert.SerializeObject(appoint);
            try
            {
                if(appointment.id_appointment < 1)
                {
                    var responce = request_client.PostRequest("appointment", json);
                    if (responce != null)
                        MessageBox.Show("Запись добавлена.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    var responce = request_client.PutRequest("appointment?id="+appointment.id_appointment, json);
                    if (responce != null)
                        MessageBox.Show("Запись изменена.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                NavigationService.GoBack();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось сохранить данные. Подробности: "+ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cbSpecialization_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if(user.id_role == 1 && appointment.id_appointment < 1)
                    cbDoctor.ItemsSource = JsonConvert.DeserializeObject<List<Worker>>(request_client.GetRequest("doctorspecialization?id_specialization=" + (user.Specialization).id_specialization));
                if (user.id_role == 1)
                {
                    cbDoctor.IsEnabled = false;
                    cbSpecialization.IsEnabled = false;
                    return;
                }
                if(cbSpecialization.SelectedIndex > 0)
                {
                    cbDoctor.IsEnabled = true;
                    cbDoctor.ItemsSource = JsonConvert.DeserializeObject<List<Worker>>(request_client.GetRequest("doctorspecialization?id_specialization=" + (cbSpecialization.SelectedItem as Specialization).id_specialization));
                }
                else
                    cbDoctor.IsEnabled = false;
            }catch(Exception ex)
            {
                MessageBox.Show("Не удалось загрузить список докторов данной специальности. Подробности: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}
