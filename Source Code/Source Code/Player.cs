﻿namespace Source_Code
{
    public class Player
    {
        public string Nickname { get; set; }

        public int Score { get; set; }


        public Player(string nickname, int score)
        {
            Nickname = nickname;
            Score = score;
        }

    }
}