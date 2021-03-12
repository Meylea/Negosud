using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negosud_Client
{
    static class Program
    {
        public static int? itemId = null;
        public static int? clientId = null;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static class FilterValue
        {
            public static string ClientsId { get; set; }
            public static string SuppliersId { get; set; }
        }

        public static class ClientCommandValue
        {
            public static string ClientCommandValueDate { get; set; }
            public static string ClientCommandValueName { get; set; }
            public static string ClientCommandValueId { get; set; }
            public static string ClientCommandValueStatus { get; set; }

        }
    }
}
