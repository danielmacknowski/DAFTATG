using UnityEngine;
using System.Collections;

public class CombatEvents : MonoBehaviour
{
    public delegate void CombatHandler();

    public static event CombatHandler onCombatStart;
    public static event CombatHandler onUnitHit;
    public static event CombatHandler onPlayerDeath;
    public static event CombatHandler onEnemyDeath;
    public static event CombatHandler onCombatWin;
    public static event CombatHandler onGameOver;

    public static void combatStart()
    {
        if (onCombatStart != null)
            onCombatStart();
    }

    public static void unitHit()
    {
        if (onUnitHit != null)
            onUnitHit();
    }

    public static void playerDeath()
    {
        if (onPlayerDeath != null)
            onPlayerDeath();
    }

    public static void enemyDeath()
    {
        if (onEnemyDeath != null)
            onEnemyDeath();
    }

    public static void combatWin()
    {
        if (onCombatWin != null)
            onCombatWin();
    }

    public static void gameOver()
    {
        if (onGameOver != null)
            onGameOver();
    }

}
