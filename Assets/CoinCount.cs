using UnityEngine;
using TMPro;

public class CoinCount : MonoBehaviour
{
    public int count;
    public TMP_Text text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        count = PlayerPrefs.GetInt("amount");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            count += 1;
            PlayerPrefs.SetInt("amount", count);
        }

        text.text = "" + count;
    }
}
