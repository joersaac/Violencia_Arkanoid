using System;
using System.Collections.Generic;
using System.Data;

namespace Source_Code
{
    public static class TopController
    {

        public static List<Player> Top()
        {
            var Top = new List<Player>();

            var dt = ConectionDB.ExecuteQuery(    "SELECT pl.nickname, pun.puntaje " + 
                                                        "FROM PLAYER pl, PUNTAJE pun " +
                                                        "WHERE pl.nickname = pun.nickname " + 
                                                        "ORDER BY pun.puntaje DESC " + 
                                                        "LIMIT 10 ");

            foreach (DataRow dr in dt.Rows)
            {
                Top.Add(new Player(dr[0].ToString(), Convert.ToInt32(dr[1])));
            }
            
            
            
            return Top;
        }


    }
}