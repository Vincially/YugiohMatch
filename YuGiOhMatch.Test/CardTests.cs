using Xunit;
using YugiohMatch.Domain.Core;
using YuGiOhMatch.Test.DataGenerator.Monsters;
using YuGiOhMatch.Test.DataGenerator.Spells;

namespace YugiohMatch.Test
{
    public class CardTests
    {
        [Fact]
        public void CardTypeMustBeSpell()
        {
            SpellCard spellCard = new();
            Assert.Equal(CardType.SpellCard, spellCard.Type);
        }

        [Fact]
        public void CardTypeMustBeMonster()
        {
            MonsterCard monsterCard = new();
            Assert.Equal(CardType.MonsterCard, monsterCard.Type);
        }

        [Theory]
        [ClassData(typeof(MonstersWithEffectsActivatedInTheRightPlace))]
        [ClassData(typeof(SpellsWithEffectsActivatedInTheRightPlace))]
        public void EffectActivatedInTheRightPlace(Card card, int numberOfEffectToActivate)
        {
            var activated = card.ActivateEffect(numberOfEffectToActivate);
            Assert.True(activated);
        }

        [Theory]
        [ClassData(typeof(MonstersWithEffectsActivatedInTheWrongPlace))]
        [ClassData(typeof(SpellsWithEffectsActivatedInTheWrongPlace))]
        public void EffectActivatedInTheWrongPlace(Card card, int numberOfEffectToActivate)
        {
            var activated = card.ActivateEffect(numberOfEffectToActivate);
            Assert.False(activated);
        }

        [Theory]
        [ClassData(typeof(MonstersToSetSuccessfully))]
        [ClassData(typeof(SpellsToSetSuccessfully))]
        public void CardSetSuccessfully(Card card)
        {
            var set = card.Set();
            Assert.True(set);
        }

        [Theory]
        [ClassData(typeof(MonstersThatCannotBeSet))]
        [ClassData(typeof(SpellsThatCannotBeSet))]
        public void CardCannotBeSet(Card card)
        {
            var set = card.Set();
            Assert.False(set);
        }

        [Theory]
        [ClassData(typeof(MonstersToDiscardSuccessfully))]
        [ClassData(typeof(SpellsToDiscardSuccessfully))]
        public void CardDiscardedSuccessfully(Card card)
        {
            var discarded = card.Discard();
            Assert.True(discarded);
        }

        [Theory]
        [ClassData(typeof(MonstersThatCannotBeDiscarded))]
        [ClassData(typeof(SpellsThatCannotBeDiscarded))]
        public void CardCannotBeDiscarded(Card card)
        {
            var discarded = card.Discard();
            Assert.False(discarded);
        }      
    }
}