using UnityEngine;

public class ItemEstrellas : MonoBehaviour
{
    [SerializeField] private int _valor = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SistemaEStrellas contador = collision.GetComponent<SistemaEStrellas>();

            if (contador != null)
            {
                contador.SumarPuntos(_valor);

                Destroy(gameObject);
            }
        }
    }
}