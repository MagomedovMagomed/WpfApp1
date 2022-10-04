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
using WpfApp1.DataContent;
using System.Windows.Media.Effects;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
			AppContent.Model1 = new Entities();
			Filtr.Items.Add("Все типы");
			foreach (var i in AppContent.Model1.AgentType)
			{
				Filtr.Items.Add(i.Title);
			}
			Sort.Items.Add("Без сортировки");
			Sort.Items.Add("По названию a-я");
			Sort.Items.Add("По названию я-а"); 
			Sort.Items.Add("По возрастанию");
			Sort.Items.Add("По убыванию");
			Sort.SelectedIndex = 0;
			Filtr.SelectedIndex = 0;
			var _currentAgent = Entities.GetContext().Agent.ToList();
			Agent.ItemsSource = _currentAgent;
			UpdateAgent();
		}

		public void UpdateAgent()
        {
			var CurrentAgent = Entities.GetContext().Agent.ToList();

			if(Filtr.SelectedIndex > 0)
            {
				var test = Filtr.SelectedItem.ToString();
				CurrentAgent = CurrentAgent.Where(p => p.AgentType.Title == Filtr.SelectedItem.ToString()).ToList();
            }

			CurrentAgent = CurrentAgent.Where(p => p.Title.ToLower().Contains(Search.Text.ToLower())).ToList();

			Agent.ItemsSource = CurrentAgent.OrderBy(p => p.Title).ToList();
		}

		private void Filtr_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			UpdateAgent();
		}

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
			UpdateAgent();
		}

        private void Search_SelectionChanged(object sender, RoutedEventArgs e)
        {
			UpdateAgent();
		}
    }
}