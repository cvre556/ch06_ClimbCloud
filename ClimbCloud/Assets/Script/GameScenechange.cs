using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScenechange : MonoBehaviour
{
    public void GameSceneChange()
    {
        SceneManager.LoadScene("GameScene");
    }
}