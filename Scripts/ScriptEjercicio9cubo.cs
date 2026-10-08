using UnityEngine;

public class ScriptEjercicio9cubo : MonoBehaviour
{
    public float speed = 2f;    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        float movimientoH = 0f;
        if(Input.GetAxisRaw("Horizontal Flechas") > 0) movimientoH = 1f;
        if(Input.GetAxisRaw("Horizontal Flechas") < 0) movimientoH = -1f;

        float movimientoV = 0f;
        if(Input.GetAxisRaw("Vertical Flechas") > 0) movimientoV = 1f;
        if(Input.GetAxisRaw("Vertical Flechas") < 0) movimientoV = -1f;

        Vector3 desplazamiento = new Vector3(movimientoH, movimientoV, 0f) * speed;
        
        transform.Translate(desplazamiento, Space.World);
    }
}
