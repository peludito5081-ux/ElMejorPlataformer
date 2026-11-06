using UnityEngine;

public class Point : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;
    public ConteoPuntos CnP;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CnP.SumarPuntos();
            Destroy(this.gameObject);
        }

    }


}


