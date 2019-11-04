using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NBitcoin;
using UnityEngine.UI;

public class Mn : MonoBehaviour
{
    public Text seedText;
    public string password;

    [Space]
    public string seedWord;
    public string newPassword;

    Mnemonic mnemo;
    ExtKey hdRoot;


    // Start is called before the first frame update
    void Start()
    {
        mnemo = new Mnemonic(Wordlist.English, WordCount.Twelve);
        hdRoot = mnemo.DeriveExtKey(password);
        seedText.text = mnemo.ToString();
        Debug.Log(mnemo);
        Debug.Log(hdRoot.PrivateKey.PubKey);
    }

    public void MnemoEnter()
    {
        mnemo = new Mnemonic(seedWord, Wordlist.English);
        hdRoot = mnemo.DeriveExtKey(newPassword);

        Debug.Log("New mnemo:" + mnemo);
        Debug.Log("New PrivateKey:" + hdRoot.PrivateKey.PubKey);
    }
}
