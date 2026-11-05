using UnityEngine;

public class RecogerLlave : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SistemaLlave sistema =
                collision.GetComponent<SistemaLlave>();

            if (sistema != null)
            {
                sistema.RecogerLlave();

                Destroy(gameObject);
            }
        }
    }
}