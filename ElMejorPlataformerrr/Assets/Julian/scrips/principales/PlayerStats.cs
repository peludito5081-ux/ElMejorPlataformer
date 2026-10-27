using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] int _puntosVida = 100;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private PlayerStats playerStats;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject panelDerrota;
    public void SumarVida(int vida)
    {
        _puntosVida = _puntosVida + vida;

    }

    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;

    }

    private void Start()
    {
        panelDerrota.SetActive(false);

    }

    public void Update()
    {
        if (_puntosVida >= 80)
        {
            _uiManager.ColorBarra(Color.green);
        }

        if (40 <= _puntosVida && _puntosVida < 80)
        {
            _uiManager.ColorBarra(Color.yellow);
        }
;
        if (_puntosVida < 40)
        {
            _uiManager.ColorBarra(Color.red);
        }

        if (_puntosVida > 100)
        {
            _puntosVida = 100;
        }

        if (_puntosVida <= 0)
        {
            Time.timeScale = 0;
            panelDerrota.SetActive(true);

        }
    }
}
