public class Player : Unit {

   public Player(int id, string displayName, int hp, int sp, int def, int str, int spd, int mag, int res, int cha) :
        base(id, displayName, hp, sp, def, str, spd, mag, res, cha)
    {
        
    }

    public override void basicAttack(Unit target)
    {
        target.attacked(this, AttackType.DEX);
    }

}
