using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class SaveData : MonoBehaviour
{
    public string playerName;
    public int playerHighScore;

    public string getPlayerName()
    {
        return this.playerName;
    }

    public void setPlayerName(string playerName)
    {
        this.playerName = playerName;
    }

    public int getPlayerHighScore()
    {
        return this.playerHighScore;
    }

    public void setPlayerHighScore(int playerHighScore)
    {
        this.playerHighScore = playerHighScore;
    }
}
