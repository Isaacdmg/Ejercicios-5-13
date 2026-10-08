using UnityEngine;

public class ScriptEjercicio7 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetAxis("Fire") > 0f) 
        {
            Debug.Log($"¡DISPARO! (Acción activada mediante la tecla mapeada 'H')");
        }
    }
}