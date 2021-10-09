namespace InterfaceSegregationPrinciple.ISP
{
    public class ISP
    {

    }

    public class Baleno : ITwoPowerVehicle
    {
        public void TwoPowerVehicle()
        {
            // This a two weheel power Vehicle...
        }
    }

    public class Thar : IFourPowerVehicle
    {
        public void FourPowerVehicle()
        {
            // This a four weheel power Vehicle...
        }
    }

    public interface IFourPowerVehicle
    {
        void FourPowerVehicle();
    }

    public interface ITwoPowerVehicle
    {
        void TwoPowerVehicle();
    }
}
