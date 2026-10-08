using UnityEngine;

public class ScriptEjercicio10esfera : MonoBehaviour
{
    public float speed = 5f;   
    void Update()
    {
        float movimientoH = 0f;
        if(Input.GetAxisRaw("Horizontal") > 0) movimientoH = 1f;
        if(Input.GetAxisRaw("Horizontal") < 0) movimientoH = -1f;

        float movimientoV = 0f;
        if(Input.GetAxisRaw("Vertical") > 0) movimientoV = 1f;
        if(Input.GetAxisRaw("Vertical") < 0) movimientoV = -1f;

        Vector3 direccion = new Vector3(movimientoH, movimientoV, 0f);

        Vector3 desplazamiento = direccion * speed * Time.deltaTime; 
               
        transform.Translate(desplazamiento, Space.World);
    }
}
