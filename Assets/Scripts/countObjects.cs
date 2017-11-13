using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countObjects : MonoBehaviour {

    public string nextLevel;
    public GameObject objectToDestroy;
    GameObject objUI;

    void Start()
    {
        objUI = GameObject.Find("ObjectNum");
    }

    void Update()
    {
        objUI.GetComponent<Text>().text = objectsToCollect.objects.ToString();
        if (objectsToCollect.objects == 0)
        {
            Destroy(objectToDestroy);
            objUI.GetComponent<Text>().text = "All objects collected";
        }
    }
}
