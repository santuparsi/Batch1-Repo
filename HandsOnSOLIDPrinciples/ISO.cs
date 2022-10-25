using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSOLIDPrinciples
{
    public interface IOrder
    {
        void AddToCart();
        
    }
    public interface IOnlineOrder
    {
        void CCProcess();
    }
    public class OnlineOrder : IOrder,IOnlineOrder
    {
        public void AddToCart()
        {
           //Do add to Cart
        }

        public void CCProcess()
        {
           //Process through Credit Card
        }
    }
    public class OfflineOrder:IOrder
    {
        public void AddToCart()
        {
            //Do add to Cart
        }

        
    }
    internal class ISO
    {
    }
}
