using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Transform[] floors;
    public Transform ball;
    float halfway;
    
    int nextFloor = 1;
    int prevFloor = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ball.position.z > floors[nextFloor].position.z)
        {
            nextFloor += 1;
            if(nextFloor > 1)
            {
                nextFloor = 0;
                prevFloor = 1;
            }
            else
            {
                nextFloor = 1;
                prevFloor = 0;
            }
            floors[nextFloor].position = new Vector3(floors[nextFloor].position.x,floors[nextFloor].position.y,(floors[prevFloor].position.z + 24f));
            floors [nextFloor].GetComponent<Floor>().HideObstacles();
            floors [nextFloor].GetComponent<Floor>().ShowObstacle();
        }
    }
}
