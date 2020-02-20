using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsstudio
{
    public class clsStudio
    {
        /// <summary>
        ///metodo che mi determina se la connessione è attiva o no 
        /// </summary>
        /// <returns>bool: true= conn attiva, false= conn non attiva </returns>
        public static bool isConnected(string strconn)
        {
             bool bRes = false;
            //istanzio la sql connection per aprire la connessione 
            SqlConnection conn = new SqlConnection(strconn); //devo passargli la stringa di connessione 

            //provo
            try
            {
                conn.Open();
                bRes = true;

            }
            catch (Exception ex )
            {
                Console.WriteLine("attention, connection failed" + ex.ToString());
           
            }
            conn.Close();
            return bRes;
        }
    }
}
