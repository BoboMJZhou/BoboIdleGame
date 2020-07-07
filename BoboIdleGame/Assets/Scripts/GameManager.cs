using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Text coinsText;
    public double coins;

    public void Start()
    {
        coins = 1;
    }

    public void Update()
    {
        coinsText.text = "Coins: " + coins.ToString();
    }

    public void Click()
    {
        coins += 1;
    }
}
