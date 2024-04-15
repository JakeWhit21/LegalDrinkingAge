namespace LabC
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void CalculateAgeGap(object sender, EventArgs e)
        {
      
            int date = Convert.ToInt32(birthday_Input.Text);

            int year = date / 10_000;
            int month = (date - year * 10_000) / 100;
            int day = date % 100;

            DateTime dateTime = new DateTime(year, month, day);
            DateTime currentDate = DateTime.Now;

            int age = currentDate.Year - year;

            int difference = 21 - age;

            if(int.IsPositive(difference))
            {
                if (difference == 0)
                {
                    age_Distance.Text = "You turn 21 this year!";
                } else
                {
                    age_Distance.Text = $"{difference} year(s) before you can legally buy alcohol";
                }
            }  else
            {
                age_Distance.Text = "You are able to buy alcohol!";
            }

        }
    }

}
