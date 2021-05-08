using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInit : MonoBehaviour
{

    public GameObject boxObjPrefab;
    public GameObject boxesObj;

    void Awake() {
        GameObject masterObj = GameObject.Find("Master");
        for (int x = 0; x < 10; x++) {
            for (int y = 0; y < 10; y++) {
                GameObject g = Instantiate(boxObjPrefab, boxesObj.transform);
                g.transform.position = new Vector3((0f + (0.6f * y)), 0.4f, (-5.4f + (1.2f * x)));
                g.GetComponent<Destroyer>().masterObj = masterObj;
            }
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
