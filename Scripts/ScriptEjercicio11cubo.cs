using UnityEngine;

public class ScriptEjercicio11cubo : MonoBehaviour
{
    public Transform target; 

    public float speed = 3f;
    void Start()
    {
        if (target == null)
        {
            GameObject targetObject = GameObject.FindWithTag("esfera");
            if (targetObject != null)
            {
                target = targetObject.transform;
            }
            else
            {
                Debug.LogWarning("No se encontró un objeto con la etiqueta 'esfera'.");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null) return;

        Vector3 direccion = target.position - transform.position;

        direccion.y = 0f;

        Vector3 direccionNormalizada = direccion.normalized;

        Vector3 desplazamiento = direccionNormalizada * speed * Time.deltaTime;

        transform.Translate(desplazamiento, Space.World);
    }
}
