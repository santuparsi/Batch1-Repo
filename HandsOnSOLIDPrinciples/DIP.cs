using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSOLIDPrinciples
{
    public interface IAutomobile
    {
        void Ignition();
        void Stop();
    }
    public class Jeep : IAutomobile
    {
        public void Ignition()
        {
            Console.WriteLine("Jeep Start");
        }

        public void Stop()
        {
            Console.WriteLine("Jeep Stopped");
        }
    }
    public class SUV:IAutomobile
    {
        public void Ignition()
        {
            Console.WriteLine("SUV Start");
        }

        public void Stop()
        {
            Console.WriteLine("SUV Stopped");
        }
    }
    public class AutomobileController
    {
        IAutomobile m_Automobile;
        public AutomobileController(IAutomobile automobile)
        {
            this.m_Automobile = automobile;
        }
        public void Ignition()
        {
            m_Automobile.Ignition();
        }
        public void Stop()
        {
            m_Automobile.Stop();
        }

    }

    internal class DIP
    {
        static void Main()
        {
            IAutomobile automobile = new Jeep();
            AutomobileController controller = new AutomobileController(automobile);
            controller.Ignition();
            controller.Stop();
            automobile = new SUV();
            AutomobileController controller1 = new AutomobileController(automobile);
            controller1.Ignition();
            controller1.Stop();
        }
    }
}
