using UnityEngine;

public class ScalarPosition : MonoBehaviour
{
    public float step;
    static float scalar = 1f;
    private Vector3 startPos;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) scalar += step;
        if (Input.GetKeyDown(KeyCode.S)) scalar -= step;

        transform.position = startPos * scalar;
    }
}
