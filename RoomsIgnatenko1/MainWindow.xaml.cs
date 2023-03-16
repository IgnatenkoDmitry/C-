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
using RoomLibrary;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        List<Room> lstRooms = new List<Room>();
        Room room = new Room();
        LivingRoom livingRoom = new LivingRoom();
        Office office = new Office();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void BAddRoom_Click(object sender, RoutedEventArgs e)
        {
            Room room = new Room();
            room.RoomLength = Convert.ToDouble(TBLengthR.Text);
            room.RoomWidth = Convert.ToDouble(TBLWidthR.Text);
            lstRooms.Add(room);

        }

        private void BAddLivingRoom_Click(object sender, RoutedEventArgs e)
        {
            LivingRoom livingRoom = new LivingRoom();
            livingRoom.RoomLength = Convert.ToDouble(TBLengthL.Text);
            livingRoom.RoomWidth = Convert.ToDouble(TBLWidthL.Text);
            livingRoom.NumWin = Convert.ToInt32(TBNumS.Text);
            lstRooms.Add(livingRoom);

        }

        private void BAddOffice_Click(object sender, RoutedEventArgs e)
        {
            Office livingRoom = new Office();
            office.RoomLength = Convert.ToDouble(TBLengthL.Text);
            office.RoomWidth = Convert.ToDouble(TBLWidthL.Text);
            office.NumSockets = Convert.ToInt32(TBNumS.Text);
            lstRooms.Add(office);

        }

        private void BGetList_Click(object sender, RoutedEventArgs e)
        {
            ListRooms.Content = " ";
            foreach (Room r in lstRooms)
                ListRooms.Content += r.Info() + " \n";

        }

        private void TBLengthR_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBLengthO_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBLWidthO_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
