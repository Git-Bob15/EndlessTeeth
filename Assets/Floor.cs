using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public GameObject[] obstacles;
    // Start is called before the first frame update
    void Start()
    {
        HideObstacles ();
    }

    public void ShowObstacle() 
   {
       int r = Random.Range(0,obstacles.Length);
       obstacles[r].SetActive(true);
   }

    public void HideObstacles ()
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            obstacles[i].SetActive(false);
        }
    }
}
