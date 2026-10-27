using UnityEngine;
using UnityEngine.SceneManagement;

public class PuntosEstrella : MonoBehaviour
{
    
    public int valor = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.SumarPuntos(valor);

            Destroy(gameObject);
        }
    }
}

