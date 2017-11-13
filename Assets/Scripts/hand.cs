using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(controller))]

public class hand : MonoBehaviour {
    GameObject heldObject;
    controller controller;

    void Start()
    {
        controller = GetComponent<controller>();
    }

    void Update()
    {
        if (heldObject)
        {
            if (controller.Controller.GetPressUp(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger))
            {
                heldObject.transform.parent = null;
                heldObject.GetComponent<Rigidbody>().isKinematic = false;
                heldObject.GetComponent<heldObject>().parent = null;
                heldObject = null;

            }
        }

        else
        {
            if (controller.Controller.GetPressDown(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger))
            {
                Collider[] cols = Physics.OverlapSphere(transform.position, 0.1f);

                foreach (Collider col in cols)
                {
                    if (heldObject == null && col.GetComponent<heldObject>() && col.GetComponent<heldObject>().parent == null)
                    {
                        heldObject = col.gameObject;
                        heldObject.transform.parent = transform;
                        heldObject.transform.localPosition = Vector3.zero;
                        heldObject.transform.localRotation = Quaternion.identity;
                        heldObject.GetComponent<Rigidbody>().isKinematic = true;
                        heldObject.GetComponent<heldObject>().parent = controller;

                    }
                }

            }
        }
    }
}
