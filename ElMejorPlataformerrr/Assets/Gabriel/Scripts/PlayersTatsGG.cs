using Unity.VisualScripting;
using UnityEngine;

public class PlayersTatsGG : MonoBehaviour
{
    [SerializeField] private PlayersTatsGG _playerStats;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private float _puntosVidaActuales = 100f;
    [SerializeField] private int _vidaMaxima;
    [SerializeField] private int _panelGG;
    public int _Shield = 0;
    public int _maximumShield = 1;

    public GameObject panelGGG;
    // Start is called before the first frame update

    public void ShieldOn(int ShieldsOn)
    {
        _Shield += ShieldsOn;
        if (_Shield > _maximumShield)
        {
            _Shield = _maximumShield;
        }
    }

    public void ShieldDestroyed(int ShieldsDestroyed)
    {
        _Shield -= ShieldsDestroyed;
    }
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
            panelGGG.SetActive(true);
        }
        if (_Shield == 1)
        {
            _uiManager.ColorBarra(Color.aquamarine);
        }
    }
}