using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //start
    //reanudar

    public void CargarEscena(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void SalirDelJuego()
    {
        Application.Quit();

    }
    public void PausarElJuego()
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

