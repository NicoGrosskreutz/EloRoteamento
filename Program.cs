using System;
using System.Windows.Forms;

namespace EloRoteamento
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
				if (args.Length == 0)
				{
					MessageBox.Show("Não foi informado parâmetros para o aplicativo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					Application.Exit();
					return;
				}

				Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Map(args));
                //Application.Run(new Map(new string[] { "vendedor=Nicolas", "datai=18/08/2021 11:40:19", "dataf=29/09/2021 12:17:15", "locais=-23.981,-53.8901&29/09/2019 12:17:15;-23.995,-53.8921&29/09/2019 12:18:15;-24.010,-53.8981&29/09/2019 12:19:15;-23.105,-53.9020&29/09/2019 12:20:15;-23.155,-53.9070&29/09/2019 12:21:15;-23.195,-53.9112&29/09/2019 12:22:15;-23.205,-53.9122&29/09/2019 12:25:15;-23.225,-53.9132&29/09/2019 12:28:15;-23.235,-53.9142&29/09/2019 12:30:15;-23.245,-53.9162&29/09/2019 12:40:15;-23.275,-53.9182&29/09/2019 12:45:15;-23.295,-53.9302&29/09/2019 12:49:15;-23.395,-53.9402&29/09/2019 12:55:15;-23.495,-53.9502&29/09/2019 13:01:15;-24.095,-54.1502&29/09/2019 13:10:15;", "marcas=-23.495,-53.9502&Local da venda;-24.095,-54.1502" }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
