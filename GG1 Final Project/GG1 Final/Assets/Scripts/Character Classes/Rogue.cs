using UnityEngine;
using System.Collections;

public class Rogue : Player {

	public Rogue() : base(3, "Lila Corbeau", 15, 15, 10, 8, 18, 5, 8, 15)
    {
        
    }

    public override void basicAttack(Unit target)
    {
        target.attacked(this, AttackType.DEX);
    }
}
