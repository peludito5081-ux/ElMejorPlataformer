using UnityEngine;

public class TRAPS : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si el jugador toca un objeto con la etiqueta "Enemy"
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
        }
    }
}