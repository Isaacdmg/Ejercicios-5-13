using UnityEngine;

public class ScriptEjercicio12cubo : MonoBehaviour
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

        Vector3 targetPositionAjusted = new Vector3(
            target.position.x,
            transform.position.y,
            target.position.z
        );
        transform.LookAt(targetPositionAjusted);
        Vector3 desplazamiento = transform.forward * speed * Time.deltaTime;
        transform.Translate(desplazamiento, Space.Self);
    }
}
