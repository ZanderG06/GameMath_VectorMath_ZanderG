using UnityEngine;

public class VectorAddition : MonoBehaviour
{
    private Vector3 startPos;

    [SerializeField] private int movementX;
    [SerializeField] private int movementY;
    [SerializeField] private int movementZ;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startPos + new Vector3(Mathf.Sin(Time.time * movementX), Mathf.Sin(Time.time * movementY), Mathf.Sin(Time.time * movementZ));
    }
}
