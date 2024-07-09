using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace ANSv1
{
    class Common
    {
        /* Check Telegram connection */
        public static bool CheckConnection()
        {
            Cursor.Current = Cursors.WaitCursor;
            Thread.Sleep(100);

            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("https://api.telegram.org/"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
