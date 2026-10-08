using UnityEngine;

public class ScriptEjercicio8 : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1f, 0, 0);

    public float moveSpeed = 2f;

    public bool usarSpaceWold = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 posActual = transform.position;
        transform.position = new Vector3(posActual.x, 0f, posActual.z);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dezplazamiento = moveDirection * moveSpeed * Time.deltaTime;
        if (usarSpaceWold)
        {
            transform.Translate(dezplazamiento, Space.World);
        }
        else
        {
            transform.Translate(dezplazamiento, Space.Self);
        }
    }
}
