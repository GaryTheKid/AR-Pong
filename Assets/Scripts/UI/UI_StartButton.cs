using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_StartButton : MonoBehaviour
{
    public void SwitchToGameScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
