using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YugiohMatch.Domain.Core;

namespace YuGiOhMatch.Test.DataGenerator.Spells
{
    public class SpellsWithEffectsActivatedInTheRightPlace : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SpellCard()
                {
                    Name = "Pot of Greed",
                    CurrentStatus = CardStatus.Activated,
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
                    CurrentStatus = CardStatus.Activated,
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
