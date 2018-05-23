using System;
using Xunit;

namespace tdd_wit_example
{
    public class UnitTest1
    {
        [Fact]
        public void NewCharacterHas10Health()
        {
            Character rogue = new Character();

            Assert.Equal(10, rogue.hp);
        }
    }
}
