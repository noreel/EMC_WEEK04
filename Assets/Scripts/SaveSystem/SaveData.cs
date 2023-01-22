using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    private float X, Y;
    private PlayerHealth Health;
    private void Start()
    {
        X = transform.position.x;
        Y = transform.position.y;
        Health = gameObject.GetComponent<PlayerHealth>();
    }

}
