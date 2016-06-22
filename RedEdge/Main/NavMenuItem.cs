using System;
using Windows.UI.Xaml.Controls;

namespace RedEdge.Main
{
    public class NavMenuItem
    {
        public NavMenuItem()
        {

        }

        public string Label { get; set; }
        public Symbol Symbol { get; set; }
        public char SymbolAsChar
        {
            get
            {
                return (char)this.Symbol;
            }
        }

        public Type DestPage { get; set; }
        public object Arguments { get; set; }
    }
}
