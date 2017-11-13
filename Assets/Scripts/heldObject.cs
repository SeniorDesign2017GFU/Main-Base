using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class heldObject : MonoBehaviour
{
    [HideInInspector]
    public controller parent;
}
