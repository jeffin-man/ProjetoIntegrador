using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ComecarJogo()
    {
        SceneManager.LoadScene(1);
    }

    public void credits()
    {
               SceneManager.LoadScene(5);
    }

    public void SairJogo()
    {
        Application.Quit();
    }

    
}
