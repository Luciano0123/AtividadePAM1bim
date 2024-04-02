namespace atividade
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRolagemClicked(object sender, EventArgs e) {
            int pick = pickerDado.SelectedIndex;
            int nD =  0;
            if (pick == -1)
            {
                nD = 0;
            }
            else if(pick == 0)
            {
                nD = 4;
            }
            else if (pick == 1)
            {
                nD = 6;
            }
            else if (pick == 2)
            {
                nD = 10;
            }
            else if (pick == 3)
            {
                nD = 20;
            }
            else if (pick == 4)
            {
                nD = 100;
            }

            Random aleatorio = new Random();
            int numeroDado = aleatorio.Next(1, nD+1);
            numeroTxt.Text = $"{numeroDado}";
        }

    }

 }

