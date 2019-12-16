using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionnaireSTL
{
    /*
     * 
     * 
     * ***** ALL CREDIT GOES TO FOR THE Konrad (konrad@neitzel.de) FOR THE FormsApplication CLASS DEFINITION *****
     * 
     * 
     */
    public class FormsApplication
    {
        private static ApplicationContext _appContext;
        private static readonly List<Form> _forms = new List<Form>();

        public static void Run()
        {
            _appContext = new ApplicationContext();
            Application.Run(_appContext);
        }

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

        public static void Run(Form form)
        {
            _forms.Add(form);
            form.Closed += ClosedEventHandler;
            _appContext = new ApplicationContext();
            _appContext.MainForm = form;
            Application.Run(_appContext);
        }

        private static void ClosedEventHandler(object sender, EventArgs e)
        {
            var form = (Form)sender;
            _forms.Remove(form);
            if (_appContext.MainForm == form && _forms.Count > 0)
                _appContext.MainForm = _forms[0];
        }

        public static void AddForm(Form form)
        {
            _forms.Add(form);
            form.Closed += ClosedEventHandler;
        }
    }
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            FormsApplication.Run(new Acceuil());
        }
    }
}
