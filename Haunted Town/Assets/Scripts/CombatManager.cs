using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 
/// This will manage the combat scenes. 
/// The GameManager will tell this class what the party is and what the enemies are so that it can instantiate the fight scene properly. 
/// </summary>
public class CombatManager : MonoBehaviour
{
    //**Gameobjects we will need to reference**//

    //'player' prefabs
    public GameObject enemyPlayer;
    public GameObject allyPlayer;
    //Panels
    public GameObject combatMenu;
    //Game States
    public enum State { COMBAT, GAMEOVER, VICTORY, LOADLEVEL, MENU, ALLYTURN, ENEMYTURN}
    State gameState;

    //need to actually define this and flesh it out more. 
    private playerList players;

    //listen to event here for all the things (attack click, spell click, etc)

    void Start()
    {
        SwitchState(State.ALLYTURN);
        //assign players to the list based on speed/agility. 
    }

    // Update is called once per frame
    void Update()
    {
       //probably won't use this, given we're turn based. but we'll see
    }


    //**STATE SWITCHING**//


    public void SwitchState(State newState)
    {
        EndState();
        BeginState(newState);

    }

    void BeginState(State newState)
    {
        switch (newState)
        {
            case State.MENU:
                break;
            case State.VICTORY:
                break;
            case State.GAMEOVER:
                break;
            case State.LOADLEVEL:
                break;
            case State.COMBAT:
                break;
            case State.ALLYTURN:
                //Activate the combat menu, 'select' the current turn
                combatMenu.SetActive(true);
                break;
            case State.ENEMYTURN:
                break;
        }
    }

    void EndState()
    {
        switch (gameState)
        {
            case State.MENU:
                //If we want a start button menu, do that here
                break;
            case State.VICTORY:
                //Display Victory message
                break;
            case State.GAMEOVER:
                break;
            case State.LOADLEVEL:
                break;
            case State.COMBAT:
                break;
        }
    }

    //**BUTTON CLICK HANDLERS**//

    public void AttackClicked()
    {
        Debug.Log("Attack button clicked");
    }

    public void MagicClicked()
    {
        Debug.Log("Magic button clicked");
    }

    public void DefendClicked()
    {
        Debug.Log("Defed button clicked");
    }

    public void ItemClicked()
    {
        Debug.Log("Item button clicked");
    }
}


internal class playerList
{
    //Some data structure to order them in. Needs to support indexing, but also be flexible. Queue might work fine but look into it

    //FIx this: shouldn't return void. needs to let gamemanager know who is next
    public void getFirst()
    {

    }

    //Should get first, shuffle them to last, update order. que/deque or something like that if we use a queue
    public void takeTurn()
    {

    }

    //Take some player, and move them to a spot in the turn order. Might not be needed but gives us the opportunity to implement if we want.
    public void moveTo(int turnSpot)
    {

    }
}
