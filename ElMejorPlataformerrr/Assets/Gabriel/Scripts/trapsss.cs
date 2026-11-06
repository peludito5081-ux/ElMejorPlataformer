using UnityEngine;

public class trapsss : MonoBehaviour
{
    //[SerializeField] private PlayerStats _playerStats;
    //[SerializeField] private UIManager _uiManager;
    [SerializeField] private PlayerStatsGabriel _playerStats;
    [SerializeField] private UIManager _uiManager;
    public GameObject panelGG;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            if (collision.gameObject.tag == "Player")
            {
                if (_playerStats._Shield == 1)
                {
                    _playerStats.ShieldDestroyed(1);
                }
                else
                {
                    _playerStats.RestarVida(10);
                    _uiManager.RestarFillAmount(0.1f);
                }
            }
        }
    }
}

