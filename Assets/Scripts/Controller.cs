using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private float coefficient = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position = transform.position + coefficient * new Vector3(1.0f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position = transform.position - coefficient * new Vector3(1.0f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position = transform.position + coefficient * new Vector3(0.0f, 0.0f, 1.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position = transform.position - coefficient * new Vector3(0.0f, 0.0f, 1.0f);
        }
    }
}
