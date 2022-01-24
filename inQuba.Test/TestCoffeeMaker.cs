using InQuba.common.Services;
using Xunit;

namespace inQuba.Test
{
    public class TestCoffeeMaker
    {
        [Fact]
        public void Make_Cappuccino()
        {
            var drinkService = new CappuccinoService();
            var actual = drinkService.MakeDrink();
            const bool expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Make_Latte()
        {
            var drinkService = new LatteService();
            var actual = drinkService.MakeDrink();
            const bool expected = true;
            Assert.Equal(expected, actual);
        }
    }
}
