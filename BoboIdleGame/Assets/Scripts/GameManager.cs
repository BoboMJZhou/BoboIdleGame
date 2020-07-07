using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Text coinsText;
    public Text coinsPerSecText;
    public Text clickButtonText;
    public Text clickUpgradeText;
    public Text productionUpgradeText;

    public double coins;
    public double coinsPerSec;
    public double coinsClickValue;
    public double clickUpgradeCost;
    public double productionUpgradeCost;
    public double clickPower;
    public int clickUpgradeLvl;
    public int productionUpgradeLvl;

    public void Start()
    {
        coins = 0;
        clickUpgradeCost = 10;
        clickUpgradeLvl = 1;
        productionUpgradeCost = 10;
        productionUpgradeLvl = 0;
        clickPower = 1;
        coinsPerSec = 0;
    }
    public void Update()
    {
        coinsText.text = "Coins: " + coins.ToString("F2");
        coinsPerSecText.text = coinsPerSec.ToString("F2") + " coins/s";

        coinsPerSec = productionUpgradeLvl;
        coins += coinsPerSec * Time.deltaTime;
        
    }
    public void Click()
    {
        coins += clickPower;
    }
    public void BuyClickUpgrade()
    {
        if (coins < clickUpgradeCost)
            return;

        coins -= clickUpgradeCost;
        clickUpgradeLvl += 1;
        clickPower += 1;
        clickUpgradeCost *= 1.07;
        clickUpgradeText.text = "Click Upgrade\n(+" + clickPower + " Coins/click)\n$" + clickUpgradeCost.ToString("F2");
        clickButtonText.text = "Click\n+" + clickPower + " coins";
    }
    public void BuyProductionUpgrade()
    {
        if (coins < productionUpgradeCost)
            return;

        coins -= productionUpgradeCost;
        productionUpgradeLvl += 1;
        productionUpgradeCost *= 1.07;
        productionUpgradeText.text = "Production Lvl. " + productionUpgradeLvl + "\n(+1 Coins/s)\n$" + productionUpgradeCost.ToString("F2");
    }
}
