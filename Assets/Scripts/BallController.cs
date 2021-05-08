using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        transform.eulerAngles = new Vector3(0, Random.Range(30, 120), 0);
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 250);
        transform.eulerAngles = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update() {
    }
}

