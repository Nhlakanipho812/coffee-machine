using InQuba.common.Constants;
using InQuba.common.Utilities;

namespace InQuba.common.Services
{
    public class CappuccinoService : Drinks
    {
        /// <summary>
        /// Assigns constant values on load
        /// </summary>
        public CappuccinoService()
        {
            Beans = ConstantValues.CappuccinoBeans;
            Milk = ConstantValues.CappuccinoMilk;
        }
    }
}
