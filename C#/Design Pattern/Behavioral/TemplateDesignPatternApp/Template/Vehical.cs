﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPatternApp.Template
{
    abstract class Vehical
    {
        public abstract void Connect();
        public abstract void Select();
        public abstract void Process(int top);
        public abstract void Disconnect();

        public void Run(int top)
        {
            Connect();
            Select();
            Process(top);
            Disconnect();
        }

    }
}
