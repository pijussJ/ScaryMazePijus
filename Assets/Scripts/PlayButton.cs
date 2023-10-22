using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    private string levelToGo = "Level1";
    private void OnMouseDown()
    {
        SceneManager.LoadScene(levelToGo);
    }
}
