namespace ExpensesApp;
using ExpensesApp.Models;
using Microsoft.Maui.Controls.Platform;

public partial class ExpensesPage : ContentPage
{
    public ExpensesPage()
    {
        InitializeComponent();
    }

    private async void BtnSave_Clicked(object sender, EventArgs e)
    {
        string entryHeader = EntryHeader.Text;
        string description = DescriptionText.Text;
        double expenses = double.Parse(ExpensessText.Text);

        ExpenseModel expensesModel = new() { Header = entryHeader, Description = description, Expense = expenses};

        using(ApplicationContext db = new())
        {
            db.Expenses.Add(expensesModel);
            db.SaveChanges();
        }
        await DisplayAlert("Уведомление", "Новая запись добавлена", "OK");
    }
}