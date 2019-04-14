using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    interface ISavedBook
    {
        string NameBook { get; set; }
        string Date { get; set; }
        string Pages { get; set; } 
        string Publisher { get; set; }
        string Format { get; set; }
        string Description { get; set; }
        string Authtor1 { get; set; }
        string Authtor2 { get; set; }
        string Authtor3 { get; set; }
    }
}
