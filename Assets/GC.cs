using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GC : MonoBehaviour
{
    public GameOverScreen GameOverScreen;

    public void GameOver()
    {
        GameOverScreen.Setup();
        Debug.Log("dfhs");
    }
}
