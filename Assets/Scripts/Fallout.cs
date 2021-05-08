using UnityEngine;

public class Fallout : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "GameController") {
            GameObject.Find("Master").GetComponent<GameMaster>().GameOver("Failed.........."+"\r\n"+"-space key  to restart.-"+"\r\n"+"-Backspace key to back to title.-");
        }
    }
}
