using ToDoApp1.ViewModel;

namespace ToDoApp1.View;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
        BindingContext = new FoodViewModel();

    }

  
}

