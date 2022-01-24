using InQuba.common.Constants;
using InQuba.common.Utilities;

namespace InQuba.common.Services
{
    public class LatteService : Drinks
    {
        /// <summary>
        /// Assigns constant values on load
        /// </summary>
        public LatteService()
        {
            Milk = ConstantValues.LatteMilk;
            Beans = ConstantValues.LatteBeans;
        }
    }
}