using UnityEngine;

public class ItemEstrella : MonoBehaviour
{
    [SerializeField] private int _valor = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerStats jugador = collision.GetComponent<PlayerStats>();

            if (jugador != null)
            {
                jugador.RecogerEstrella(_valor);

                Destroy(gameObject);
            }
        }
    }
}

