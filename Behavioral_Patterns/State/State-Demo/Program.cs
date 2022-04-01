using State_Demo;

var phone = new MobilePhoneContext();

Console.WriteLine("Pressing home button.");
phone.PressHomeButton();

Console.WriteLine("Changing the phone state to unlocked.");
phone.ChangeState(new UnlockedScreenState());

Console.WriteLine("Pressing home button.");
phone.PressHomeButton();

Console.ReadKey();