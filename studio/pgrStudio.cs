using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsstudio;


namespace studio
{
    class pgrStudio
    {
        public static string strConn = ConfigurationManager.AppSettings["connessione"].ToString();
        static void Main()
        {
            //scrivo cosa deve succedere se la funzione mi ritorna fase o true 
            if (!clsStudio.isConnected(strConn)) //passo la stringa di connessione al metodo
            {
                Console.WriteLine("connection failed");
            }
            else
            {
                Console.WriteLine("database connected succesfully");
            }
            Console.WriteLine("press a key to exit");
            Console.ReadKey();
        }
    }
}
