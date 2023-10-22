using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    public string levelName;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Mouse"))
        {

        SceneManager.LoadScene(levelName);
        }
    }
}
