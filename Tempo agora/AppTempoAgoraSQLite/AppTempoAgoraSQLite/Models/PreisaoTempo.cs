using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTempoAgoraSQLite.Models
{
 
        using SQLite;
public class PrevisaoTempo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Cidade { get; set; }
        public string Data { get; set; }
        public string Temperatura { get; set; }
        public string Condicao { get; set; }
    }
}

