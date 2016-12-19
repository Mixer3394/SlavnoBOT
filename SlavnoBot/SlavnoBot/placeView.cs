using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlavnoBot
{
    public class placeView
    {
       public static string functionPlaceView(string place)
        {
            try{
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/maps/place/");
                if(place != null)
                {
                    queryaddress.Append(place + "+Sławno");
                    return queryaddress.ToString();
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
