using ExpensesApp.Models;

namespace ExpensesApp
{
    public partial class MainPage : ContentPage
    {
        public List<ExpenseModel> Expenses { get; set; } = [];

        public MainPage()
        {
            InitializeComponent();
            using (ApplicationContext db = new())
            {
                Expenses = db.Expenses.ToList();
            }
            LstView.ItemsSource = Expenses;
        }
    }

}
