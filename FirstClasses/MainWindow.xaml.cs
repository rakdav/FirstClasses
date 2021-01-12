using FirstClasses.Model;
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

namespace FirstClasses
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Employer[] employers;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double m = double.Parse(massa.Text);
                double v = double.Parse(velocity.Text);
                Energy energy = new Energy(m,v);
                Result.Text = energy.KinetikeEnargy().ToString()+" Дж";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
;            }
        }

        private void AddPerson_Click(object sender, RoutedEventArgs e)
        {
            employers = new Employer[5];
            employers[0] = new Employer("Петров", "Бухгалтер", 5000);
            employers[1] = new Employer("Иванов", "Дворник", 2000);
            employers[2] = new Employer("Борисов", "Грузчик", 2500);
            employers[3] = new Employer("Смирнов", "Бухгалтер", 5000);
            employers[4] = new Employer("Ивановский", "Техник", 4000);
            for(int i=0;i<employers.Length;i++)
            {
                list.Items.Add(employers[i].FirstName + " " + employers[i].Post + " " + employers[i].Oklad);
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < employers.Length; i++)
            {
                employers[i].Add();
                list.Items.Add(employers[i].FirstName + " " + employers[i].Post + " " + employers[i].Oklad);
            }
        }

        private void dolg_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < employers.Length; i++)
            {
                employers[i].Change();
                list.Items.Add(employers[i].FirstName + " " + employers[i].Post + " " + employers[i].Oklad);
            }
        }
    }
}
