using System;
using Xunit;

namespace tdd_wit_example
{
    public class CharacterTests
    {
        Character character;

        public CharacterTests()
        {
            character = new Character();
        }

        [Fact]
        public void NewCharacterHas10Health()
        {
            Assert.Equal(10, character.HP);
        }

        [Fact]
        public void AttackHitsSuccessfullyWhenAtOrAboveAC()
        {
            bool attackDidHit = character.ResolveAttack(10);

            Assert.Equal(true, attackDidHit);
        }

        [Fact]
        public void AttackIsNotSuccessfulWhenBelowAC()
        {
            bool attackDidHit = character.ResolveAttack(9);

            Assert.Equal(false, attackDidHit);
        }

        [Fact]
        public void WhenAttackHitsCharacterTakesDamage()
        {
            bool attackDidHit = character.ResolveAttack(10, 10);

            Assert.Equal(0, character.HP);
        }
    }
}

/*
 questions

steps
1. Starting character
2. initial HP
3. get/set HP
4. Check if attack hits or not
5. Takes damage if hit
6. Damage is variable
7. Can heal
8. HP doesn't go below 0
9. HP doesn't go above max
 */