using UnityEngine;
using System.Collections;

public class BoidSpawner : MonoBehaviour {

    static public BoidSpawner S;
    public Camera cam = new Camera();
    
    public int numBoids = 100;
    public GameObject boidPrefab;
    public float spawnRadius = 100f;
    public float spawnVelocity = 10f;
    public float minVelocity = 0f;
    public float maxVelocity = 30f;
    public float nearDist = 30f;
    public float collisionDist = 5f;
    public float velocityMatchingAmt = 0.01f;
    public float flockCenteringAmt = 0.15f;
    public float collisionAvoidanceAmt = -0.5f;
    public float mouseAttractionAmt = 0.01f;
    public float mouseAvoidanceAmt = 0.75f;
    public float mouseAvoidanceDist = 15f;
    public float velocitLerpAmt = 0.25f;

    public bool ___________________;

    public Vector3 mousePos;


	void Start () {
        S = this;
        for(int i = 0; i<numBoids; i++)
        {
            Instantiate(boidPrefab);
        }
	}
	
	
	void LateUpdate () {
        Vector3 mousePos2d = new Vector3(Input.mousePosition.x, Input.mousePosition.y, this.transform.position.y);
        Debug.Log("2D: " + mousePos2d);
        mousePos = this.cam.ScreenToWorldPoint(mousePos2d);
        Debug.Log("3D: " + mousePos);
    }
}
