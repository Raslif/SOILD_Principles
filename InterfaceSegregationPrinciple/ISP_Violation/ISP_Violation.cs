namespace InterfaceSegregationPrinciple.ISP_Violation
{
    public class ISP_Violation
    {

    }

    public class Baleno : IVehicle
    {
        public void FourWheelPowerVehicle()
        {
            //throw new System.NotImplementedException();
        }

        public void TwoWheelPowerVehicle()
        {
            // This a two weheel power Vehicle...
        }
    }

    public class Thar : IVehicle
    {
        public void FourWheelPowerVehicle()
        {
            // This a four weheel power Vehicle...
        }

        public void TwoWheelPowerVehicle()
        {
            //throw new System.NotImplementedException();
        }
    }

    public interface IVehicle
    {
        void FourWheelPowerVehicle();
        void TwoWheelPowerVehicle();
    }
}
