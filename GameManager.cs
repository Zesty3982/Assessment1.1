using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManger : MonoBehaviour
{

    public enum GameState
    {
        Start,
        Playing,
        Paused,
        GameOver
    }

    public enum Difficulty { Easy, Medium, Hard }

    public class GameManager : MonoBehaviour
    {
        public GameState gameState;
        public Difficulty difficulty;

        private void Start()
        {
            gameState = GameState.Start;
            difficulty = Difficulty.Easy;
        }
    }

}
