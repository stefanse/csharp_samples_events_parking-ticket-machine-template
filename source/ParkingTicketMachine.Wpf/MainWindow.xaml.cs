using ParkingTicketMachine.Core;
using System;
using System.Text;
using System.Windows;

namespace ParkingTicketMachine.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, EventArgs e)
        {
            //einsprugnspunkt bei
            FastClock.Instance.Factor = 360;
            FastClock.Instance.Time = DateTime.Now;
            FastClock.Instance.OneMinuteIsOver += Instance_OneMinuteIsOver;
            FastClock.Instance.IsRunning = true;
        }

        private void Instance_OneMinuteIsOver(object sender, DateTime e)
        {
            this.Title = e.ToShortTimeString();
        }

        private void ButtonNew_Click(object sender, RoutedEventArgs e)
        {
            SlotMachineWindow newWindow = new SlotMachineWindow(TextBoxAddress.Text, ButtonPrintTicket_Click); // Methode die aufgerufen wird wenn auf Ticket gedrückt
        }

    }
}
