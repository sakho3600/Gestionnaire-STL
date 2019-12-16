using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionnaireSTL
{
    /// <summary>
    /// Manages open Forms and makes sure that the ApplicationContext of the main loop always has an open form till the last form is closed.
    /// </summary>
    /// <remarks>
    /// To use this class: Simply replace the Application.Run call in program.cs with FormsApplication.Run and make sure that you use AddForm on all opened forms.
    /// </remarks>
    public class FormsApplication
    {
        private static ApplicationContext _appContext;
        private static readonly List<Form> _forms = new List<Form>();

        /// <summary>
        /// Run the Application Loop
        /// </summary>
        public static void Run()
        {
            _appContext = new ApplicationContext();
            Application.Run(_appContext);
        }

        /// <summary>
        /// Run the Application Loop with a given context.
        /// </summary>
        public static void Run(ApplicationContext context)
        {
            _appContext = context;
            if (context.MainForm != null)
            {
                _forms.Add(context.MainForm);
                context.MainForm.Closed += ClosedEventHandler;
            }
            Application.Run(context);
        }

        /// <summary>
        /// Run the Application Loop with a given form.
        /// </summary>
        public static void Run(Form form)
        {
            _forms.Add(form);
            form.Closed += ClosedEventHandler;
            _appContext = new ApplicationContext();
            _appContext.MainForm = form;
            Application.Run(_appContext);
        }

        /// <summary>
        /// Event handler that removes a form when it is closed
        /// </summary>
        private static void ClosedEventHandler(object sender, EventArgs e)
        {
            var form = (Form)sender;
            _forms.Remove(form);
            if (_appContext.MainForm == form && _forms.Count > 0)
                _appContext.MainForm = _forms[0];
        }

        /// <summary>
        /// Add a form to the list of known forms.
        /// </summary>
        /// <param name="form">Form to add to the list.</param>
        public static void AddForm(Form form)
        {
            _forms.Add(form);
            form.Closed += ClosedEventHandler;
        }
    }
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Acceuil mainForm = new Acceuil();
            //mainForm.Show();
            
            FormsApplication.Run(new Acceuil());
        }
    }
}
