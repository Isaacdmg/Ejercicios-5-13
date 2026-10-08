using UnityEngine;

public class ScriptEjercicio6 : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.UpArrow))
        {
            float resultado = velocidad * inputVertical;
            Debug.Log($"Flecha Arriba: {resultado:F2}");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            float resultado = velocidad * inputVertical;
            Debug.Log($"Flecha Abajo: {resultado:F2}");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            float resultado = velocidad * inputHorizontal;
            Debug.Log($"Flecha Derecha: {resultado:F2}");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float resultado = velocidad * inputHorizontal;
            Debug.Log($"Flecha Izquierda: {resultado:F2}");
        }
    }
}