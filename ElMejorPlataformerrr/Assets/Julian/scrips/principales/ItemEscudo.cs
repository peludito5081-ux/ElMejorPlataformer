using UnityEngine;

public class ItemEscudo : MonoBehaviour
{
    [SerializeField] private int cantidadEscudo = 20;

    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Player"))
        {
            PlayerStats stats = otro.GetComponent<PlayerStats>();

            if (stats != null)
            {
                stats.SumarEscudo(cantidadEscudo);
                Destroy(gameObject);
            }
        }
    }
}

