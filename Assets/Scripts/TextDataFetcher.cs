using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextDataFetcher : MonoBehaviour {

    public Text resultMessageText;

    // Use this for initialization
    void Start () {
        resultMessageText.text = DataSender.resultMessage;
    }

    // Update is called once per frame
    void Update () {
	if (Input.GetKey(KeyCode.Space)){
		SceneManager.LoadScene("Main");
	}else if (Input.GetKey(KeyCode.Backspace)){
		SceneManager.LoadScene("Title");
	}
    }
}