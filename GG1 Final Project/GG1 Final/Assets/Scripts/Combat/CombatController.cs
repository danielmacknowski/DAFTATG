using UnityEngine;
using System.Collections;
using System;

public class CombatController : MonoBehaviour {

    public enum BattleState { START, CHOICE, RESULT, END };

    public Player[] characters;
    public Enemy[] enemies;
    public Unit[] order;
    public BattleState currentState;
    private Unit currentUnit;
    public delegate void UnitEventHandler(GameObject unit);
    
    // Use this for initialization
	void Start ()
    {
        //animation if applicable
        SetUp();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    private void SetUp()
    {
        currentState = BattleState.START;
        //put party into characters array
        characters[0] = new Ranger();
        //spawn enemies into enemies
        enemies = new Enemy[1];
        float chance = 0.5f;
        bool done = false;
        int enemySize = 0;

        do
        {
            //if (UnityEngine.Random.value > 0.5f)
                enemies[enemySize] = new Goblin();
            /*
            else
            {
                enemies[enemySize] = new Bandit();
            }
            enemySize++;

            if (UnityEngine.Random.value < chance)
            {
                chance -= 0.1f;
            }
            else*/ done = true;
        } while (!done || enemySize < enemies.Length);
        //determine order
        order = new Unit[characters.Length + enemySize];
        for(int i = 0; i < characters.Length; i++)
        {
            order[i] = characters[i];
        }
        for (int i = 0; i < enemySize; i++)
        {
            order[i + characters.Length] = enemies[i];
        }
        Array.Sort(order);
        currentState = BattleState.CHOICE;
        StartCoroutine(playerTurn());
    }    
    IEnumerator playerTurn()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            if (characters[i].currentHp > 0)
            {
                Debug.Log("Make a selection");
                currentUnit = characters[i];
                yield return new WaitUntil(() => characters[i].choice > 0);
            }
        }

        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i] != null)
            {
                enemies[i].choice = 1;//UnityEngine.Random.Range(1, 5);
            }
        }

        currentState = BattleState.RESULT;
        Debug.Log("");

    }

    public void setChoice(int choice)
    {
        currentUnit.choice = choice;
    }

    public void setTarget(Unit target)
    {
        currentUnit.target = target;
    }
    
}
