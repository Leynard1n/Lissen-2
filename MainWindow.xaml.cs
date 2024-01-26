using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lissen_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        AppCont db;
        public MainWindow()
        {
            InitializeComponent();

                db  = new AppCont();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textboxlogin.Text.Trim();
            string pass = passbox.Password.Trim();
            string pass_2 = passbox_2.Password.Trim();
            string email = textboxemail.Text.Trim().ToLower();


            if (login.Length < 5)
            {
                textboxlogin.ToolTip = "Это поле введено не корректно!";
                textboxlogin.Background = Brushes.DarkRed;
            } else if (pass.Length < 5)
            {
                passbox.ToolTip = "Это поле введено не корректно!";
                passbox.Background = Brushes.DarkRed;
            }
            else if (pass != pass_2)
            {
                passbox_2.ToolTip = "Это поле введено не корректно!";
                passbox_2.Background = Brushes.DarkRed;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textboxemail.ToolTip = "Это поле введено не корректно!";
                textboxemail.Background = Brushes.DarkRed;
            }
            else
            {
                textboxlogin.ToolTip = "";
                textboxlogin.Background = Brushes.Transparent;
                passbox.ToolTip = "";
                passbox.Background = Brushes.Transparent;
                passbox_2.ToolTip = "";
                passbox_2.Background = Brushes.Transparent;
                textboxemail.ToolTip = "";
                textboxemail.Background = Brushes.Transparent;

                MessageBox.Show("Всё отлично");
                User user = new User(login , email , pass);

                db.Users.Add(user);
                db.SaveChanges();
            }

        }
    }
}