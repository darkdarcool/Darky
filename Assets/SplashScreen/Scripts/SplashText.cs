using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashText : MonoBehaviour
{
    public Text text;
    private float amountUpOrDown = 0;
    private bool isUp = false;
    // Update is called once per frame
    void Update()
    {
        float x = text.transform.position.x;
        float y = text.transform.position.y;
        if (amountUpOrDown > 5)
        {
            isUp = !isUp;
            amountUpOrDown = 0;
        }
        if (isUp) y += 0.1f;
        else y -= 0.1f;
        Vector3 pos = new Vector3(x, y);
        text.transform.SetPositionAndRotation(pos, new Quaternion(0, 0, 0, 0));
        amountUpOrDown = amountUpOrDown + 0.1f;
        if (Time.time > 4)
        {
            changeScene();
        }
    }
    private void changeScene()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
