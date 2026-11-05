using UnityEngine;

public class ZonaVictoria : MonoBehaviour
{
    [SerializeField] private GameObject _panelVictoria;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SistemaLlave sistema =
                collision.GetComponent<SistemaLlave>();

            if (sistema != null && sistema.TieneLlave())
            {
                _panelVictoria.SetActive(true);

                Time.timeScale = 0f;
            }
        }
    }
}