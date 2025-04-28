using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialScenechange : MonoBehaviour
{
    public void TutorialSceneChange()
    {
        SceneManager.LoadScene("TutorialScene");
    }
}