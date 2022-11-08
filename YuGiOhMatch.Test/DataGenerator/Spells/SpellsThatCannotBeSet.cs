using System.Collections;
using YugiohMatch.Domain.Core;

namespace YuGiOhMatch.Test.DataGenerator.Spells
{
    public class SpellsThatCannotBeSet : IEnumerable<SpellCard[]>
    {

        public IEnumerator<SpellCard[]> GetEnumerator()
        {
            yield return new SpellCard[]
            {
                new SpellCard()
                {
                    Name = "Pot of Greed",
                    CurrentStatus = CardStatus.Set,
                    Effects = new Dictionary<int, CardEffect>() {
                            {1, new CardEffect() {ActivationCondition = CardStatus.Activated} }
                        }
                }
            };
            yield return new SpellCard[]
            {
                new SpellCard()
                {
                    Name = "Polymerization",
                    CurrentStatus = CardStatus.Activated,
                    Effects = new Dictionary<int, CardEffect>() {
                            {1, new CardEffect() {ActivationCondition = CardStatus.Activated} }
                        }
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
