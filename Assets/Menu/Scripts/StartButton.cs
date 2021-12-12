using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
	public Button button;
	public Text btnText;

	void Start()
	{
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(onClick);
	}

	void onClick()
	{
		btnText.text = "Loading...";
		SceneManager.LoadScene("Levels", LoadSceneMode.Single);
	}
}