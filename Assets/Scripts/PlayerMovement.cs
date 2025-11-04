using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float step;
    public GameObject childCube;
    public GameObject enemy;
    public float playerDotEnemyDir;
    static float scalar = 1f;
    private Vector3 startPos;
    private Vector3 enemyDir;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;

        childCube.transform.position = transform.position + transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) scalar += step;
        if (Input.GetKeyDown(KeyCode.S)) scalar -= step;

        transform.position = startPos * scalar;

        enemyDir = (enemy.transform.position - transform.position).normalized;

        playerDotEnemyDir = Vector3.Dot(enemyDir, transform.position);
    }
}
