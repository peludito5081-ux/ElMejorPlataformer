using UnityEngine;

public class Muertedefinitiva : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private GameObject panelDerrota;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            panelDerrota.SetActive(true);
            Time.timeScale = 0;

        }

    }
}
