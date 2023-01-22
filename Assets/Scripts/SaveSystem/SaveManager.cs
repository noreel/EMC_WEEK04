using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public void SaveGame()
    {

        SaveScript.SaveGame();
    }

    public void LoadGame()
    {

        SaveScript.LoadGame();

    }

}
