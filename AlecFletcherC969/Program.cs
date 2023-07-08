using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AlecFletcherC969
{
    static class Program
    {
        public static int userId;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DBConnection.OpenConnection();
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);

            if (LoginForm.successfulLogin == true)
            {
                HomeForm homeForm = new HomeForm(LoginForm.user, LoginForm.userId);
                Application.Run(homeForm);
            }
            DBConnection.CloseConnection();
        }
    }
}
