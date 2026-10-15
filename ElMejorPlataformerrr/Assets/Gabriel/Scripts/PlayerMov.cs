using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    [SerializeField] private float _fuerzaSalto = 2f;
    [SerializeField] private float _velocidadMovimiento = 2f;
    [SerializeField] private Rigidbody2D _cuerpoRigido2D;
    [SerializeField] private DetectorSuelo _detectorSuelo;

    private void Awake()
    {
        _cuerpoRigido2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (_detectorSuelo.estaEnSuelo)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _cuerpoRigido2D.AddForce(Vector2.up * _fuerzaSalto, ForceMode2D.Impulse);
                Debug.Log("Oprimí la tecla");
            }
            
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.position += Vector3.right * _velocidadMovimiento * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.position += Vector3.left * _velocidadMovimiento * Time.deltaTime;
        }

        // _cuerpoRigido2D.linearVelocity = new Vector2(1 * _velocidadMovimiento, _cuerpoRigido2D.linearVelocity.y); Ya no me sirve en este  c+odigo
    }
}
