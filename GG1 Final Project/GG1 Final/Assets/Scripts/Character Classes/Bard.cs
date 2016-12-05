using UnityEngine;
using System.Collections;

public class Bard : Player {

    public Bard() : base(1, "Sebastien Corbeau", 10, 20, 8, 8, 12, 15, 12, 17)
    {
        
    }

    public override void basicAttack(Unit target)
    {
        target.attacked(this, AttackType.MAG);
    }
}
