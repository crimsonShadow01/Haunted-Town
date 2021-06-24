using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables used to balance multiple parts of the game
    public int partySize = 4; //Modify this to change how big we make the party.
    public float walkSpeed; //Putting this here to be used with navigation.


    //****CONTROL SCHEME*****//
    //MOVEMENT//
    private KeyCode moveLeft = KeyCode.LeftArrow;
    private KeyCode moveRight = KeyCode.RightArrow;
    private KeyCode moveDown = KeyCode.DownArrow;
    private KeyCode moveUp = KeyCode.UpArrow;


    //Relevant fields needed to keep track of
    public enum gameState { MAINMENU, EXPLORE, COMBAT, MENU, INVENTORY, PARTYSELECT } //various game states the player can be in, IE menus/levels/screens. 
    gameState currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        /**
         * Build stuff?
         * Render stuff?
         * Not sure what we're going to need to do
         */
    }

    // Update is called once per frame
    void Update()
    {
        //**This will not stay in this class ultimately. Each switch state will be assigned to it's own 'mini game manager' for it's respective state. Just fleshing out for now since we are still early on**//
        //Check inputs
        switch (currentLevel)
        {
            case gameState.MAINMENU:
                return; //Don't want to do regsiter any inputs on the main menu unless it's clicking buttons on the screen.
            case gameState.EXPLORE:
                if (Input.GetKey(moveLeft))
                {
                    //move left
                    return;
                }
                if (Input.GetKey(moveRight))
                {
                    //move right
                    return;
                }
                break;
            case gameState.COMBAT:
                return; //Combat is button clicking
            case gameState.MENU:
                break;
            case gameState.INVENTORY:
                if (Input.GetKey(moveLeft))
                {
                    //move left in inventory
                }
                if (Input.GetKey(moveRight))
                {
                    //move right in inventory
                }
                if (Input.GetKey(moveDown))
                {
                    //move down in inventory
                }
                if (Input.GetKey(moveUp))
                {
                    //move up in inventory;
                }
                break;
            case gameState.PARTYSELECT:
                break;
            default:
                break;
        }
       
        }
       
    }

    //Methods for the 'middle management' to call

    //something like party health adjustment

    //hunger?

    //swap active party out

    //combat lost
    
    //consumable something
}
