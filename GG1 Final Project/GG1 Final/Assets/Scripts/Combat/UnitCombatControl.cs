using UnityEngine;
using System.Collections;

public class UnitCombatControl : MonoBehaviour
{

    public void Awake()
    {
        CombatEvents.onUnitHit += unitHit;
        CombatEvents.onPlayerDeath += playerDeath;
        CombatEvents.onEnemyDeath += enemyDeath;
    }

    public void OnDestroy()
    {
        CombatEvents.onUnitHit -= unitHit;
        CombatEvents.onPlayerDeath -= playerDeath;
        CombatEvents.onEnemyDeath -= enemyDeath;
    }

    public void unitHit()
    {
        //play hit animation
        //display damage
        //update GUI
    }

    public void playerDeath()
    {
        //play death animation
        //darken sprite/switch to dead sprite
        //remove player from queue
        //update GUI
    }

    public void enemyDeath()
    {
        //play death animation
        //remove sprite
        //remove enemy from queue
        //update GUI
    }

}