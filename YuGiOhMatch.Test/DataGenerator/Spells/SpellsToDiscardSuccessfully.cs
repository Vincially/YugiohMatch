using System.Collections;
using YugiohMatch.Domain.Core;

namespace YuGiOhMatch.Test.DataGenerator.Spells
{
    public class SpellsToDiscardSuccessfully : IEnumerable<SpellCard[]>
    {

        public IEnumerator<SpellCard[]> GetEnumerator()
        {
            yield return new SpellCard[]
            {
                new SpellCard()
                {
                    Name = "Pot of Greed",
                    CurrentStatus = CardStatus.InHand,
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
                    CurrentStatus = CardStatus.InHand,
                    Effects = new Dictionary<int, CardEffect>() {
                            {1, new CardEffect() {ActivationCondition = CardStatus.Activated} }
                        }
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
