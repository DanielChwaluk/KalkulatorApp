namespace kalkulator
{
    public partial class MainPage : ContentPage
    {   
        int wynik = 0;
        string liczba1 = null;
        string liczba2 = null;
        char znak = ' ';
        bool CzyWynik = false;
        bool CzyOperacja = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void On1Clicked(object sender, EventArgs e) {
            if (CzyWynik == true)
            {
                if (liczba2 == null) liczba2 = "1"; else liczba2 += "1";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            } else if (CzyOperacja == true)
            {
                if (liczba2 == null) liczba2 = "1"; else liczba2 += "1";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if(CzyWynik==false && CzyOperacja == false)
            {  
                if (liczba1 == null) liczba1 = "1"; else liczba1 += "1";
                wynikLbl.Text = liczba1;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            
        }
        private void On2Clicked(object sender, EventArgs e) {
            if (CzyWynik == true)
            {
                if (liczba2 == null) liczba2 = "2"; else liczba2 += "2";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyOperacja == true)
            {
                if (liczba2 == null) liczba2 = "2"; else liczba2 += "2";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyWynik == false && CzyOperacja == false)
            {
                if (liczba1 == null) liczba1 = "2"; else liczba1 += "2";
                wynikLbl.Text = liczba1;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
        }
        private void On3Clicked(object sender, EventArgs e) {
            if (CzyWynik == true)
            {
                if (liczba2 == null) liczba2 = "3"; else liczba2 += "3";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyOperacja == true)
            {
                if (liczba2 == null) liczba2 = "3"; else liczba2 += "3";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyWynik == false && CzyOperacja == false)
            {
                if (liczba1 == null) liczba1 = "3"; else liczba1 += "3";
                wynikLbl.Text = liczba1;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
        }
        private void On4Clicked(object sender, EventArgs e)
        {
            if (CzyWynik == true)
            {
                if (liczba2 == null) liczba2 = "4"; else liczba2 += "4";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyOperacja == true)
            {
                if (liczba2 == null) liczba2 = "4"; else liczba2 += "4";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyWynik == false && CzyOperacja == false)
            {
                if (liczba1 == null) liczba1 = "4"; else liczba1 += "4";
                wynikLbl.Text = liczba1;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }

        }
        private void On5Clicked(object sender, EventArgs e)
        {
            if (CzyWynik == true)
            {
                if (liczba2 == null) liczba2 = "5"; else liczba2 += "5";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyOperacja == true)
            {
                if (liczba2 == null) liczba2 = "5"; else liczba2 += "5";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyWynik == false && CzyOperacja == false)
            {
                if (liczba1 == null) liczba1 = "5"; else liczba1 += "5";
                wynikLbl.Text = liczba1;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }

        }

        private void On6Clicked(object sender, EventArgs e)
        {
            if (CzyWynik == true)
            {
                if (liczba2 == null) liczba2 = "6"; else liczba2 += "6";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyOperacja == true)
            {
                if (liczba2 == null) liczba2 = "6"; else liczba2 += "6";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyWynik == false && CzyOperacja == false)
            {
                if (liczba1 == null) liczba1 = "6"; else liczba1 += "6";
                wynikLbl.Text = liczba1;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }

        }
        private void On7Clicked(object sender, EventArgs e)
        {
            if (CzyWynik == true)
            {
                if (liczba2 == null) liczba2 = "7"; else liczba2 += "7";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyOperacja == true)
            {
                if (liczba2 == null) liczba2 = "7"; else liczba2 += "7";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyWynik == false && CzyOperacja == false)
            {
                if (liczba1 == null) liczba1 = "7"; else liczba1 += "7";
                wynikLbl.Text = liczba1;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }

        }
        private void On8Clicked(object sender, EventArgs e)
        {
            if (CzyWynik == true)
            {
                if (liczba2 == null) liczba2 = "8"; else liczba2 += "8";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyOperacja == true)
            {
                if (liczba2 == null) liczba2 = "8"; else liczba2 += "8";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyWynik == false && CzyOperacja == false)
            {
                if (liczba1 == null) liczba1 = "8"; else liczba1 += "8";
                wynikLbl.Text = liczba1;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }

        }
        private void On9Clicked(object sender, EventArgs e)
        {
            if (CzyWynik == true)
            {
                if (liczba2 == null) liczba2 = "9"; else liczba2 += "9";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyOperacja == true)
            {
                if (liczba2 == null) liczba2 = "9"; else liczba2 += "9";
                wynikLbl.Text = liczba2;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }
            else if (CzyWynik == false && CzyOperacja == false)
            {
                if (liczba1 == null) liczba1 = "9"; else liczba1 += "9";
                wynikLbl.Text = liczba1;
                SemanticScreenReader.Announce(wynikLbl.Text);
            }

        }




        private void OnPlusClicked(object sender, EventArgs e) {
            znak = '+';
            CzyOperacja = true;
        }
        private void OnWynikClicked(object sender, EventArgs e) {
            CzyWynik = true;
            int l1 = Int32.Parse(liczba1);
            int l2 = Int32.Parse(liczba2);
            if (znak == '+')
            {
                wynik = l1 + l2;
                wynikLbl.Text = Convert.ToString(wynik);
            }
            liczba1 = Convert.ToString(wynik);
            liczba2 = null;
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void OnResetClicked(object sender, EventArgs e)
        {
            wynik = 0;
            liczba1 = null;
            liczba2 = null;
            znak = ' ';
            CzyWynik = false;
            CzyOperacja = false;
            wynikLbl.Text = "0";
            SemanticScreenReader.Announce(wynikLbl.Text);
        }

    }
}
/*
 * namespace kalkulator
{
    public partial class MainPage : ContentPage
    {
        string wynik = "0";
        string wynik2 = "0";



        string Wynik = "0";
        string Liczba1 = "0";
        string Liczba2 = "0";
        char znak = ' ';
        bool CzyWynik = false;
        bool CzyOperacja = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void On1Clicked(object sender, EventArgs e) {
            if (CzyOperacja == true && CzyWynik == false)
            {
                if (Liczba2 == "0") Liczba2 = "1";
                else Liczba2 += "1";
            }

            if(CzyWynik == true)
            {
                CzyWynik = false;
                if(Liczba2 == "0") Liczba2 = "1";
                else Liczba2 += "1";
                wynikLbl.Text = Wynik;
            }
            if (Liczba1 == "0") Liczba1 = "1";
            else Liczba1 += "1";
            wynikLbl.Text = Wynik;




            if (CzyOperacja == true && CzyWynik == false)
            {
                if (wynik2 == "0") wynik2 = "1";
                else wynik2 += "1";
                wynikLbl.Text = wynik2;
            }
            else if (CzyOperacja == false && CzyWynik == false)
            {
                if (wynik == "0") wynik = "1";
                else wynik += "1";
                wynikLbl.Text = wynik;
            }



            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On2Clicked(object sender, EventArgs e) {
            if (CzyOperacja == true && CzyWynik == false)
            {
                if (wynik2 == "0") wynik2 = "2";
                else wynik2 += "2";
                wynikLbl.Text = wynik2;
            }
            else if (CzyOperacja == false && CzyWynik == false)
            {
                if (wynik == "0") wynik = "2";
                else wynik += "2";
                wynikLbl.Text = wynik;
            }
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On3Clicked(object sender, EventArgs e) {
            if (CzyOperacja == true && CzyWynik == false)
            {
                if (wynik2 == "0") wynik2 = "3";
                else wynik2 += "3";
                wynikLbl.Text = wynik2;
            }
            else if (CzyOperacja == false && CzyWynik == false)
            {
                if (wynik == "0") wynik = "3";
                else wynik += "3";
                wynikLbl.Text = wynik;
            }


            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void OnPlusClicked(object sender, EventArgs e) {
            znak = '+';
            CzyOperacja = true;
        }
        private void OnWynikClicked(object sender, EventArgs e) { 
            CzyWynik = true;
            int FinalWynik = 0;
            int row1 = Int32.Parse(wynik);
            int row2 = Int32.Parse(wynik2);
            if (znak == '+')
            {
                FinalWynik = row1 + row2;
            }
            Liczba1 = Convert.ToString(FinalWynik);
            Liczba2 = "0";

            wyniklbl.Text = Convert.ToString(FinalWynik);
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void OnResetClicked(object sender, EventArgs e)
        {
            CzyWynik = false;
            CzyOperacja = false;
            wynik = "0";
            wynik2 = "0";
            wynikLbl.Text = Convert.ToString(wynik);
            SemanticScreenReader.Announce(wynikLbl.Text);
        }

    }
}
*/ 