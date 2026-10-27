using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerStats.SumarVida(10);
            Destroy(this.gameObject);
            _uiManager.SumarFillAmount(0.1f);

        }
    }

}

