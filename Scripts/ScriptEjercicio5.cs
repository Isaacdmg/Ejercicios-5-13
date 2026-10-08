using UnityEngine;

public class ScriptEjercicio5 : MonoBehaviour
{
    public Transform objeto1;
    public Transform objeto2;
    public Transform objeto3;

    public Vector3 desplazamientoObj1;
    public Vector3 desplazamientoObj2;
    public Vector3 desplazamientoObj3;

    private Vector3 posOriginal1;
    private Vector3 posOriginal2;
    private Vector3 posOriginal3;

    void Start()
    {
        // Guardar posiciones iniciales
        if (objeto1 != null) posOriginal1 = objeto1.position;
        if (objeto2 != null) posOriginal2 = objeto2.position;
        if (objeto3 != null) posOriginal3 = objeto3.position;
    }

    void Update()
    {
        // Detección de la barra espaciadora mediante GetAxis("Jump")
        if (Input.GetAxis("Jump") > 0f)
        {
            if (objeto1 != null) objeto1.position = posOriginal1 + desplazamientoObj1;
            if (objeto2 != null) objeto2.position = posOriginal2 + desplazamientoObj2;
            if (objeto3 != null) objeto3.position = posOriginal3 + desplazamientoObj3;
        }
    }
}
