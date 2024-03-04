using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    public class Cliente
    {
        public int Score;

        public string AnalisarScore()
        {
            if(Score < 0 || Score > 1000)
            {
                return "O score deve ser um número entre 0 e 1000";
            }
            if(Score >=800)
            {
                return "Ótimo cliente";
            }else if(Score >= 500 && Score < 800)
            {
                return "Precisa de análise";
            }else
            {
                return "Precisa de outras análises";
            }
        }
    }
}
