using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    [SerializeField] GameObject player;
    Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
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

        //set our new x position
        transform.position = pos;
    }
}
