using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    
    private void Start()
    {
        Instantiate(GameManager.instance.CurentCharacter.Prefab, transform.position, Quaternion.identity);
    }

    
}
