using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) 
        {
            return;
        }
        //read posiotn
        Vector3 pos = transform.position;
        //assign our position to the x position of the player
        pos.x = player.transform.position.x;
        if (player.transform.position.y > 4.2f)
        {
            //assign our position to the y position of the player
            pos.y = player.transform.position.y;
        }
        

        //set our new x position
        transform.position = pos;
    }
}
