using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Game details
    //need to actually define this and flesh it out more. 
    private playerList players;

    //listen to event here for all the things (attack click, spell click, etc)

    void Start()
    {
        //assign players to the list based on speed/agility. 
    }

    // Update is called once per frame
    void Update()
    {
       //probably won't use this, given we're turn based. but we'll see
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
