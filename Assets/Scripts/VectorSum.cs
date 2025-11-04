using UnityEngine;

public class VectorSum : MonoBehaviour
{
    public GameObject Cube1;
    public GameObject Cube2;

    static Vector3 cube1Movement;
    static Vector3 cube2Movement;
    static Vector3 startPos;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        cube1Movement = Cube1.transform.position;
        cube2Movement = Cube2.transform.position;
        transform.position = startPos + (cube1Movement + cube2Movement);
    }
}
