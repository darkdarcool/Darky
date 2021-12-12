using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeLevel : MonoBehaviour
{

    public Button button;
    public string level;
    void Update()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(onClick);
    }

    private void onClick()
    {
        SceneManager.LoadScene(level, LoadSceneMode.Single);
    } // PrototypingCharacter.unitypackage
    
}
