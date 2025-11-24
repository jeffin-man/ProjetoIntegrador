using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ComecarJogo()
    {
        SceneManager.LoadScene(1);
    }
    public void CréditosJogo()
    {
        SceneManager.LoadScene(2);
    }

    public void SairJogo()
    {
        Application.Quit();
    }
}
