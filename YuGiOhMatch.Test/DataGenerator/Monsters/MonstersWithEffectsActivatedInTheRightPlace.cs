using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YugiohMatch.Domain.Core;

namespace YuGiOhMatch.Test.DataGenerator.Monsters
{
    public class MonstersWithEffectsActivatedInTheRightPlace : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new MonsterCard()
                {
                    Name = "Dark Magician",
                    CurrentStatus = CardStatus.InHand,
                    Effects = new Dictionary<int, CardEffect>() {
                            {1, new CardEffect() {ActivationCondition = CardStatus.InHand} },
                            {2, new CardEffect() {ActivationCondition = CardStatus.InGraveyard} }
                        }
                },
                1
            };
            yield return new object[]
            {
                new MonsterCard()
                {
                    Name = "Blue-Eyes White Dragon",
                    CurrentStatus = CardStatus.Summoned,
                    Effects = new Dictionary<int, CardEffect>() {
                            {1, new CardEffect() {ActivationCondition = CardStatus.InHand} },
                            {2, new CardEffect() {ActivationCondition = CardStatus.Summoned} },
                            {3, new CardEffect() {ActivationCondition = CardStatus.InHand} }
                        }
                },
                2
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
