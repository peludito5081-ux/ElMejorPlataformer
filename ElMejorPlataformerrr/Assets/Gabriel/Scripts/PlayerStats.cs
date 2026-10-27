using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private float _puntosVidaActuales = 100f;
    [SerializeField] private int _vidaMaxima;
    [SerializeField] private int _panelGG;

    public GameObject panelGG;
    // Start is called before the first frame update
    public void RestarVida(int daño)
    {
        _puntosVidaActuales = _puntosVidaActuales - daño;
    }
    public void SumarVida(int vida)
    {
        _puntosVidaActuales += vida;
    }
    private void Update()
    {
        if (_puntosVidaActuales >= 100)
        {
            _puntosVidaActuales = 100;
        }
        if (_puntosVidaActuales >= 80)
        {
            _uiManager.ColorBarra(Color.green);
        }
        if (40 <= _puntosVidaActuales && _puntosVidaActuales < 80)
        {
            _uiManager.ColorBarra(Color.yellow);
        }
        if (_puntosVidaActuales < 40)
        {
            _uiManager.ColorBarra(Color.red);
        }
        if (_puntosVidaActuales == 0)
        {
            Time.timeScale = 0;
            panelGG.SetActive(true);
        }
    }
}
