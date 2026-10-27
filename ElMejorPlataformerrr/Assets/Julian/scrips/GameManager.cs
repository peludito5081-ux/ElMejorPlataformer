using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public void CargarEscena(int scena)
    {
        SceneManager.LoadScene(scena);
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }

    public void PausarElJuego(float scale)
    {
        Time.timeScale = 0;

    }

    public void ReanudarJuego()
    {
        Time.timeScale = 1;
    }

    public void Start()
    {
        ReanudarJuego();
    }
}
