using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    public string levelName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Mouse"))
        {

            SceneManager.LoadScene(levelName);
        }
    }
}
