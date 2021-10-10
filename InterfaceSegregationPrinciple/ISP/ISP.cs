namespace InterfaceSegregationPrinciple.ISP
{
    public class ISP
    {

    }

    public class Baleno : ITwoWheelPowerVehicle
    {
        public void TwoWheelPowerVehicle()
        {
            // This a two weheel power Vehicle...
        }
    }

    public class Thar : IFourWheelPowerVehicle
    {
        public void FourWheelPowerVehicle()
        {
            // This a four weheel power Vehicle...
        }
    }

    public interface IFourWheelPowerVehicle
    {
        void FourWheelPowerVehicle();
    }

    public interface ITwoWheelPowerVehicle
    {
        void TwoWheelPowerVehicle();
    }
}
