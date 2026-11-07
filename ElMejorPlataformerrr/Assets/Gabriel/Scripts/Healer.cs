using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] private PlayersTatsGG _playerStats;
    [SerializeField] private UIManager _uiManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerStats.SumarVida(10);
            _uiManager.SumarFillAmount(0.05f);
            Destroy(this.gameObject);
        }

    }
    

}

