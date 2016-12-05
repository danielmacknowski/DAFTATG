using UnityEngine;
using System.Collections;

public class Ranger : Player {

    public Ranger() : base(2, "Raina Thistledance", 15, 15, 10, 8, 16, 15, 10, 12)
    {
        
    }

    public override void basicAttack(Unit target)
    {
        target.attacked(this, AttackType.DEX);
    }
}
