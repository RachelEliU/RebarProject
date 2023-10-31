using Rebar.Model;

namespace Rebar.Controllers
{
    public class Validation
    {
        public static bool CheckOrder(Order order)
        {
            if(order == null)
            {
                throw new ArgumentNullException("No Order has been recived please enter Order");
                return false;
            }
            
            return true;
        }
        public static bool IsValidString(String inputString)
        {
            if (inputString!=null && !inputString.Equals(""))
            {
                return true;
            }
            throw new ArgumentNullException("No Order has been recived please enter Order");
            return false;
        }
    }
}
