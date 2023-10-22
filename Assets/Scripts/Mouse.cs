using UnityEngine.SceneManagement;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private Vector2 startingPos;
    
    public void Update()
    {

        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        GetComponent<Rigidbody2D>().MovePosition(mousePos);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Wall"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
