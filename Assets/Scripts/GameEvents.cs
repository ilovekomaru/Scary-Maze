using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public GameObject[] levels;
    public int gameLevel = 0;
    void Start()
    {
        SetLevel();
        Cursor.visible = false;
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 20;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            gameLevel = 0;
            SetLevel();
        }
    }
    public void SetLevel()
    {
        foreach(GameObject level in levels)
        {
            level.gameObject.SetActive(false);
        }
        levels[gameLevel].gameObject.SetActive(true);
    }

    public void SetGameLevel(int level)
    {
        gameLevel = level;
    }

}
