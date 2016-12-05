using UnityEngine;
using System.Collections;

public class Wizard : Player {

    public Wizard() : base(5, "Isobel Velius", 10, 20, 8, 8, 13, 18, 15, 12)
    {
        
    }

    public override void basicAttack(Unit target)
    {
        target.attacked(this, AttackType.MAG);
    }
}
