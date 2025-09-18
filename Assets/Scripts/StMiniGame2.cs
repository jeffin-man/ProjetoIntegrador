using UnityEngine;
using UnityEngine.SceneManagement;

public class StMiniGame2 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(4);
        }
    }
}
