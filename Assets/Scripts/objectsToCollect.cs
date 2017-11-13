using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectsToCollect : MonoBehaviour {

	public static int objects = 0;
    

    void Awake()
    {
        objects++;
    }

    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            objects--;
            gameObject.SetActive(false);
        }
    }
}
