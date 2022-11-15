using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLose : MonoBehaviour
{
    public Player movement;
    private void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Floor")
        {
            movement.enabled = false;
            Debug.Log("Game Over");
            FindObjectOfType<Manager>().EndGame();
            Invoke("Restart", 0.5f);
            
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
