using UnityEngine;

public class SistemaLlave : MonoBehaviour
{
  
    [Header("Estado de la llave")]
    [SerializeField] private bool _tieneLlave = false;

    [Header("Objeto que se activa")]
    [SerializeField] private GameObject _puertaVictoria;

    private void Start()
    {
        _tieneLlave = false;

        _puertaVictoria.SetActive(false);
    }

    public void RecogerLlave()
    {
        _tieneLlave = true;

        // Activar la puerta
        _puertaVictoria.SetActive(true);

        Debug.Log("¡Llave conseguida!");
    }

    public bool TieneLlave()
    {
        return _tieneLlave;
    }
}