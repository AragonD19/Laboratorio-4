using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("¡Ganaste!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
