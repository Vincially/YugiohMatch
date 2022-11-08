using System.Collections;
using YugiohMatch.Domain.Core;

namespace YuGiOhMatch.Test.DataGenerator.Spells
{
    public class SpellsWithEffectsActivatedInTheWrongPlace : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SpellCard()
                {
                    Name = "Pot of Greed",
                    CurrentStatus = CardStatus.Set,
                    Effects = new Dictionary<int, CardEffect>() {
                            {1, new CardEffect() {ActivationCondition = CardStatus.Activated} }
                        }
                },
                1
            };
            yield return new object[]
            {
                new SpellCard()
                {
                    Name = "Polymerization",
                    CurrentStatus = CardStatus.InGraveyard,
                    Effects = new Dictionary<int, CardEffect>() {
                            {1, new CardEffect() {ActivationCondition = CardStatus.Activated} }
                        }
                },
                1
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
