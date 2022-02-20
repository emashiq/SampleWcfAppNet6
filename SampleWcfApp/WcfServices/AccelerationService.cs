using SampleWcfApp.WcfServices.Models;
using System.ServiceModel;
using System.Xml.Linq;
namespace SampleWcfApp.WcfServices
{
    public class AccelerationService : IAccelerationService
    {
        public string Speed(string s)
        {
            Console.WriteLine(s + " MPH");
            return s;
        }
        public MachineModel TestMachine(MachineModel machine)
        {
            return machine;
        }
        public void XmlMethod(XElement xml)
        {
            Console.WriteLine(xml.ToString());
        }
    }
}