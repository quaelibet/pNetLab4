using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Komponent
{
    public class ReceivedEventArgs : EventArgs
    {
        public string Text;
        public object sender;
        public ReceivedEventArgs(string Text, object sender)
        {
            this.Text = Text;
            this.sender = sender;
        }
    }
}
