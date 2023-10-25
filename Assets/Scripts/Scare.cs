using UnityEngine;
using UnityEngine.SceneManagement;

public class Scare : MonoBehaviour
{
    public GameObject jumpScare;
    public AudioSource scareSound;
    public string StartingScene = "Menu";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Mouse"))
        {
            jumpScare.SetActive(true);
            scareSound.Play();
            Invoke("Restart", 2f); // Restarts the game after 2 seconds
        }
        void Restart() // restart
        {
            SceneManager.LoadScene(StartingScene);
        }
    }
}
