using UnityEngine;
using System.Collections;

public class Warrior : Player {

    public Warrior() : base(4, "Flint Ashgar", 20, 10, 18, 15, 8, 5, 5, 8)
    {
       
    }
    public override void basicAttack(Unit target)
    {
        target.attacked(this, AttackType.STR);
    }
}
