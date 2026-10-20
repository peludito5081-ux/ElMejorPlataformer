using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _fuerzaSalto = 5f;
    [SerializeField] private float _velocidadMovimiento = 5f;
    [SerializeField] private Rigidbody2D _cuerpoRigido2D;
    [SerializeField] public DetectorSuelo _detectorSuelo;

    private void Awake()
    {
        _cuerpoRigido2D = GetComponent<Rigidbody2D>();
        
    }

    private void FixedUpdate()
    {


        if (_detectorSuelo.estaEnSuelo)
        {
            if (Input.GetKey(KeyCode.W))
            {
                _cuerpoRigido2D.linearVelocity = Vector2.up * _fuerzaSalto;
                Debug.Log("Oprimi la tecla");
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * _velocidadMovimiento * Time.deltaTime;

        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * _velocidadMovimiento * Time.deltaTime;

        }

    



    }


}
