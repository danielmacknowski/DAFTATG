using UnityEngine;
using System;
using System.Collections;

public abstract class Unit : MonoBehaviour, IComparable<Unit>
{
    private int id;
    private string displayName;
    private int hp;
    private int sp;
    private int def;
    private int str;
    private int spd;
    private int mag;
    private int res;
    private int cha;

    public enum AttackType {STR, DEX, MAG}

    public int choice;
    public int currentHp;
    public int currentSp;
    public Unit target;

    protected Unit(int id, string displayName, int hp, int sp, int def, int str, int spd, int mag, int res, int cha)
    {
        this.id = id;
        this.displayName = displayName;
        this.hp = hp;
        this.sp = sp;
        this.def = def;
        this.str = str;
        this.spd = spd;
        this.mag = mag;
        this.res = res;
        this.cha = cha;

        currentHp = hp;
        currentSp = sp;
    }

    public int getHp()
    {
        return currentHp;
    }

    public int getSp()
    {
        return currentSp;
    }

    public int CompareTo(Unit other)
    {
        return spd - other.spd;
    }

    public void attacked(Unit attacker, AttackType type)
    {
        int dmg = 1;

        if (!dodge(attacker))
        {
            switch (type)
            {
                default:
                    dmg = 1;
                    break;
                case AttackType.STR:
                    if (def > attacker.str)
                        dmg = 1;
                    else
                        dmg = attacker.str - def;
                    break;
                case AttackType.DEX:
                    if (def > attacker.spd)
                        dmg = 1;
                    else
                        dmg = attacker.spd - def;
                    break;
                case AttackType.MAG:
                    if (res > attacker.mag)
                        dmg = 1;
                    else
                        dmg = attacker.mag - res;
                    break;
            }
            currentHp -= dmg;
        }
    }

    private bool dodge(Unit attacker)
    {
        return ((spd / 100.0f) >= UnityEngine.Random.value);
    }

    //public void healed(Unit caster, int spellid)
    //{

    //}

    public abstract void basicAttack(Unit target);

    /*
    public virtual string[] getAtkChoices()
    {
        //string[] result = ;
        return new string[]{"basicAttack"};
    }
    */

    public virtual void attackLogic(Unit target)
    {
        switch (choice)
        {
            case 1:
                basicAttack(target);
                break;
        }
    }

}
