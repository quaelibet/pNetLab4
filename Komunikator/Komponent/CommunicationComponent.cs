using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Komponent
{
    public partial class CommunicationComponent : Component
    {
        public CommunicationComponent()
        {
            InitializeComponent();
        }

        public CommunicationComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
