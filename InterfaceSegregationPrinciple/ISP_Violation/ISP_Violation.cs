namespace InterfaceSegregationPrinciple.ISP_Violation
{
    public class ISP_Violation
    {

    }

    public class Baleno : IVehicle
    {
        public void FourPowerVehicle()
        {
            //throw new System.NotImplementedException();
        }

        public void TwoPowerVehicle()
        {
            // This a two weheel power Vehicle...
        }
    }

    public class Thar : IVehicle
    {
        public void FourPowerVehicle()
        {
            // This a four weheel power Vehicle...
        }

        public void TwoPowerVehicle()
        {
            //throw new System.NotImplementedException();
        }
    }

    public interface IVehicle
    {
        void FourPowerVehicle();
        void TwoPowerVehicle();
    }
}
