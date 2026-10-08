using UnityEngine;

public class ScriptEjercicio9esfera : MonoBehaviour
{
    public float speed = 2f;   
    void Update()
    {
        float movimientoH = 0f;
        if(Input.GetAxisRaw("Horizontal") > 0) movimientoH = 1f;
        if(Input.GetAxisRaw("Horizontal") < 0) movimientoH = -1f;

        float movimientoV = 0f;
        if(Input.GetAxisRaw("Vertical") > 0) movimientoV = 1f;
        if(Input.GetAxisRaw("Vertical") < 0) movimientoV = -1f;

        Vector3 desplazamiento = new Vector3(movimientoH, movimientoV, 0f) * speed;
        
        transform.Translate(desplazamiento, Space.World);
    }
}
