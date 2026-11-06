using UnityEngine;

public class EscudoItem : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private GameObject _Shield;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        _playerStats.ShieldOn(1);
        _Shield.SetActive(false);
    }
}
