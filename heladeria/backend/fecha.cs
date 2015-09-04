using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace heladeria.backend
{
    public class fecha
    {
        public String month_year()
        {
            String var = "";
            try

            {

                DateTime Hoy = DateTime.Today;
                string fecha_actual = Hoy.ToString("MMMM-yyyy");
                var =  fecha_actual;
            }
            catch (Exception ex)
            {

            }
            return var.ToUpper();
        }
    }
}
