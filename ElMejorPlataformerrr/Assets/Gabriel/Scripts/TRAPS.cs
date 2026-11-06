using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class TRAPS : MonoBehaviour
{
    public GameObject panelGG;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si el jugador toca un objeto con la etiqueta "Enemy"
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            panelGG.SetActive(true);
        }
    }
}