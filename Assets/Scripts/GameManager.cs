using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Character[] Characters;

    public Character CurentCharacter;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (Characters.Length > 0)
        {
            CurentCharacter = Characters[0];
        }
    }

    public void SetCharacter(Character character)
    {
        CurentCharacter = character;
    }
}
