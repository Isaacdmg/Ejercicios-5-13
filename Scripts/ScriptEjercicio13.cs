using UnityEngine;

public class ScriptEjercicio13 : MonoBehaviour
{
    public float speed = 5f;

    [Tooltip("Velocidad de giro en grados por segundo")]
    public float turnSpeed = 100f;

    [Header("Configuración de Depuración")]
    [Tooltip("Longitud del rayo dibujado en la vista Scene")]
    public float rayLength = 3f;
    public Color rayColor = Color.red;

    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal"); 
        float inputVertical = Input.GetAxis("Vertical");

        float rotacionY = inputHorizontal * turnSpeed * Time.deltaTime;
        transform.Rotate(0f, rotacionY, 0f);

        Vector3 avance = transform.forward * inputVertical * speed * Time.deltaTime;
        transform.Translate(avance, Space.World);
    }
}
