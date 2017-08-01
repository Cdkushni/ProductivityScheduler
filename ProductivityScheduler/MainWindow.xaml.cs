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

using System.Collections.ObjectModel;

namespace ProductivityScheduler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter = 0;
        ScheduleEvent monday = new ScheduleEvent();
        List<EventNode> items = new List<EventNode>();

        public MainWindow()
        {
            InitializeComponent();
            monday.EventList.Add(new EventNode() { day = "Monday", time = 2 });
            monday.EventList.Add(new EventNode() { day = "Tuesday", time = 1 });
            lbMonday.ItemsSource = monday.EventList;
        }

        private void DataGridWeekInit(object sender, EventArgs e)
        {
            monday.EventList.Add(new EventNode() { day = "Wednesday", time = 40 });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DataGridWeekInit(sender, e);
        }
    }

    public interface IProperty
    {
        //TODO: Add changeable node properties here!!!!
    }

    public class EventNode
    {
        
        public string day { get; set; }
        public DateTime formatTime { get; set; }
        public int time { get; set; }

        private ObservableCollection<IProperty> propertyList;
        public ObservableCollection<IProperty> PropertyList
        {
            get
            {
                if (propertyList == null)
                    propertyList = new ObservableCollection<IProperty>();
                return propertyList;
            }
        }
    }

    public class ScheduleEvent
    {
        private ObservableCollection<EventNode> eventList;
        public ObservableCollection<EventNode> EventList
        {
            get
            {
                if (eventList == null)
                    eventList = new ObservableCollection<EventNode>();
                return eventList;
            }
        }

    }

}
