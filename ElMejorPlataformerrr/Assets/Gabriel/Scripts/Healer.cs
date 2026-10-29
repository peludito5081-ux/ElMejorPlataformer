using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;
    public ConteoPuntos CnP;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerStats.SumarVida(10);
            _uiManager.SumarFillAmount(0.05f);
            CnP.SumarPuntos();


            Destroy(this.gameObject);
        }

    }
    

}

