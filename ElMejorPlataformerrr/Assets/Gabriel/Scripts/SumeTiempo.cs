using UnityEngine;

public class SumeTiempo : MonoBehaviour
{
    public Reloj _reloj;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _reloj.SumarTiempo();
            Destroy(this.gameObject);
        }
    }

}
