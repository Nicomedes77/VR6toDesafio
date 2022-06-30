using Microsoft.Win32.SafeHandles;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public float speed = 2f;
    public GameObject camUno,camDos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovimientoJugador();

/*
        if(Input.GetKeyDown(KeyCode.K))
        {
            camUno.SetActive(false);
            camDos.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            camUno.SetActive(true);
            camDos.SetActive(false);
        }        
*/
        if(Input.GetKeyDown(KeyCode.K))
        {
            ToggleCamera();
        }        
    }

    void ToggleCamera()
    {
        if(camUno.activeInHierarchy)
        {
            camUno.SetActive(false);
            camDos.SetActive(true);
        }
        else
        {
            camUno.SetActive(true);
            camDos.SetActive(false);
        }
    }

    void MovimientoJugador()
    {
        /*
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Has presionado la tecla espacio");
            transform.Translate(new Vector3(0,0,0.1f));
        }
        */

        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(hor,0,ver) * speed * Time.deltaTime);
    }
}
