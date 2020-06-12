using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source_Code
{
    static class ControlJuego
    {
        static private int _vidas, _score, _level, _time, _row, _col, _total;
        static private bool start;
        static private string _playerName;

        static public int vidas { get; set; }
        static public int score { get; set; }
        static public int level { get; set; }
        static public int timer { get; set; }
        static public int total { get; set; }
        static public int row { get; set; }
        static public int col { get; set; }
        static public bool started { get; set; }
        static public string playerName{ get; set; }

    }
}
