using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScenechange : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("MainScene");
    }
}